namespace Week02DemoA
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.lbxSoccerTeams = new System.Windows.Forms.ListBox();
            this.lblMySoccerTeam = new System.Windows.Forms.Label();
            this.txtMyScoccerTeam = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDeselect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeader.BackColor = System.Drawing.Color.Black;
            this.lblHeader.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(-1, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(621, 48);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "My Soccer Teams";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbxSoccerTeams
            // 
            this.lbxSoccerTeams.FormattingEnabled = true;
            this.lbxSoccerTeams.ItemHeight = 20;
            this.lbxSoccerTeams.Location = new System.Drawing.Point(5, 92);
            this.lbxSoccerTeams.Name = "lbxSoccerTeams";
            this.lbxSoccerTeams.Size = new System.Drawing.Size(256, 204);
            this.lbxSoccerTeams.TabIndex = 3;
            this.lbxSoccerTeams.SelectedIndexChanged += new System.EventHandler(this.lbxSoccerTeams_SelectedIndexChanged);
            // 
            // lblMySoccerTeam
            // 
            this.lblMySoccerTeam.AutoSize = true;
            this.lblMySoccerTeam.Location = new System.Drawing.Point(282, 66);
            this.lblMySoccerTeam.Name = "lblMySoccerTeam";
            this.lblMySoccerTeam.Size = new System.Drawing.Size(92, 20);
            this.lblMySoccerTeam.TabIndex = 2;
            this.lblMySoccerTeam.Text = "Enter Team";
            // 
            // txtMyScoccerTeam
            // 
            this.txtMyScoccerTeam.Location = new System.Drawing.Point(380, 63);
            this.txtMyScoccerTeam.Name = "txtMyScoccerTeam";
            this.txtMyScoccerTeam.Size = new System.Drawing.Size(231, 26);
            this.txtMyScoccerTeam.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(360, 253);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 48);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(486, 253);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(120, 48);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDeselect
            // 
            this.btnDeselect.Location = new System.Drawing.Point(5, 51);
            this.btnDeselect.Name = "btnDeselect";
            this.btnDeselect.Size = new System.Drawing.Size(130, 35);
            this.btnDeselect.TabIndex = 4;
            this.btnDeselect.Text = "&Deselect";
            this.btnDeselect.UseVisualStyleBackColor = true;
            this.btnDeselect.Click += new System.EventHandler(this.btnDeselect_Click);
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(618, 313);
            this.Controls.Add(this.btnDeselect);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtMyScoccerTeam);
            this.Controls.Add(this.lblMySoccerTeam);
            this.Controls.Add(this.lbxSoccerTeams);
            this.Controls.Add(this.lblHeader);
            this.MinimumSize = new System.Drawing.Size(640, 359);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Soccer Teams";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.ListBox lbxSoccerTeams;
        private System.Windows.Forms.Label lblMySoccerTeam;
        private System.Windows.Forms.TextBox txtMyScoccerTeam;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDeselect;
    }
}

