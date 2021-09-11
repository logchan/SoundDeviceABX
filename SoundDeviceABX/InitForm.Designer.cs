
namespace SoundDeviceABX {
    partial class InitForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.audioFilesBox = new System.Windows.Forms.TextBox();
            this.readAudioFilesBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.playFilesNum = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.device1Combo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.device2Combo = new System.Windows.Forms.ComboBox();
            this.audioFilesLbl = new System.Windows.Forms.Label();
            this.startBtn = new System.Windows.Forms.Button();
            this.showCorrectChk = new System.Windows.Forms.CheckBox();
            this.shufflePlaylistChk = new System.Windows.Forms.CheckBox();
            this.randomVolumeChk = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.minVolumeBox = new System.Windows.Forms.TextBox();
            this.randomABChk = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.playFilesNum)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Audio files:";
            // 
            // audioFilesBox
            // 
            this.audioFilesBox.Location = new System.Drawing.Point(149, 12);
            this.audioFilesBox.Name = "audioFilesBox";
            this.audioFilesBox.Size = new System.Drawing.Size(685, 35);
            this.audioFilesBox.TabIndex = 1;
            // 
            // readAudioFilesBtn
            // 
            this.readAudioFilesBtn.Location = new System.Drawing.Point(840, 12);
            this.readAudioFilesBtn.Name = "readAudioFilesBtn";
            this.readAudioFilesBtn.Size = new System.Drawing.Size(108, 35);
            this.readAudioFilesBtn.TabIndex = 2;
            this.readAudioFilesBtn.Text = "Read";
            this.readAudioFilesBtn.UseVisualStyleBackColor = true;
            this.readAudioFilesBtn.Click += new System.EventHandler(this.readAudioFilesBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Play every file:";
            // 
            // playFilesNum
            // 
            this.playFilesNum.Location = new System.Drawing.Point(183, 137);
            this.playFilesNum.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.playFilesNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.playFilesNum.Name = "playFilesNum";
            this.playFilesNum.Size = new System.Drawing.Size(120, 35);
            this.playFilesNum.TabIndex = 4;
            this.playFilesNum.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(309, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "time(s)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Device #1:";
            // 
            // device1Combo
            // 
            this.device1Combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.device1Combo.FormattingEnabled = true;
            this.device1Combo.Location = new System.Drawing.Point(143, 185);
            this.device1Combo.Name = "device1Combo";
            this.device1Combo.Size = new System.Drawing.Size(805, 37);
            this.device1Combo.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = "Device #2:";
            // 
            // device2Combo
            // 
            this.device2Combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.device2Combo.FormattingEnabled = true;
            this.device2Combo.Location = new System.Drawing.Point(143, 236);
            this.device2Combo.Name = "device2Combo";
            this.device2Combo.Size = new System.Drawing.Size(805, 37);
            this.device2Combo.TabIndex = 9;
            // 
            // audioFilesLbl
            // 
            this.audioFilesLbl.AutoSize = true;
            this.audioFilesLbl.Location = new System.Drawing.Point(12, 66);
            this.audioFilesLbl.Name = "audioFilesLbl";
            this.audioFilesLbl.Size = new System.Drawing.Size(154, 29);
            this.audioFilesLbl.TabIndex = 10;
            this.audioFilesLbl.Text = "(not read yet)";
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(17, 454);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(204, 57);
            this.startBtn.TabIndex = 11;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // showCorrectChk
            // 
            this.showCorrectChk.AutoSize = true;
            this.showCorrectChk.Location = new System.Drawing.Point(17, 293);
            this.showCorrectChk.Name = "showCorrectChk";
            this.showCorrectChk.Size = new System.Drawing.Size(410, 33);
            this.showCorrectChk.TabIndex = 12;
            this.showCorrectChk.Text = "Show correct / incorrect during test";
            this.showCorrectChk.UseVisualStyleBackColor = true;
            // 
            // shufflePlaylistChk
            // 
            this.shufflePlaylistChk.AutoSize = true;
            this.shufflePlaylistChk.Location = new System.Drawing.Point(17, 332);
            this.shufflePlaylistChk.Name = "shufflePlaylistChk";
            this.shufflePlaylistChk.Size = new System.Drawing.Size(193, 33);
            this.shufflePlaylistChk.TabIndex = 13;
            this.shufflePlaylistChk.Text = "Shuffle playlist";
            this.shufflePlaylistChk.UseVisualStyleBackColor = true;
            // 
            // randomVolumeChk
            // 
            this.randomVolumeChk.AutoSize = true;
            this.randomVolumeChk.Location = new System.Drawing.Point(17, 371);
            this.randomVolumeChk.Name = "randomVolumeChk";
            this.randomVolumeChk.Size = new System.Drawing.Size(214, 33);
            this.randomVolumeChk.TabIndex = 14;
            this.randomVolumeChk.Text = "Random volume";
            this.randomVolumeChk.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(309, 372);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(211, 29);
            this.label6.TabIndex = 15;
            this.label6.Text = "Min (decimal 0~1):";
            // 
            // minVolumeBox
            // 
            this.minVolumeBox.Location = new System.Drawing.Point(526, 369);
            this.minVolumeBox.Name = "minVolumeBox";
            this.minVolumeBox.Size = new System.Drawing.Size(156, 35);
            this.minVolumeBox.TabIndex = 16;
            this.minVolumeBox.Text = "0.7";
            // 
            // randomABChk
            // 
            this.randomABChk.AutoSize = true;
            this.randomABChk.Location = new System.Drawing.Point(17, 406);
            this.randomABChk.Name = "randomABChk";
            this.randomABChk.Size = new System.Drawing.Size(167, 33);
            this.randomABChk.TabIndex = 17;
            this.randomABChk.Text = "Random AB";
            this.randomABChk.UseVisualStyleBackColor = true;
            // 
            // InitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 523);
            this.Controls.Add(this.randomABChk);
            this.Controls.Add(this.minVolumeBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.randomVolumeChk);
            this.Controls.Add(this.shufflePlaylistChk);
            this.Controls.Add(this.showCorrectChk);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.audioFilesLbl);
            this.Controls.Add(this.device2Combo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.device1Combo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.playFilesNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.readAudioFilesBtn);
            this.Controls.Add(this.audioFilesBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "InitForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SoundDeviceABX - Init";
            ((System.ComponentModel.ISupportInitialize)(this.playFilesNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox audioFilesBox;
        private System.Windows.Forms.Button readAudioFilesBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown playFilesNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox device1Combo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox device2Combo;
        private System.Windows.Forms.Label audioFilesLbl;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.CheckBox showCorrectChk;
        private System.Windows.Forms.CheckBox shufflePlaylistChk;
        private System.Windows.Forms.CheckBox randomVolumeChk;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox minVolumeBox;
        private System.Windows.Forms.CheckBox randomABChk;
    }
}

