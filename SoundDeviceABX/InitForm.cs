using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using NAudio.Wave;

namespace SoundDeviceABX {
    public partial class InitForm : Form {
        private readonly List<string> _audioFiles = new();
        
        public InitForm() {
            InitializeComponent();

            var state = AppState.Instance;
            if (!String.IsNullOrEmpty(state.LastAudioFiles)) {
                audioFilesBox.Text = state.LastAudioFiles;
                LoadAudioFiles(true);
            }

            showCorrectChk.Checked = state.LastShowResults;
            shufflePlaylistChk.Checked = state.LastShuffle;
            randomVolumeChk.Checked = state.LastRandomVolume;
            minVolumeBox.Text = state.LastMinVolume;
            randomABChk.Checked = state.LastRandomAB;

            FindAudioDevices(true);
        }

        private void readAudioFilesBtn_Click(object sender, EventArgs e) {
            _audioFiles.Clear();
            LoadAudioFiles(false);
        }

        private void LoadAudioFiles(bool silence) {
            try {
                _audioFiles.AddRange(Directory.GetFiles(audioFilesBox.Text));
                AppState.Instance.LastAudioFiles = audioFilesBox.Text;
                AppState.SaveAppState();
                UpdateAudioFilesLabel();
            }
            catch (Exception ex) {
                if (!silence) {
                    ShowError(ex.Message, "Unable to load audio files");
                }
            }
        }

        private void UpdateAudioFilesLabel() {
            if (_audioFiles.Count > 0) {
                audioFilesLbl.Text = $"Found {_audioFiles.Count} files";
                audioFilesLbl.ForeColor = Color.Green;
            }
            else {
                audioFilesLbl.Text = "No files found";
                audioFilesLbl.ForeColor = Color.Red;
            }
        }

        private void FindAudioDevices(bool isInit) {
            try {
                device1Combo.Items.Clear();
                device2Combo.Items.Clear();
                for (var i = 0; i < WaveOut.DeviceCount; i++) {
                    var caps = WaveOut.GetCapabilities(i);
                    device1Combo.Items.Add(caps.ProductName);
                    device2Combo.Items.Add(caps.ProductName);
                }

                if (isInit) {
                    var state = AppState.Instance;
                    TryApplySelectedIndex(device1Combo, state.LastDevice1);
                    TryApplySelectedIndex(device2Combo, state.LastDevice2);
                }
            }
            catch (Exception ex) {
                ShowError(ex.Message, "Unable to enumerate audio devices");
            }
        }

        private void startBtn_Click(object sender, EventArgs e) {
            if (_audioFiles.Count == 0) {
                ShowError("No audio file available");
                return;
            }

            if (device1Combo.SelectedIndex < 0 ||
                device2Combo.SelectedIndex < 0 ||
                device1Combo.SelectedIndex == device2Combo.SelectedIndex) {
                ShowError("Device selection invalid");
                return;
            }

            var minVolume = 1f;
            if (randomVolumeChk.Checked && 
                (!Single.TryParse(minVolumeBox.Text, out minVolume) ||
                    minVolume <= 0f ||
                    minVolume >= 1f)) {
                ShowError("Min volume invalid");
                return;
            }

            var cfg = new TestConfig {
                AudioFiles = _audioFiles.SelectMany(f => Enumerable.Range(0, (int) playFilesNum.Value).Select(_ => f)).ToList(),
                Device1 = device1Combo.SelectedIndex,
                Device2 = device2Combo.SelectedIndex,
                ShowResults = showCorrectChk.Checked,
                RandomVolume = randomVolumeChk.Checked,
                MinVolume = minVolume,
                RandomAB = randomABChk.Checked,
            };
            if (shufflePlaylistChk.Checked) {
                Shuffle(cfg.AudioFiles);
            }

            var state = AppState.Instance;
            state.LastDevice1 = cfg.Device1;
            state.LastDevice2 = cfg.Device2;
            state.LastShowResults = cfg.ShowResults;
            state.LastShuffle = shufflePlaylistChk.Checked;
            state.LastRandomVolume = cfg.RandomVolume;
            state.LastRandomAB = cfg.RandomAB;
            if (cfg.RandomVolume) {
                state.LastMinVolume = minVolumeBox.Text;
            }
            AppState.SaveAppState();

            var frm = new MainForm(cfg);
            
            Hide();
            frm.ShowDialog();
            Close();
        }

        private static void ShowError(string message, string title="Error") {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private static void TryApplySelectedIndex(ComboBox combo, int index) {
            if (index < 0 || index >= combo.Items.Count) {
                return;
            }

            combo.SelectedIndex = index;
        }

        private static void Shuffle<T>(IList<T> list) {
            for (var i = 0; i < list.Count - 1; ++i) {
                var j = Program.Rng.Next(i, list.Count);
                if (i != j) {
                    var t = list[i];
                    list[i] = list[j];
                    list[j] = t;
                }
            }
        }
    }
}
