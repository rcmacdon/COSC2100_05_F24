namespace Week02DemoB
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
            this.mcaMyCalendar = new System.Windows.Forms.MonthCalendar();
            this.dtpMyBirthday = new System.Windows.Forms.DateTimePicker();
            this.cboTheme = new System.Windows.Forms.ComboBox();
            this.cboThemeProg = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // mcaMyCalendar
            // 
            this.mcaMyCalendar.Location = new System.Drawing.Point(18, 18);
            this.mcaMyCalendar.Name = "mcaMyCalendar";
            this.mcaMyCalendar.TabIndex = 0;
            // 
            // dtpMyBirthday
            // 
            this.dtpMyBirthday.Location = new System.Drawing.Point(377, 18);
            this.dtpMyBirthday.Name = "dtpMyBirthday";
            this.dtpMyBirthday.Size = new System.Drawing.Size(200, 26);
            this.dtpMyBirthday.TabIndex = 1;
            // 
            // cboTheme
            // 
            this.cboTheme.FormattingEnabled = true;
            this.cboTheme.Items.AddRange(new object[] {
            "Jan",
            "Feb",
            "Mar",
            "Apr",
            "May",
            "Jun",
            "Jul",
            "Aug",
            "Sep",
            "Oct",
            "Nov",
            "Dec"});
            this.cboTheme.Location = new System.Drawing.Point(378, 51);
            this.cboTheme.Name = "cboTheme";
            this.cboTheme.Size = new System.Drawing.Size(199, 28);
            this.cboTheme.TabIndex = 2;
            // 
            // cboThemeProg
            // 
            this.cboThemeProg.FormattingEnabled = true;
            this.cboThemeProg.Location = new System.Drawing.Point(378, 85);
            this.cboThemeProg.Name = "cboThemeProg";
            this.cboThemeProg.Size = new System.Drawing.Size(199, 28);
            this.cboThemeProg.TabIndex = 3;
            this.cboThemeProg.SelectedIndexChanged += new System.EventHandler(this.cboThemeProg_SelectedIndexChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboThemeProg);
            this.Controls.Add(this.cboTheme);
            this.Controls.Add(this.dtpMyBirthday);
            this.Controls.Add(this.mcaMyCalendar);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Calendar Picker";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar mcaMyCalendar;
        private System.Windows.Forms.DateTimePicker dtpMyBirthday;
        private System.Windows.Forms.ComboBox cboTheme;
        private System.Windows.Forms.ComboBox cboThemeProg;
    }
}

