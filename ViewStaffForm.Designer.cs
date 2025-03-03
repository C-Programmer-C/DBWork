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
			SuspendLayout();
			// 
			// customControl1
			// 
			customControl1.BackColor = SystemColors.Window;
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
			// ViewStaffForm
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1137, 1050);
			Controls.Add(SearchTextBox);
			Controls.Add(customControl1);
			FormBorderStyle = FormBorderStyle.FixedDialog;
			Margin = new Padding(4, 5, 4, 5);
			Name = "ViewStaffForm";
			Text = "Сотрудники";
			FormClosed += ViewStaffForm_FormClosed;
			Load += ViewStaffForm_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private CustomControl customControl1;
		private TextBox SearchTextBox;
	}
}