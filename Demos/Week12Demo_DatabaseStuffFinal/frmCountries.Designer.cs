namespace Week12Demo_DatabaseStuffFinal
{
    partial class frmCountries
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colCountryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCountryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRegionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCountryID,
            this.colCountryName,
            this.colRegionID});
            this.dataGridView1.Location = new System.Drawing.Point(34, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(697, 365);
            this.dataGridView1.TabIndex = 0;
            // 
            // colCountryID
            // 
            this.colCountryID.DataPropertyName = "CountryID";
            this.colCountryID.HeaderText = "Code";
            this.colCountryID.MinimumWidth = 8;
            this.colCountryID.Name = "colCountryID";
            this.colCountryID.Width = 150;
            // 
            // colCountryName
            // 
            this.colCountryName.DataPropertyName = "CountryName";
            this.colCountryName.HeaderText = "Name";
            this.colCountryName.MinimumWidth = 8;
            this.colCountryName.Name = "colCountryName";
            this.colCountryName.Width = 150;
            // 
            // colRegionID
            // 
            this.colRegionID.DataPropertyName = "RegionID";
            this.colRegionID.HeaderText = "Region";
            this.colRegionID.MinimumWidth = 8;
            this.colRegionID.Name = "colRegionID";
            this.colRegionID.Width = 150;
            // 
            // frmCountries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmCountries";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCountries";
            this.Load += new System.EventHandler(this.frmCountries_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCountryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCountryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRegionID;
    }
}