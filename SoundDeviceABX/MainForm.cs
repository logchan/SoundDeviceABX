using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;

namespace SoundDeviceABX {
    public partial class MainForm : Form {
        private readonly TestConfig _test;
        private readonly int[] _devices;

        private int _trackIdx = 0;
        private int _currentA = 0;
        private int _currentX = 0;
        private readonly List<bool> _results = new();
        private readonly List<bool> _aIsDevice1 = new();
        private readonly List<bool> _xIsDevice1 = new();
        private readonly List<bool> _choiceIsDevice1 = new();
        private bool _started = false;

        private AudioFileReader _audioFile;
        private WaveOutEvent _output;

        public MainForm(TestConfig config) {
            InitializeComponent();

            rewindChk.Checked = AppState.Instance.LastRewind;

            _test = config;
            _devices = new[] {_test.Device1, _test.Device2};
            titleLbl.Text = $"A: {WaveOut.GetCapabilities(_test.Device1).ProductName}, B: {WaveOut.GetCapabilities(_test.Device2).ProductName}";
            _audioFile = new AudioFileReader(_test.AudioFiles[0]);
        }

        private async Task Play(int device) {
            actionGroup.Enabled = false;

            if (_output != null) {
                // TODO is this the correct way?
                var ended = _output.PlaybackState == PlaybackState.Stopped;
                _output.Stop();
                _output.Dispose();
                if (ended || rewindChk.Checked) {
                    _audioFile.Dispose();
                    _audioFile = new AudioFileReader(_test.AudioFiles[_trackIdx]);
                }

            }

            if (_started && _test.RandomVolume) {
                _audioFile.Volume = (float)(Program.Rng.NextDouble() * (1 - _test.MinVolume) + _test.MinVolume);
                volumeLbl.Text = $"Volume: {_audioFile.Volume:N3}";
            }

            await Task.Run(() => { Thread.Sleep(500); });

            _output = new WaveOutEvent {DeviceNumber = _devices[device]};
            _output.Init(_audioFile);
            _output.Play();

            actionGroup.Enabled = true;
        }

        private void MakeNewProblem(bool nextTrack=true) {
            var rng = Program.Rng;
            _currentA = rng.Next(2);
            _currentX = rng.Next(2);
            _aIsDevice1.Add(_currentA == 0);
            _xIsDevice1.Add(_currentX == 0);

            if (_output != null) {
                _output.Stop();
                _output.Dispose();
                _output = null;
            }
            _audioFile.Dispose();

            if (nextTrack) {
                _trackIdx += 1;
            }

            counterLbl.Text = $"{_trackIdx + 1} / {_test.AudioFiles.Count}";
            titleLbl.Text = Path.GetFileNameWithoutExtension(_test.AudioFiles[_trackIdx]);
            _audioFile = new AudioFileReader(_test.AudioFiles[_trackIdx]);

            chooseABtn.Enabled = false;
            chooseBBtn.Enabled = false;
            giveUpBtn.Enabled = false;
        }

        private void SubmitAnswer(int device) {
            _choiceIsDevice1.Add(device == _currentA);
            _results.Add(device == _currentX);

            if (_test.ShowResults) {
                ShowTestResults();
            }

            if (_results.Count == _test.AudioFiles.Count) {
                EndTest();
            }
            else {
                MakeNewProblem();
            }
        }

        private void EndTest() {
            actionGroup.Enabled = false;
            if (_output != null) {
                _output.Stop();
                _output.Dispose();
                _audioFile.Dispose();
                _output = null;
                _audioFile = null;
            }

            ShowTestResults();
            ShowTestSummary();
        }

        private void ShowTestResults() {
            var sb = new StringBuilder();
            var correct = 0;
            foreach (var b in _results) {
                sb.Append(b ? "O" : "X");
                correct += b ? 1 : 0;
            }

            sb.Append($" ({correct} / {_results.Count})");

            resultLbl.Text = sb.ToString();
        }

        private void ShowTestSummary() {
            var sb = new StringBuilder();
            sb.Append("A,X,Choice: ");
            for (var i = 0; i < _aIsDevice1.Count; i++) {
                sb.Append('[');
                sb.Append(_aIsDevice1[i] ? "1" : "2");
                sb.Append(_xIsDevice1[i] ? "1" : "2");
                sb.Append(_choiceIsDevice1[i] ? "1" : "2");
                sb.Append(']');
            }

            summaryLbl.Text = sb.ToString();
        }
        
        private void startBtn_Click(object sender, EventArgs e) {
            MakeNewProblem(false);

            playXBtn.Visible = true;
            chooseABtn.Visible = true;
            chooseBBtn.Visible = true;
            giveUpBtn.Visible = true;
            startBtn.Visible = false;
            _started = true;
        }

        private async void playABtn_Click(object sender, EventArgs e) {
            await Play(_currentA);
        }

        private async void playBBtn_Click(object sender, EventArgs e) {
            await Play(1 - _currentA);
        }

        private async void playXBtn_Click(object sender, EventArgs e) {
            chooseABtn.Enabled = true;
            chooseBBtn.Enabled = true;
            giveUpBtn.Enabled = true;
            await Play(_currentX);
        }

        private void chooseABtn_Click(object sender, EventArgs e) {
            SubmitAnswer(_currentA);
        }

        private void chooseBBtn_Click(object sender, EventArgs e) {
            SubmitAnswer(1 - _currentA);
        }

        private void giveUpBtn_Click(object sender, EventArgs e) {
            SubmitAnswer(1 - _currentX);
        }

        private void rewindChk_CheckedChanged(object sender, EventArgs e) {
            AppState.Instance.LastRewind = rewindChk.Checked;
            AppState.SaveAppState();
        }
    }
}
