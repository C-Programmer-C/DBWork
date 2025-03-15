namespace DBWork
{
	partial class ViewStaffForm
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
			customControl1 = new CustomControl();
			SearchTextBox = new TextBox();
			pictureBox1 = new PictureBox();
			button1 = new Button();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// customControl1
			// 
			customControl1.BackColor = Color.White;
			customControl1.BorderStyle = BorderStyle.FixedSingle;
			customControl1.Location = new Point(-27, 5);
			customControl1.Margin = new Padding(4, 5, 4, 5);
			customControl1.Name = "customControl1";
			customControl1.Size = new Size(1520, 336);
			customControl1.TabIndex = 0;
			customControl1.Visible = false;
			// 
			// SearchTextBox
			// 
			SearchTextBox.Location = new Point(975, 1007);
			SearchTextBox.Name = "SearchTextBox";
			SearchTextBox.Size = new Size(150, 31);
			SearchTextBox.TabIndex = 1;
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
			// button1
			// 
			button1.Location = new Point(12, 966);
			button1.Name = "button1";
			button1.Size = new Size(160, 72);
			button1.TabIndex = 8;
			button1.Text = "Назад";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// ViewStaffForm
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1137, 1050);
			Controls.Add(button1);
			Controls.Add(pictureBox1);
			Controls.Add(SearchTextBox);
			Controls.Add(customControl1);
			FormBorderStyle = FormBorderStyle.FixedDialog;
			Margin = new Padding(4, 5, 4, 5);
			Name = "ViewStaffForm";
			Text = "Сотрудники";
			FormClosed += ViewStaffForm_FormClosed;
			Load += ViewStaffForm_Load;
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private CustomControl customControl1;
		private TextBox SearchTextBox;
		private PictureBox pictureBox1;
		private Button button1;
	}
}