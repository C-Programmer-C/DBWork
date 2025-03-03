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
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(284, 37);
			label1.Name = "label1";
			label1.Size = new Size(229, 25);
			label1.TabIndex = 0;
			label1.Text = "Регистрация пользователя";
			label1.TextAlign = ContentAlignment.TopCenter;
			// 
			// textBox1
			// 
			textBox1.Location = new Point(272, 83);
			textBox1.Name = "textBox1";
			textBox1.PlaceholderText = "Введите логин";
			textBox1.Size = new Size(262, 31);
			textBox1.TabIndex = 1;
			// 
			// textBox2
			// 
			textBox2.Location = new Point(272, 133);
			textBox2.Name = "textBox2";
			textBox2.PlaceholderText = "Введите пароль";
			textBox2.Size = new Size(262, 31);
			textBox2.TabIndex = 2;
			// 
			// button1
			// 
			button1.Location = new Point(317, 215);
			button1.Name = "button1";
			button1.Size = new Size(178, 64);
			button1.TabIndex = 3;
			button1.Text = "Зарегистрировать";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// textBox3
			// 
			textBox3.Location = new Point(272, 178);
			textBox3.Name = "textBox3";
			textBox3.PlaceholderText = "user или admin";
			textBox3.Size = new Size(262, 31);
			textBox3.TabIndex = 4;
			// 
			// Registation
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(textBox3);
			Controls.Add(button1);
			Controls.Add(textBox2);
			Controls.Add(textBox1);
			Controls.Add(label1);
			Name = "Registation";
			Text = "Registation";
			FormClosed += Registation_FormClosed;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private TextBox textBox1;
		private TextBox textBox2;
		private Button button1;
		private TextBox textBox3;
	}
}