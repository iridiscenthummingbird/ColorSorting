namespace ColorSorting
{
    partial class AboutForm
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
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            this.authorsLabel = new System.Windows.Forms.Label();
            this.groupLabel = new System.Windows.Forms.Label();
            this.tretLabel = new System.Windows.Forms.Label();
            this.sydLabel = new System.Windows.Forms.Label();
            this.radLabel = new System.Windows.Forms.Label();
            this.pavLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Image = global::ColorSorting.Properties.Resources.circle;
            this.logoPictureBox.Location = new System.Drawing.Point(12, 12);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(181, 168);
            this.logoPictureBox.TabIndex = 0;
            this.logoPictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(215, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Colors Sort";
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.versionLabel.Location = new System.Drawing.Point(217, 76);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(117, 25);
            this.versionLabel.TabIndex = 2;
            this.versionLabel.Text = "Version: 1.0";
            // 
            // authorsLabel
            // 
            this.authorsLabel.AutoSize = true;
            this.authorsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authorsLabel.Location = new System.Drawing.Point(12, 205);
            this.authorsLabel.Name = "authorsLabel";
            this.authorsLabel.Size = new System.Drawing.Size(113, 32);
            this.authorsLabel.TabIndex = 3;
            this.authorsLabel.Text = "Authors";
            // 
            // groupLabel
            // 
            this.groupLabel.AutoSize = true;
            this.groupLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupLabel.Location = new System.Drawing.Point(14, 261);
            this.groupLabel.Name = "groupLabel";
            this.groupLabel.Size = new System.Drawing.Size(94, 25);
            this.groupLabel.TabIndex = 4;
            this.groupLabel.Text = "CST-228";
            // 
            // tretLabel
            // 
            this.tretLabel.AutoSize = true;
            this.tretLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tretLabel.Location = new System.Drawing.Point(14, 288);
            this.tretLabel.Name = "tretLabel";
            this.tretLabel.Size = new System.Drawing.Size(150, 24);
            this.tretLabel.TabIndex = 5;
            this.tretLabel.Text = "Dmytro Tretiakov";
            // 
            // sydLabel
            // 
            this.sydLabel.AutoSize = true;
            this.sydLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sydLabel.Location = new System.Drawing.Point(14, 322);
            this.sydLabel.Name = "sydLabel";
            this.sydLabel.Size = new System.Drawing.Size(174, 24);
            this.sydLabel.TabIndex = 7;
            this.sydLabel.Text = "Vladyslav Sydorskyi";
            // 
            // radLabel
            // 
            this.radLabel.AutoSize = true;
            this.radLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radLabel.Location = new System.Drawing.Point(14, 356);
            this.radLabel.Name = "radLabel";
            this.radLabel.Size = new System.Drawing.Size(146, 24);
            this.radLabel.TabIndex = 9;
            this.radLabel.Text = "Ivan Radchenko";
            // 
            // pavLabel
            // 
            this.pavLabel.AutoSize = true;
            this.pavLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pavLabel.Location = new System.Drawing.Point(14, 390);
            this.pavLabel.Name = "pavLabel";
            this.pavLabel.Size = new System.Drawing.Size(60, 24);
            this.pavLabel.TabIndex = 11;
            this.pavLabel.Text = "label6";
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 443);
            this.Controls.Add(this.pavLabel);
            this.Controls.Add(this.radLabel);
            this.Controls.Add(this.sydLabel);
            this.Controls.Add(this.tretLabel);
            this.Controls.Add(this.groupLabel);
            this.Controls.Add(this.authorsLabel);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logoPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AboutForm";
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.Label authorsLabel;
        private System.Windows.Forms.Label groupLabel;
        private System.Windows.Forms.Label tretLabel;
        private System.Windows.Forms.Label sydLabel;
        private System.Windows.Forms.Label radLabel;
        private System.Windows.Forms.Label pavLabel;
    }
}