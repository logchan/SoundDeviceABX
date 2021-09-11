
namespace SoundDeviceABX {
    partial class MainForm {
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
            this.counterLbl = new System.Windows.Forms.Label();
            this.titleLbl = new System.Windows.Forms.Label();
            this.resultLbl = new System.Windows.Forms.Label();
            this.actionGroup = new System.Windows.Forms.GroupBox();
            this.giveUpBtn = new System.Windows.Forms.Button();
            this.chooseBBtn = new System.Windows.Forms.Button();
            this.chooseABtn = new System.Windows.Forms.Button();
            this.playXBtn = new System.Windows.Forms.Button();
            this.playBBtn = new System.Windows.Forms.Button();
            this.playABtn = new System.Windows.Forms.Button();
            this.summaryLbl = new System.Windows.Forms.Label();
            this.startBtn = new System.Windows.Forms.Button();
            this.rewindChk = new System.Windows.Forms.CheckBox();
            this.volumeLbl = new System.Windows.Forms.Label();
            this.actionGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // counterLbl
            // 
            this.counterLbl.AutoSize = true;
            this.counterLbl.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.counterLbl.Location = new System.Drawing.Point(12, 9);
            this.counterLbl.Name = "counterLbl";
            this.counterLbl.Size = new System.Drawing.Size(467, 28);
            this.counterLbl.TabIndex = 6;
            this.counterLbl.Text = "Adjust your volumes by playing A, B";
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Location = new System.Drawing.Point(12, 53);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(29, 29);
            this.titleLbl.TabIndex = 7;
            this.titleLbl.Text = "--";
            // 
            // resultLbl
            // 
            this.resultLbl.AutoSize = true;
            this.resultLbl.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLbl.Location = new System.Drawing.Point(12, 501);
            this.resultLbl.Name = "resultLbl";
            this.resultLbl.Size = new System.Drawing.Size(181, 28);
            this.resultLbl.TabIndex = 8;
            this.resultLbl.Text = "[Results TBA]";
            // 
            // actionGroup
            // 
            this.actionGroup.Controls.Add(this.giveUpBtn);
            this.actionGroup.Controls.Add(this.chooseBBtn);
            this.actionGroup.Controls.Add(this.chooseABtn);
            this.actionGroup.Controls.Add(this.playXBtn);
            this.actionGroup.Controls.Add(this.playBBtn);
            this.actionGroup.Controls.Add(this.playABtn);
            this.actionGroup.Location = new System.Drawing.Point(12, 134);
            this.actionGroup.Name = "actionGroup";
            this.actionGroup.Size = new System.Drawing.Size(802, 316);
            this.actionGroup.TabIndex = 9;
            this.actionGroup.TabStop = false;
            // 
            // giveUpBtn
            // 
            this.giveUpBtn.Location = new System.Drawing.Point(534, 222);
            this.giveUpBtn.Name = "giveUpBtn";
            this.giveUpBtn.Size = new System.Drawing.Size(258, 65);
            this.giveUpBtn.TabIndex = 11;
            this.giveUpBtn.Text = "Give up";
            this.giveUpBtn.UseVisualStyleBackColor = true;
            this.giveUpBtn.Visible = false;
            this.giveUpBtn.Click += new System.EventHandler(this.giveUpBtn_Click);
            // 
            // chooseBBtn
            // 
            this.chooseBBtn.Location = new System.Drawing.Point(270, 222);
            this.chooseBBtn.Name = "chooseBBtn";
            this.chooseBBtn.Size = new System.Drawing.Size(258, 65);
            this.chooseBBtn.TabIndex = 10;
            this.chooseBBtn.Text = "X is B";
            this.chooseBBtn.UseVisualStyleBackColor = true;
            this.chooseBBtn.Visible = false;
            this.chooseBBtn.Click += new System.EventHandler(this.chooseBBtn_Click);
            // 
            // chooseABtn
            // 
            this.chooseABtn.Location = new System.Drawing.Point(6, 222);
            this.chooseABtn.Name = "chooseABtn";
            this.chooseABtn.Size = new System.Drawing.Size(258, 65);
            this.chooseABtn.TabIndex = 9;
            this.chooseABtn.Text = "X is A";
            this.chooseABtn.UseVisualStyleBackColor = true;
            this.chooseABtn.Visible = false;
            this.chooseABtn.Click += new System.EventHandler(this.chooseABtn_Click);
            // 
            // playXBtn
            // 
            this.playXBtn.Location = new System.Drawing.Point(534, 34);
            this.playXBtn.Name = "playXBtn";
            this.playXBtn.Size = new System.Drawing.Size(258, 170);
            this.playXBtn.TabIndex = 8;
            this.playXBtn.Text = "X";
            this.playXBtn.UseVisualStyleBackColor = true;
            this.playXBtn.Visible = false;
            this.playXBtn.Click += new System.EventHandler(this.playXBtn_Click);
            // 
            // playBBtn
            // 
            this.playBBtn.Location = new System.Drawing.Point(270, 34);
            this.playBBtn.Name = "playBBtn";
            this.playBBtn.Size = new System.Drawing.Size(258, 170);
            this.playBBtn.TabIndex = 7;
            this.playBBtn.Text = "B";
            this.playBBtn.UseVisualStyleBackColor = true;
            this.playBBtn.Click += new System.EventHandler(this.playBBtn_Click);
            // 
            // playABtn
            // 
            this.playABtn.Location = new System.Drawing.Point(6, 34);
            this.playABtn.Name = "playABtn";
            this.playABtn.Size = new System.Drawing.Size(258, 170);
            this.playABtn.TabIndex = 6;
            this.playABtn.Text = "A";
            this.playABtn.UseVisualStyleBackColor = true;
            this.playABtn.Click += new System.EventHandler(this.playABtn_Click);
            // 
            // summaryLbl
            // 
            this.summaryLbl.AutoSize = true;
            this.summaryLbl.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summaryLbl.Location = new System.Drawing.Point(12, 548);
            this.summaryLbl.Name = "summaryLbl";
            this.summaryLbl.Size = new System.Drawing.Size(181, 28);
            this.summaryLbl.TabIndex = 10;
            this.summaryLbl.Text = "[Summary TBA]";
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(660, 12);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(144, 65);
            this.startBtn.TabIndex = 12;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // rewindChk
            // 
            this.rewindChk.AutoSize = true;
            this.rewindChk.Location = new System.Drawing.Point(17, 95);
            this.rewindChk.Name = "rewindChk";
            this.rewindChk.Size = new System.Drawing.Size(268, 33);
            this.rewindChk.TabIndex = 13;
            this.rewindChk.Text = "Rewind when playing";
            this.rewindChk.UseVisualStyleBackColor = true;
            this.rewindChk.CheckedChanged += new System.EventHandler(this.rewindChk_CheckedChanged);
            // 
            // volumeLbl
            // 
            this.volumeLbl.AutoSize = true;
            this.volumeLbl.Location = new System.Drawing.Point(13, 453);
            this.volumeLbl.Name = "volumeLbl";
            this.volumeLbl.Size = new System.Drawing.Size(165, 29);
            this.volumeLbl.TabIndex = 14;
            this.volumeLbl.Text = "Volume: 1.000";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(823, 596);
            this.Controls.Add(this.volumeLbl);
            this.Controls.Add(this.rewindChk);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.summaryLbl);
            this.Controls.Add(this.actionGroup);
            this.Controls.Add(this.resultLbl);
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.counterLbl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SoundDeviceABX - Main";
            this.actionGroup.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label counterLbl;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Label resultLbl;
        private System.Windows.Forms.GroupBox actionGroup;
        private System.Windows.Forms.Button giveUpBtn;
        private System.Windows.Forms.Button chooseBBtn;
        private System.Windows.Forms.Button chooseABtn;
        private System.Windows.Forms.Button playXBtn;
        private System.Windows.Forms.Button playBBtn;
        private System.Windows.Forms.Button playABtn;
        private System.Windows.Forms.Label summaryLbl;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.CheckBox rewindChk;
        private System.Windows.Forms.Label volumeLbl;
    }
}