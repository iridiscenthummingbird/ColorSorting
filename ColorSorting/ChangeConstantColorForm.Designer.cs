namespace ColorSorting
{
    partial class ChangeConstantColorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeConstantColorForm));
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.okButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(64, 314);
            this.trackBar1.Maximum = 255;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(204, 56);
            this.trackBar1.TabIndex = 13;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(27, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(90, 90);
            this.panel1.TabIndex = 12;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(102, 376);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(125, 30);
            this.okButton.TabIndex = 14;
            this.okButton.Text = "OК";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(123, 108);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(90, 90);
            this.panel2.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(219, 204);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(90, 90);
            this.panel3.TabIndex = 13;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(123, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(90, 90);
            this.panel4.TabIndex = 14;
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(219, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(90, 90);
            this.panel5.TabIndex = 15;
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(27, 108);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(90, 90);
            this.panel6.TabIndex = 15;
            // 
            // panel7
            // 
            this.panel7.Location = new System.Drawing.Point(219, 108);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(90, 90);
            this.panel7.TabIndex = 15;
            // 
            // panel8
            // 
            this.panel8.Location = new System.Drawing.Point(123, 204);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(90, 90);
            this.panel8.TabIndex = 15;
            // 
            // panel9
            // 
            this.panel9.Location = new System.Drawing.Point(27, 204);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(90, 90);
            this.panel9.TabIndex = 15;
            // 
            // ChangeConstantColorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(349, 461);
            this.ControlBox = false;
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangeConstantColorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ChangeConstantColorForm";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
    }
}