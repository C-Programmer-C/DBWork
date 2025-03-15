namespace DBWork
{
    partial class AuthorizationForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorizationForm));
			textBox1 = new TextBox();
			label1 = new Label();
			textBox2 = new TextBox();
			button1 = new Button();
			button2 = new Button();
			button3 = new Button();
			pictureBox1 = new PictureBox();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// textBox1
			// 
			textBox1.BackColor = Color.FromArgb(103, 186, 128);
			textBox1.Font = new Font("Sitka Small", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
			textBox1.ForeColor = Color.Black;
			textBox1.Location = new Point(235, 87);
			textBox1.Name = "textBox1";
			textBox1.PlaceholderText = "Введите логин";
			textBox1.Size = new Size(306, 53);
			textBox1.TabIndex = 0;
			textBox1.TextAlign = HorizontalAlignment.Center;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BackColor = Color.FromArgb(103, 186, 128);
			label1.BorderStyle = BorderStyle.FixedSingle;
			label1.Font = new Font("Snap ITC", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label1.ForeColor = Color.Black;
			label1.Location = new Point(184, 9);
			label1.Name = "label1";
			label1.Size = new Size(409, 75);
			label1.TabIndex = 1;
			label1.Text = "Авторизация";
			// 
			// textBox2
			// 
			textBox2.BackColor = Color.FromArgb(103, 186, 128);
			textBox2.Font = new Font("Sitka Small", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
			textBox2.ForeColor = Color.Black;
			textBox2.Location = new Point(184, 146);
			textBox2.Name = "textBox2";
			textBox2.PlaceholderText = "Введите пароль";
			textBox2.Size = new Size(390, 53);
			textBox2.TabIndex = 2;
			textBox2.TextAlign = HorizontalAlignment.Center;
			// 
			// button1
			// 
			button1.BackColor = Color.FromArgb(103, 186, 128);
			button1.ForeColor = Color.FloralWhite;
			button1.Location = new Point(293, 209);
			button1.Name = "button1";
			button1.Size = new Size(192, 56);
			button1.TabIndex = 3;
			button1.Text = "Войти";
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;
			// 
			// button2
			// 
			button2.Location = new Point(637, 209);
			button2.Name = "button2";
			button2.Size = new Size(140, 74);
			button2.TabIndex = 4;
			button2.Text = "Тест";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// button3
			// 
			button3.Location = new Point(12, 173);
			button3.Name = "button3";
			button3.Size = new Size(144, 98);
			button3.TabIndex = 5;
			button3.Text = "Тест Регистрация";
			button3.UseVisualStyleBackColor = true;
			button3.Click += button3_Click;
			// 
			// pictureBox1
			// 
			pictureBox1.BackgroundImageLayout = ImageLayout.Center;
			pictureBox1.BorderStyle = BorderStyle.Fixed3D;
			pictureBox1.Image = Properties.Resources.Ремонт_к;
			pictureBox1.Location = new Point(12, 12);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(141, 133);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 6;
			pictureBox1.TabStop = false;
			// 
			// AuthorizationForm
			// 
			AutoScaleMode = AutoScaleMode.None;
			AutoScroll = true;
			AutoValidate = AutoValidate.Disable;
			BackColor = Color.White;
			ClientSize = new Size(800, 321);
			Controls.Add(pictureBox1);
			Controls.Add(button3);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(textBox2);
			Controls.Add(label1);
			Controls.Add(textBox1);
			Font = new Font("Sitka Small", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
			FormBorderStyle = FormBorderStyle.Fixed3D;
			Icon = (Icon)resources.GetObject("$this.Icon");
			Margin = new Padding(5, 6, 5, 6);
			Name = "AuthorizationForm";
			ShowIcon = false;
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Авторизация";
			TopMost = true;
			TransparencyKey = Color.Red;
			WindowState = FormWindowState.Minimized;
			FormClosed += AuthorizationForm_FormClosed;
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox textBox1;
		private Label label1;
		private TextBox textBox2;
		private Button button1;
		private Button button2;
		private Button button3;
		private PictureBox pictureBox1;
	}
}
