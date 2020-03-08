namespace ColorSorting
{
    partial class ChangeLanguageForm
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
            this.okButton = new System.Windows.Forms.Button();
            this.ukrRadioButton = new System.Windows.Forms.RadioButton();
            this.engRadioButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(40, 146);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(125, 26);
            this.okButton.TabIndex = 5;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // ukrRadioButton
            // 
            this.ukrRadioButton.AutoSize = true;
            this.ukrRadioButton.Location = new System.Drawing.Point(57, 98);
            this.ukrRadioButton.Name = "ukrRadioButton";
            this.ukrRadioButton.Size = new System.Drawing.Size(89, 21);
            this.ukrRadioButton.TabIndex = 4;
            this.ukrRadioButton.TabStop = true;
            this.ukrRadioButton.Text = "Ukrainian";
            this.ukrRadioButton.UseVisualStyleBackColor = true;
            this.ukrRadioButton.CheckedChanged += new System.EventHandler(this.ukrRadioButton_CheckedChanged);
            // 
            // engRadioButton
            // 
            this.engRadioButton.AutoSize = true;
            this.engRadioButton.Location = new System.Drawing.Point(57, 45);
            this.engRadioButton.Name = "engRadioButton";
            this.engRadioButton.Size = new System.Drawing.Size(75, 21);
            this.engRadioButton.TabIndex = 3;
            this.engRadioButton.TabStop = true;
            this.engRadioButton.Text = "English";
            this.engRadioButton.UseVisualStyleBackColor = true;
            this.engRadioButton.CheckedChanged += new System.EventHandler(this.engRadioButton_CheckedChanged);
            // 
            // ChangeLanguageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(211, 197);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.ukrRadioButton);
            this.Controls.Add(this.engRadioButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangeLanguageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ChangeLanguage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.RadioButton ukrRadioButton;
        private System.Windows.Forms.RadioButton engRadioButton;
    }
}