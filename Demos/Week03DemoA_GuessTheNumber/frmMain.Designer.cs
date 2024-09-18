namespace Week03DemoA_GuessTheNumber
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panMenu = new System.Windows.Forms.Panel();
            this.btnIceCream = new System.Windows.Forms.Button();
            this.btnGTN = new System.Windows.Forms.Button();
            this.lblMenuTitle = new System.Windows.Forms.Label();
            this.panGTN = new System.Windows.Forms.Panel();
            this.nudGTNnumGuesses = new System.Windows.Forms.NumericUpDown();
            this.nudGTNActualNumber = new System.Windows.Forms.NumericUpDown();
            this.lblGTNOutput = new System.Windows.Forms.Label();
            this.btnGTNGuess = new System.Windows.Forms.Button();
            this.gbxGTNSettings = new System.Windows.Forms.GroupBox();
            this.cboGTNSettingDifficulty = new System.Windows.Forms.ComboBox();
            this.lblGTNGuessMaximum = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblGTNSettingsDifficulty = new System.Windows.Forms.Label();
            this.nudGTNGuess = new System.Windows.Forms.NumericUpDown();
            this.lblGTNEnterGuess = new System.Windows.Forms.Label();
            this.lblGTNTitle = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.toolTips = new System.Windows.Forms.ToolTip(this.components);
            this.btnGTNPlayAgain = new System.Windows.Forms.Button();
            this.panMenu.SuspendLayout();
            this.panGTN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGTNnumGuesses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGTNActualNumber)).BeginInit();
            this.gbxGTNSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGTNGuess)).BeginInit();
            this.SuspendLayout();
            // 
            // panMenu
            // 
            this.panMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panMenu.BackColor = System.Drawing.Color.Black;
            this.panMenu.Controls.Add(this.btnIceCream);
            this.panMenu.Controls.Add(this.btnGTN);
            this.panMenu.Controls.Add(this.lblMenuTitle);
            this.panMenu.Location = new System.Drawing.Point(1, -1);
            this.panMenu.Name = "panMenu";
            this.panMenu.Size = new System.Drawing.Size(157, 620);
            this.panMenu.TabIndex = 0;
            // 
            // btnIceCream
            // 
            this.btnIceCream.Location = new System.Drawing.Point(9, 141);
            this.btnIceCream.Name = "btnIceCream";
            this.btnIceCream.Size = new System.Drawing.Size(136, 66);
            this.btnIceCream.TabIndex = 2;
            this.btnIceCream.Text = "Ice Cream";
            this.btnIceCream.UseVisualStyleBackColor = true;
            // 
            // btnGTN
            // 
            this.btnGTN.Location = new System.Drawing.Point(9, 72);
            this.btnGTN.Name = "btnGTN";
            this.btnGTN.Size = new System.Drawing.Size(136, 66);
            this.btnGTN.TabIndex = 1;
            this.btnGTN.Text = "Guess The &Number";
            this.toolTips.SetToolTip(this.btnGTN, "Run Guess The Number Game (alt-N)");
            this.btnGTN.UseVisualStyleBackColor = true;
            this.btnGTN.Click += new System.EventHandler(this.btnGTN_Click);
            // 
            // lblMenuTitle
            // 
            this.lblMenuTitle.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblMenuTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMenuTitle.Location = new System.Drawing.Point(8, 8);
            this.lblMenuTitle.Name = "lblMenuTitle";
            this.lblMenuTitle.Size = new System.Drawing.Size(139, 58);
            this.lblMenuTitle.TabIndex = 0;
            this.lblMenuTitle.Text = "My Little Games";
            this.lblMenuTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panGTN
            // 
            this.panGTN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panGTN.Controls.Add(this.btnGTNPlayAgain);
            this.panGTN.Controls.Add(this.nudGTNnumGuesses);
            this.panGTN.Controls.Add(this.nudGTNActualNumber);
            this.panGTN.Controls.Add(this.lblGTNOutput);
            this.panGTN.Controls.Add(this.btnGTNGuess);
            this.panGTN.Controls.Add(this.gbxGTNSettings);
            this.panGTN.Controls.Add(this.nudGTNGuess);
            this.panGTN.Controls.Add(this.lblGTNEnterGuess);
            this.panGTN.Controls.Add(this.lblGTNTitle);
            this.panGTN.Location = new System.Drawing.Point(164, 7);
            this.panGTN.Name = "panGTN";
            this.panGTN.Size = new System.Drawing.Size(751, 555);
            this.panGTN.TabIndex = 1;
            this.panGTN.Visible = false;
            // 
            // nudGTNnumGuesses
            // 
            this.nudGTNnumGuesses.Enabled = false;
            this.nudGTNnumGuesses.Location = new System.Drawing.Point(38, 306);
            this.nudGTNnumGuesses.Name = "nudGTNnumGuesses";
            this.nudGTNnumGuesses.Size = new System.Drawing.Size(120, 26);
            this.nudGTNnumGuesses.TabIndex = 7;
            // 
            // nudGTNActualNumber
            // 
            this.nudGTNActualNumber.Location = new System.Drawing.Point(38, 273);
            this.nudGTNActualNumber.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudGTNActualNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudGTNActualNumber.Name = "nudGTNActualNumber";
            this.nudGTNActualNumber.Size = new System.Drawing.Size(120, 26);
            this.nudGTNActualNumber.TabIndex = 6;
            this.nudGTNActualNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblGTNOutput
            // 
            this.lblGTNOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGTNOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGTNOutput.Location = new System.Drawing.Point(16, 396);
            this.lblGTNOutput.Name = "lblGTNOutput";
            this.lblGTNOutput.Size = new System.Drawing.Size(717, 142);
            this.lblGTNOutput.TabIndex = 5;
            // 
            // btnGTNGuess
            // 
            this.btnGTNGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGTNGuess.Location = new System.Drawing.Point(231, 273);
            this.btnGTNGuess.Name = "btnGTNGuess";
            this.btnGTNGuess.Size = new System.Drawing.Size(236, 110);
            this.btnGTNGuess.TabIndex = 4;
            this.btnGTNGuess.Text = "&Guess";
            this.btnGTNGuess.UseVisualStyleBackColor = true;
            this.btnGTNGuess.Click += new System.EventHandler(this.btnGTNGuess_Click);
            // 
            // gbxGTNSettings
            // 
            this.gbxGTNSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxGTNSettings.Controls.Add(this.cboGTNSettingDifficulty);
            this.gbxGTNSettings.Controls.Add(this.lblGTNGuessMaximum);
            this.gbxGTNSettings.Controls.Add(this.label4);
            this.gbxGTNSettings.Controls.Add(this.label3);
            this.gbxGTNSettings.Controls.Add(this.label2);
            this.gbxGTNSettings.Controls.Add(this.lblGTNSettingsDifficulty);
            this.gbxGTNSettings.Location = new System.Drawing.Point(20, 64);
            this.gbxGTNSettings.Name = "gbxGTNSettings";
            this.gbxGTNSettings.Size = new System.Drawing.Size(703, 100);
            this.gbxGTNSettings.TabIndex = 3;
            this.gbxGTNSettings.TabStop = false;
            this.gbxGTNSettings.Text = "Settings";
            // 
            // cboGTNSettingDifficulty
            // 
            this.cboGTNSettingDifficulty.FormattingEnabled = true;
            this.cboGTNSettingDifficulty.Items.AddRange(new object[] {
            "Easy",
            "Medium",
            "Hard"});
            this.cboGTNSettingDifficulty.Location = new System.Drawing.Point(118, 26);
            this.cboGTNSettingDifficulty.Name = "cboGTNSettingDifficulty";
            this.cboGTNSettingDifficulty.Size = new System.Drawing.Size(121, 28);
            this.cboGTNSettingDifficulty.TabIndex = 5;
            this.cboGTNSettingDifficulty.SelectedIndexChanged += new System.EventHandler(this.cboGTNSettingDifficulty_SelectedIndexChanged);
            // 
            // lblGTNGuessMaximum
            // 
            this.lblGTNGuessMaximum.AutoSize = true;
            this.lblGTNGuessMaximum.Location = new System.Drawing.Point(442, 69);
            this.lblGTNGuessMaximum.Name = "lblGTNGuessMaximum";
            this.lblGTNGuessMaximum.Size = new System.Drawing.Size(27, 20);
            this.lblGTNGuessMaximum.TabIndex = 4;
            this.lblGTNGuessMaximum.Text = "10";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(371, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Maximum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(442, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(371, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Minimum";
            // 
            // lblGTNSettingsDifficulty
            // 
            this.lblGTNSettingsDifficulty.AutoSize = true;
            this.lblGTNSettingsDifficulty.Location = new System.Drawing.Point(24, 32);
            this.lblGTNSettingsDifficulty.Name = "lblGTNSettingsDifficulty";
            this.lblGTNSettingsDifficulty.Size = new System.Drawing.Size(69, 20);
            this.lblGTNSettingsDifficulty.TabIndex = 0;
            this.lblGTNSettingsDifficulty.Text = "Difficulty";
            // 
            // nudGTNGuess
            // 
            this.nudGTNGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudGTNGuess.Location = new System.Drawing.Point(265, 186);
            this.nudGTNGuess.Name = "nudGTNGuess";
            this.nudGTNGuess.Size = new System.Drawing.Size(157, 62);
            this.nudGTNGuess.TabIndex = 2;
            // 
            // lblGTNEnterGuess
            // 
            this.lblGTNEnterGuess.AutoSize = true;
            this.lblGTNEnterGuess.Location = new System.Drawing.Point(134, 205);
            this.lblGTNEnterGuess.Name = "lblGTNEnterGuess";
            this.lblGTNEnterGuess.Size = new System.Drawing.Size(112, 20);
            this.lblGTNEnterGuess.TabIndex = 1;
            this.lblGTNEnterGuess.Text = "Enter a Guess";
            // 
            // lblGTNTitle
            // 
            this.lblGTNTitle.AutoSize = true;
            this.lblGTNTitle.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGTNTitle.Location = new System.Drawing.Point(12, 13);
            this.lblGTNTitle.Name = "lblGTNTitle";
            this.lblGTNTitle.Size = new System.Drawing.Size(315, 45);
            this.lblGTNTitle.TabIndex = 0;
            this.lblGTNTitle.Text = "Guess The Number";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(807, 568);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(108, 37);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnGTNPlayAgain
            // 
            this.btnGTNPlayAgain.Location = new System.Drawing.Point(507, 306);
            this.btnGTNPlayAgain.Name = "btnGTNPlayAgain";
            this.btnGTNPlayAgain.Size = new System.Drawing.Size(155, 49);
            this.btnGTNPlayAgain.TabIndex = 8;
            this.btnGTNPlayAgain.Text = "Play Again";
            this.btnGTNPlayAgain.UseVisualStyleBackColor = true;
            this.btnGTNPlayAgain.Visible = false;
            this.btnGTNPlayAgain.Click += new System.EventHandler(this.btnGTNPlayAgain_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 617);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panGTN);
            this.Controls.Add(this.panMenu);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Little Games";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panMenu.ResumeLayout(false);
            this.panGTN.ResumeLayout(false);
            this.panGTN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGTNnumGuesses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGTNActualNumber)).EndInit();
            this.gbxGTNSettings.ResumeLayout(false);
            this.gbxGTNSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGTNGuess)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panMenu;
        private System.Windows.Forms.Label lblMenuTitle;
        private System.Windows.Forms.Button btnIceCream;
        private System.Windows.Forms.Button btnGTN;
        private System.Windows.Forms.Panel panGTN;
        private System.Windows.Forms.Label lblGTNEnterGuess;
        private System.Windows.Forms.Label lblGTNTitle;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox gbxGTNSettings;
        private System.Windows.Forms.ComboBox cboGTNSettingDifficulty;
        private System.Windows.Forms.Label lblGTNGuessMaximum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblGTNSettingsDifficulty;
        private System.Windows.Forms.NumericUpDown nudGTNGuess;
        private System.Windows.Forms.Label lblGTNOutput;
        private System.Windows.Forms.Button btnGTNGuess;
        private System.Windows.Forms.NumericUpDown nudGTNnumGuesses;
        private System.Windows.Forms.NumericUpDown nudGTNActualNumber;
        private System.Windows.Forms.ToolTip toolTips;
        private System.Windows.Forms.Button btnGTNPlayAgain;
    }
}

