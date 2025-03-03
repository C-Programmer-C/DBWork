namespace DBWork
{
	partial class CustomControl
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

		#region Код, автоматически созданный конструктором компонентов

		/// <summary> 
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			ImageMaterial = new PictureBox();
			labelTypeAndNameProduct = new Label();
			labelArticul = new Label();
			labelMaterialsHead = new Label();
			labelCost = new Label();
			labelMaterialsList = new TextBox();
			((System.ComponentModel.ISupportInitialize)ImageMaterial).BeginInit();
			SuspendLayout();
			// 
			// ImageMaterial
			// 
			ImageMaterial.Location = new Point(14, 29);
			ImageMaterial.Name = "ImageMaterial";
			ImageMaterial.Size = new Size(139, 78);
			ImageMaterial.TabIndex = 0;
			ImageMaterial.TabStop = false;
			// 
			// labelTypeAndNameProduct
			// 
			labelTypeAndNameProduct.AutoSize = true;
			labelTypeAndNameProduct.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
			labelTypeAndNameProduct.Location = new Point(172, 20);
			labelTypeAndNameProduct.Name = "labelTypeAndNameProduct";
			labelTypeAndNameProduct.Size = new Size(297, 21);
			labelTypeAndNameProduct.TabIndex = 1;
			labelTypeAndNameProduct.Text = "Тип продукта | Наименование продукта";
			// 
			// labelArticul
			// 
			labelArticul.AutoSize = true;
			labelArticul.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
			labelArticul.Location = new Point(172, 50);
			labelArticul.Name = "labelArticul";
			labelArticul.Size = new Size(69, 21);
			labelArticul.TabIndex = 2;
			labelArticul.Text = "Артикул";
			// 
			// labelMaterialsHead
			// 
			labelMaterialsHead.AutoSize = true;
			labelMaterialsHead.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
			labelMaterialsHead.Location = new Point(172, 88);
			labelMaterialsHead.Name = "labelMaterialsHead";
			labelMaterialsHead.Size = new Size(92, 20);
			labelMaterialsHead.TabIndex = 3;
			labelMaterialsHead.Text = "Материалы:";
			// 
			// labelCost
			// 
			labelCost.AutoSize = true;
			labelCost.Font = new Font("Segoe UI", 12F);
			labelCost.Location = new Point(604, 20);
			labelCost.Name = "labelCost";
			labelCost.Size = new Size(87, 21);
			labelCost.TabIndex = 4;
			labelCost.Text = "Стоимость";
			// 
			// labelMaterialsList
			// 
			labelMaterialsList.BorderStyle = BorderStyle.None;
			labelMaterialsList.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
			labelMaterialsList.Location = new Point(270, 88);
			labelMaterialsList.Multiline = true;
			labelMaterialsList.Name = "labelMaterialsList";
			labelMaterialsList.Size = new Size(199, 27);
			labelMaterialsList.TabIndex = 5;
			labelMaterialsList.Text = "N:GFGGWGWGWGWGWGааааааааааааааааааа";
			// 
			// CustomControl
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.Window;
			BorderStyle = BorderStyle.FixedSingle;
			Controls.Add(labelMaterialsList);
			Controls.Add(labelCost);
			Controls.Add(labelMaterialsHead);
			Controls.Add(labelArticul);
			Controls.Add(labelTypeAndNameProduct);
			Controls.Add(ImageMaterial);
			Name = "CustomControl";
			Size = new Size(710, 135);
			((System.ComponentModel.ISupportInitialize)ImageMaterial).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private PictureBox ImageMaterial;
		private Label labelTypeAndNameProduct;
		private Label labelArticul;
		private Label labelMaterialsHead;
		private Label labelCost;
		private TextBox labelMaterialsList;
	}
}
