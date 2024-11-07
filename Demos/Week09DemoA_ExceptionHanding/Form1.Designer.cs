namespace Week09DemoA_ExceptionHanding
{
    partial class Form1
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
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.cbxOperator = new System.Windows.Forms.ComboBox();
            this.nud1 = new System.Windows.Forms.NumericUpDown();
            this.nud2 = new System.Windows.Forms.NumericUpDown();
            this.btnCalculate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.Red;
            this.lblMessage.Location = new System.Drawing.Point(25, 229);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(659, 212);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "-";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.Location = new System.Drawing.Point(224, 168);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(30, 32);
            this.lblAnswer.TabIndex = 1;
            this.lblAnswer.Text = "0";
            // 
            // cbxOperator
            // 
            this.cbxOperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxOperator.FormattingEnabled = true;
            this.cbxOperator.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/",
            "x^y",
            "sqrt"});
            this.cbxOperator.Location = new System.Drawing.Point(45, 98);
            this.cbxOperator.Name = "cbxOperator";
            this.cbxOperator.Size = new System.Drawing.Size(121, 40);
            this.cbxOperator.TabIndex = 2;
            // 
            // nud1
            // 
            this.nud1.DecimalPlaces = 3;
            this.nud1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud1.Location = new System.Drawing.Point(228, 36);
            this.nud1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud1.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.nud1.Name = "nud1";
            this.nud1.Size = new System.Drawing.Size(150, 39);
            this.nud1.TabIndex = 3;
            // 
            // nud2
            // 
            this.nud2.DecimalPlaces = 3;
            this.nud2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud2.Location = new System.Drawing.Point(228, 98);
            this.nud2.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud2.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.nud2.Name = "nud2";
            this.nud2.Size = new System.Drawing.Size(150, 39);
            this.nud2.TabIndex = 4;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(80, 168);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(86, 46);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "=";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 450);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.nud2);
            this.Controls.Add(this.nud1);
            this.Controls.Add(this.cbxOperator);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.lblMessage);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.ComboBox cbxOperator;
        private System.Windows.Forms.NumericUpDown nud1;
        private System.Windows.Forms.NumericUpDown nud2;
        private System.Windows.Forms.Button btnCalculate;
    }
}

