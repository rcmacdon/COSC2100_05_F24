namespace Week01Demo
{
    partial class frmMainForm
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
            this.btnHelloWorld = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.rtbEditor = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnHelloWorld
            // 
            this.btnHelloWorld.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelloWorld.ForeColor = System.Drawing.Color.Maroon;
            this.btnHelloWorld.Location = new System.Drawing.Point(12, 12);
            this.btnHelloWorld.Name = "btnHelloWorld";
            this.btnHelloWorld.Size = new System.Drawing.Size(218, 70);
            this.btnHelloWorld.TabIndex = 0;
            this.btnHelloWorld.Text = "Hello World";
            this.btnHelloWorld.UseVisualStyleBackColor = true;
            this.btnHelloWorld.Click += new System.EventHandler(this.btnHelloWorld_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(140, 267);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(132, 50);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(278, 267);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(132, 50);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // rtbEditor
            // 
            this.rtbEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbEditor.Location = new System.Drawing.Point(12, 88);
            this.rtbEditor.Name = "rtbEditor";
            this.rtbEditor.Size = new System.Drawing.Size(398, 173);
            this.rtbEditor.TabIndex = 3;
            this.rtbEditor.Text = "";
            // 
            // frmMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(422, 329);
            this.Controls.Add(this.rtbEditor);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnHelloWorld);
            this.MinimumSize = new System.Drawing.Size(444, 385);
            this.Name = "frmMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clint\'s First Application";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHelloWorld;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RichTextBox rtbEditor;
    }
}

