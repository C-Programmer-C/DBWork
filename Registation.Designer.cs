namespace DBWork
{
	partial class Registation
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
			label1 = new Label();
			textBox1 = new TextBox();
			textBox2 = new TextBox();
			button1 = new Button();
			textBox3 = new TextBox();
			pictureBox1 = new PictureBox();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BackColor = Color.FromArgb(103, 186, 128);
			label1.Location = new Point(284, 37);
			label1.Name = "label1";
			label1.Size = new Size(229, 25);
			label1.TabIndex = 0;
			label1.Text = "Регистрация пользователя";
			label1.TextAlign = ContentAlignment.TopCenter;
			// 
			// textBox1
			// 
			textBox1.BackColor = Color.FromArgb(244, 232, 211);
			textBox1.Location = new Point(272, 83);
			textBox1.Name = "textBox1";
			textBox1.PlaceholderText = "Введите логин";
			textBox1.Size = new Size(262, 31);
			textBox1.TabIndex = 1;
			// 
			// textBox2
			// 
			textBox2.BackColor = Color.FromArgb(244, 232, 211);
			textBox2.Location = new Point(272, 133);
			textBox2.Name = "textBox2";
			textBox2.PlaceholderText = "Введите пароль";
			textBox2.Size = new Size(262, 31);
			textBox2.TabIndex = 2;
			// 
			// button1
			// 
			button1.Location = new Point(314, 215);
			button1.Name = "button1";
			button1.Size = new Size(178, 64);
			button1.TabIndex = 3;
			button1.Text = "Зарегистрировать";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// textBox3
			// 
			textBox3.BackColor = Color.FromArgb(244, 232, 211);
			textBox3.Location = new Point(272, 178);
			textBox3.Name = "textBox3";
			textBox3.PlaceholderText = "user или admin";
			textBox3.Size = new Size(262, 31);
			textBox3.TabIndex = 4;
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
			pictureBox1.TabIndex = 7;
			pictureBox1.TabStop = false;
			// 
			// Registation
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(pictureBox1);
			Controls.Add(textBox3);
			Controls.Add(button1);
			Controls.Add(textBox2);
			Controls.Add(textBox1);
			Controls.Add(label1);
			Name = "Registation";
			Text = "Registation";
			FormClosed += Registation_FormClosed;
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private TextBox textBox1;
		private TextBox textBox2;
		private Button button1;
		private TextBox textBox3;
		private PictureBox pictureBox1;
	}
}