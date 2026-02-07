namespace test
{
    partial class Avtorizacia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Avtorizacia));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.zagolovokLabel = new System.Windows.Forms.Label();
            this.voityButton = new System.Windows.Forms.Button();
            this.tovaryButton = new System.Windows.Forms.Button();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.ParolTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // zagolovokLabel
            // 
            this.zagolovokLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.zagolovokLabel.AutoSize = true;
            this.zagolovokLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.zagolovokLabel.Location = new System.Drawing.Point(327, 20);
            this.zagolovokLabel.Name = "zagolovokLabel";
            this.zagolovokLabel.Size = new System.Drawing.Size(98, 19);
            this.zagolovokLabel.TabIndex = 1;
            this.zagolovokLabel.Text = "Авторизация";
            this.zagolovokLabel.Click += new System.EventHandler(this.zagolovokLabel_Click);
            // 
            // voityButton
            // 
            this.voityButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.voityButton.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.voityButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.voityButton.Location = new System.Drawing.Point(583, 380);
            this.voityButton.Name = "voityButton";
            this.voityButton.Size = new System.Drawing.Size(193, 61);
            this.voityButton.TabIndex = 2;
            this.voityButton.Text = "Войти";
            this.voityButton.UseVisualStyleBackColor = false;
            this.voityButton.Click += new System.EventHandler(this.voityButton_Click);
            // 
            // tovaryButton
            // 
            this.tovaryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tovaryButton.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.tovaryButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tovaryButton.Location = new System.Drawing.Point(12, 373);
            this.tovaryButton.Name = "tovaryButton";
            this.tovaryButton.Size = new System.Drawing.Size(193, 61);
            this.tovaryButton.TabIndex = 3;
            this.tovaryButton.Text = "Товары";
            this.tovaryButton.UseVisualStyleBackColor = false;
            // 
            // loginTextBox
            // 
            this.loginTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginTextBox.Location = new System.Drawing.Point(292, 142);
            this.loginTextBox.MaximumSize = new System.Drawing.Size(178, 41);
            this.loginTextBox.Multiline = true;
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(178, 38);
            this.loginTextBox.TabIndex = 4;
            this.loginTextBox.TextChanged += new System.EventHandler(this.loginTextBox_TextChanged);
            // 
            // ParolTextBox
            // 
            this.ParolTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ParolTextBox.Location = new System.Drawing.Point(292, 214);
            this.ParolTextBox.MaximumSize = new System.Drawing.Size(178, 41);
            this.ParolTextBox.Multiline = true;
            this.ParolTextBox.Name = "ParolTextBox";
            this.ParolTextBox.Size = new System.Drawing.Size(178, 41);
            this.ParolTextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(234, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Логин";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(234, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Пароль";
            // 
            // Avtorizacia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(788, 453);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ParolTextBox);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.tovaryButton);
            this.Controls.Add(this.voityButton);
            this.Controls.Add(this.zagolovokLabel);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Avtorizacia";
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.Avtorizacia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label zagolovokLabel;
        private System.Windows.Forms.Button voityButton;
        private System.Windows.Forms.Button tovaryButton;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox ParolTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}