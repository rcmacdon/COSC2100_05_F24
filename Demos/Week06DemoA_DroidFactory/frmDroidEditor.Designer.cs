namespace Week06DemoA_DroidFactory
{
    partial class frmDroidEditor
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
            this.grpCreator = new System.Windows.Forms.GroupBox();
            this.btnResetDroid = new System.Windows.Forms.Button();
            this.btnSaveDroid = new System.Windows.Forms.Button();
            this.btnSecondaryColour = new System.Windows.Forms.Button();
            this.lblSecondaryColour = new System.Windows.Forms.Label();
            this.lblSecondColourLabel = new System.Windows.Forms.Label();
            this.btnSetPrimaryColour = new System.Windows.Forms.Button();
            this.lblPrimaryColour = new System.Windows.Forms.Label();
            this.lblColour1Label = new System.Windows.Forms.Label();
            this.txtOwner = new System.Windows.Forms.TextBox();
            this.lblOwner = new System.Windows.Forms.Label();
            this.chkInService = new System.Windows.Forms.CheckBox();
            this.txtDesignation = new System.Windows.Forms.TextBox();
            this.lblDesignationLabel = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDroidDesignation = new System.Windows.Forms.Label();
            this.grpCreator.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCreator
            // 
            this.grpCreator.BackColor = System.Drawing.Color.Transparent;
            this.grpCreator.Controls.Add(this.btnCancel);
            this.grpCreator.Controls.Add(this.btnResetDroid);
            this.grpCreator.Controls.Add(this.btnSaveDroid);
            this.grpCreator.Controls.Add(this.btnSecondaryColour);
            this.grpCreator.Controls.Add(this.lblSecondaryColour);
            this.grpCreator.Controls.Add(this.lblSecondColourLabel);
            this.grpCreator.Controls.Add(this.btnSetPrimaryColour);
            this.grpCreator.Controls.Add(this.lblPrimaryColour);
            this.grpCreator.Controls.Add(this.lblColour1Label);
            this.grpCreator.Controls.Add(this.txtOwner);
            this.grpCreator.Controls.Add(this.lblOwner);
            this.grpCreator.Controls.Add(this.chkInService);
            this.grpCreator.Controls.Add(this.txtDesignation);
            this.grpCreator.Controls.Add(this.lblDesignationLabel);
            this.grpCreator.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.grpCreator.Location = new System.Drawing.Point(13, 51);
            this.grpCreator.Margin = new System.Windows.Forms.Padding(4);
            this.grpCreator.Name = "grpCreator";
            this.grpCreator.Padding = new System.Windows.Forms.Padding(4);
            this.grpCreator.Size = new System.Drawing.Size(595, 353);
            this.grpCreator.TabIndex = 6;
            this.grpCreator.TabStop = false;
            this.grpCreator.Text = "Droid Creator";
            // 
            // btnResetDroid
            // 
            this.btnResetDroid.Location = new System.Drawing.Point(22, 269);
            this.btnResetDroid.Margin = new System.Windows.Forms.Padding(4);
            this.btnResetDroid.Name = "btnResetDroid";
            this.btnResetDroid.Size = new System.Drawing.Size(96, 51);
            this.btnResetDroid.TabIndex = 12;
            this.btnResetDroid.Text = "&Reset";
            this.btnResetDroid.UseVisualStyleBackColor = true;
            this.btnResetDroid.Click += new System.EventHandler(this.btnResetDroid_Click);
            // 
            // btnSaveDroid
            // 
            this.btnSaveDroid.Location = new System.Drawing.Point(427, 269);
            this.btnSaveDroid.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveDroid.Name = "btnSaveDroid";
            this.btnSaveDroid.Size = new System.Drawing.Size(136, 52);
            this.btnSaveDroid.TabIndex = 11;
            this.btnSaveDroid.Text = "&Save Droid";
            this.btnSaveDroid.UseVisualStyleBackColor = true;
            this.btnSaveDroid.Click += new System.EventHandler(this.btnSaveDroid_Click);
            // 
            // btnSecondaryColour
            // 
            this.btnSecondaryColour.Location = new System.Drawing.Point(472, 185);
            this.btnSecondaryColour.Margin = new System.Windows.Forms.Padding(4);
            this.btnSecondaryColour.Name = "btnSecondaryColour";
            this.btnSecondaryColour.Size = new System.Drawing.Size(58, 51);
            this.btnSecondaryColour.TabIndex = 10;
            this.btnSecondaryColour.Text = "Set";
            this.btnSecondaryColour.UseVisualStyleBackColor = true;
            this.btnSecondaryColour.Click += new System.EventHandler(this.btnSecondaryColour_Click);
            // 
            // lblSecondaryColour
            // 
            this.lblSecondaryColour.BackColor = System.Drawing.Color.Gray;
            this.lblSecondaryColour.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSecondaryColour.Location = new System.Drawing.Point(408, 185);
            this.lblSecondaryColour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSecondaryColour.Name = "lblSecondaryColour";
            this.lblSecondaryColour.Size = new System.Drawing.Size(55, 51);
            this.lblSecondaryColour.TabIndex = 9;
            // 
            // lblSecondColourLabel
            // 
            this.lblSecondColourLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSecondColourLabel.Location = new System.Drawing.Point(300, 185);
            this.lblSecondColourLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSecondColourLabel.Name = "lblSecondColourLabel";
            this.lblSecondColourLabel.Size = new System.Drawing.Size(113, 69);
            this.lblSecondColourLabel.TabIndex = 8;
            this.lblSecondColourLabel.Text = "Secondary Colour";
            // 
            // btnSetPrimaryColour
            // 
            this.btnSetPrimaryColour.Location = new System.Drawing.Point(177, 185);
            this.btnSetPrimaryColour.Margin = new System.Windows.Forms.Padding(4);
            this.btnSetPrimaryColour.Name = "btnSetPrimaryColour";
            this.btnSetPrimaryColour.Size = new System.Drawing.Size(58, 51);
            this.btnSetPrimaryColour.TabIndex = 7;
            this.btnSetPrimaryColour.Text = "Set";
            this.btnSetPrimaryColour.UseVisualStyleBackColor = true;
            this.btnSetPrimaryColour.Click += new System.EventHandler(this.btnSetPrimaryColour_Click);
            // 
            // lblPrimaryColour
            // 
            this.lblPrimaryColour.BackColor = System.Drawing.Color.Gray;
            this.lblPrimaryColour.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPrimaryColour.Location = new System.Drawing.Point(113, 185);
            this.lblPrimaryColour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrimaryColour.Name = "lblPrimaryColour";
            this.lblPrimaryColour.Size = new System.Drawing.Size(55, 51);
            this.lblPrimaryColour.TabIndex = 6;
            // 
            // lblColour1Label
            // 
            this.lblColour1Label.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblColour1Label.Location = new System.Drawing.Point(22, 185);
            this.lblColour1Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblColour1Label.Name = "lblColour1Label";
            this.lblColour1Label.Size = new System.Drawing.Size(98, 69);
            this.lblColour1Label.TabIndex = 5;
            this.lblColour1Label.Text = "Primary Colour";
            // 
            // txtOwner
            // 
            this.txtOwner.Location = new System.Drawing.Point(162, 109);
            this.txtOwner.Margin = new System.Windows.Forms.Padding(4);
            this.txtOwner.Name = "txtOwner";
            this.txtOwner.Size = new System.Drawing.Size(399, 37);
            this.txtOwner.TabIndex = 4;
            // 
            // lblOwner
            // 
            this.lblOwner.AutoSize = true;
            this.lblOwner.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblOwner.Location = new System.Drawing.Point(22, 115);
            this.lblOwner.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOwner.Name = "lblOwner";
            this.lblOwner.Size = new System.Drawing.Size(64, 25);
            this.lblOwner.TabIndex = 3;
            this.lblOwner.Text = "Owner";
            // 
            // chkInService
            // 
            this.chkInService.AutoSize = true;
            this.chkInService.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkInService.Location = new System.Drawing.Point(401, 61);
            this.chkInService.Margin = new System.Windows.Forms.Padding(4);
            this.chkInService.Name = "chkInService";
            this.chkInService.Size = new System.Drawing.Size(113, 29);
            this.chkInService.TabIndex = 2;
            this.chkInService.Text = "In Service";
            this.chkInService.UseVisualStyleBackColor = true;
            // 
            // txtDesignation
            // 
            this.txtDesignation.Location = new System.Drawing.Point(162, 55);
            this.txtDesignation.Margin = new System.Windows.Forms.Padding(4);
            this.txtDesignation.Name = "txtDesignation";
            this.txtDesignation.Size = new System.Drawing.Size(207, 37);
            this.txtDesignation.TabIndex = 1;
            // 
            // lblDesignationLabel
            // 
            this.lblDesignationLabel.AutoSize = true;
            this.lblDesignationLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDesignationLabel.Location = new System.Drawing.Point(22, 60);
            this.lblDesignationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDesignationLabel.Name = "lblDesignationLabel";
            this.lblDesignationLabel.Size = new System.Drawing.Size(107, 25);
            this.lblDesignationLabel.TabIndex = 0;
            this.lblDesignationLabel.Text = "Designation";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(231, 269);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(96, 51);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Droid";
            // 
            // lblDroidDesignation
            // 
            this.lblDroidDesignation.AutoSize = true;
            this.lblDroidDesignation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDroidDesignation.Location = new System.Drawing.Point(152, 9);
            this.lblDroidDesignation.Name = "lblDroidDesignation";
            this.lblDroidDesignation.Size = new System.Drawing.Size(21, 29);
            this.lblDroidDesignation.TabIndex = 8;
            this.lblDroidDesignation.Text = "-";
            // 
            // frmDroidEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 415);
            this.Controls.Add(this.lblDroidDesignation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpCreator);
            this.Name = "frmDroidEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Droid Editor";
            this.grpCreator.ResumeLayout(false);
            this.grpCreator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCreator;
        private System.Windows.Forms.Button btnResetDroid;
        private System.Windows.Forms.Button btnSaveDroid;
        private System.Windows.Forms.Button btnSecondaryColour;
        private System.Windows.Forms.Label lblSecondaryColour;
        private System.Windows.Forms.Label lblSecondColourLabel;
        private System.Windows.Forms.Button btnSetPrimaryColour;
        private System.Windows.Forms.Label lblPrimaryColour;
        private System.Windows.Forms.Label lblColour1Label;
        private System.Windows.Forms.TextBox txtOwner;
        private System.Windows.Forms.Label lblOwner;
        private System.Windows.Forms.CheckBox chkInService;
        private System.Windows.Forms.TextBox txtDesignation;
        private System.Windows.Forms.Label lblDesignationLabel;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDroidDesignation;
    }
}