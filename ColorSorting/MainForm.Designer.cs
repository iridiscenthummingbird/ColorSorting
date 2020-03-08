namespace ColorSorting
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не и
        /// 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.shellSortButton = new System.Windows.Forms.Button();
            this.delayCheckbox = new System.Windows.Forms.CheckBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.shakerSortButton = new System.Windows.Forms.Button();
            this.mixButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.writeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeLanguageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeConstantColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GIFCheckBox = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // shellSortButton
            // 
            this.shellSortButton.Enabled = false;
            this.shellSortButton.Location = new System.Drawing.Point(12, 45);
            this.shellSortButton.Name = "shellSortButton";
            this.shellSortButton.Size = new System.Drawing.Size(182, 36);
            this.shellSortButton.TabIndex = 11;
            this.shellSortButton.Text = "Shell Sort";
            this.shellSortButton.UseVisualStyleBackColor = true;
            this.shellSortButton.Click += new System.EventHandler(this.shellSortButton_Click);
            // 
            // delayCheckbox
            // 
            this.delayCheckbox.AutoSize = true;
            this.delayCheckbox.Location = new System.Drawing.Point(215, 60);
            this.delayCheckbox.Name = "delayCheckbox";
            this.delayCheckbox.Size = new System.Drawing.Size(64, 21);
            this.delayCheckbox.TabIndex = 10;
            this.delayCheckbox.Text = "delay";
            this.delayCheckbox.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(353, 74);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(71, 22);
            this.numericUpDown1.TabIndex = 9;
            this.numericUpDown1.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // shakerSortButton
            // 
            this.shakerSortButton.Enabled = false;
            this.shakerSortButton.Location = new System.Drawing.Point(12, 98);
            this.shakerSortButton.Name = "shakerSortButton";
            this.shakerSortButton.Size = new System.Drawing.Size(182, 36);
            this.shakerSortButton.TabIndex = 8;
            this.shakerSortButton.Text = "Shaker Sort";
            this.shakerSortButton.UseVisualStyleBackColor = true;
            this.shakerSortButton.Click += new System.EventHandler(this.shakerSortButton_Click);
            // 
            // mixButton
            // 
            this.mixButton.Location = new System.Drawing.Point(439, 66);
            this.mixButton.Name = "mixButton";
            this.mixButton.Size = new System.Drawing.Size(145, 36);
            this.mixButton.TabIndex = 7;
            this.mixButton.Text = "Mix";
            this.mixButton.UseVisualStyleBackColor = true;
            this.mixButton.Click += new System.EventHandler(this.mixButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.changeLanguageToolStripMenuItem,
            this.changeConstantColorToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(596, 28);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.readToolStripMenuItem,
            this.writeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // readToolStripMenuItem
            // 
            this.readToolStripMenuItem.Name = "readToolStripMenuItem";
            this.readToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
            this.readToolStripMenuItem.Text = "Read";
            this.readToolStripMenuItem.Click += new System.EventHandler(this.readToolStripMenuItem_Click);
            // 
            // writeToolStripMenuItem
            // 
            this.writeToolStripMenuItem.Name = "writeToolStripMenuItem";
            this.writeToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
            this.writeToolStripMenuItem.Text = "Write";
            this.writeToolStripMenuItem.Click += new System.EventHandler(this.writeToolStripMenuItem_Click);
            // 
            // changeLanguageToolStripMenuItem
            // 
            this.changeLanguageToolStripMenuItem.Name = "changeLanguageToolStripMenuItem";
            this.changeLanguageToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.changeLanguageToolStripMenuItem.Text = "Change Language";
            this.changeLanguageToolStripMenuItem.Click += new System.EventHandler(this.changeLanguageToolStripMenuItem_Click);
            // 
            // changeConstantColorToolStripMenuItem
            // 
            this.changeConstantColorToolStripMenuItem.Name = "changeConstantColorToolStripMenuItem";
            this.changeConstantColorToolStripMenuItem.Size = new System.Drawing.Size(173, 24);
            this.changeConstantColorToolStripMenuItem.Text = "Change Constant Color";
            this.changeConstantColorToolStripMenuItem.Click += new System.EventHandler(this.changeConstantColorToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // GIFCheckBox
            // 
            this.GIFCheckBox.AutoSize = true;
            this.GIFCheckBox.Location = new System.Drawing.Point(215, 98);
            this.GIFCheckBox.Name = "GIFCheckBox";
            this.GIFCheckBox.Size = new System.Drawing.Size(89, 21);
            this.GIFCheckBox.TabIndex = 14;
            this.GIFCheckBox.Text = "Write GIF";
            this.GIFCheckBox.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 146);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 600);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 742);
            this.Controls.Add(this.GIFCheckBox);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.shellSortButton);
            this.Controls.Add(this.delayCheckbox);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.shakerSortButton);
            this.Controls.Add(this.mixButton);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ColorSorting";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button shellSortButton;
        private System.Windows.Forms.CheckBox delayCheckbox;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button shakerSortButton;
        private System.Windows.Forms.Button mixButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem changeLanguageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeConstantColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem writeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readToolStripMenuItem;
        private System.Windows.Forms.CheckBox GIFCheckBox;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

