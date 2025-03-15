using DBWork.Models;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBWork
{
	public partial class ViewStaffForm : Form
	{

		private List<List<Staff>> listPanel = new List<List<Staff>>();


		public ViewStaffForm()
		{
			InitializeComponent();

			//List<List<Staff>> list = new List<List<Staff>>();

			//using (StaffDbContext db = new StaffDbContext())
			//{

			//	var staffs = db.Staff.ToList();
			//	int staffsCount = staffs.Count;
			//	for (int i = 0; i < staffsCount / 4 + 5; i++)
			//	{
			//		list.Add([]);
			//	}

			//	for (int i = 0, j = 0, k = 0; i < staffs.Count; i++)
			//	{
			//		if (i > 4)
			//		{

			//		}
			//	}
			//}

		}

		private void ViewStaffForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}

		private void ViewStaffForm_Load(object sender, EventArgs e)
		{
			int staffsCount = 0;
			using (StaffDbContext db = new StaffDbContext())
			{
				staffsCount = db.Staff.Count();
			}
			int blockStaffCount = (staffsCount / 4) + (staffsCount % 4);

			for (int i = 0; i < blockStaffCount; i++)
			{
				listPanel.Add(new List<Staff>());
			}
			int currentPositon = 0;


			using (StaffDbContext db = new StaffDbContext())
			{
				foreach (var panel in listPanel)
				{
					var listStaff = db.Staff.ToList();

					int count = 0;

					for (int i = currentPositon; i < listStaff.Count; i++)
					{
						if (count == 4)
						{
							currentPositon = i;
							break;
						}

						panel.Add(listStaff[i]);

						count++;
					}
				}
			}


			int top = 0;
			foreach (var element in listPanel[0])
			{
				CustomControl control1 = new CustomControl();
				control1.Tag = element;
				control1.BackColor = Color.FromArgb(103, 186, 128);
				control1.Click += Control1_Click;
				var TypeandName = control1.Controls.Find("labelTypeAndNameProduct", true);
				var LabelArticul = control1.Controls.Find("labelArticul", true);
				var LabelMaterialsHead = control1.Controls.Find("labelMaterialsHead", true);
				var labelMaterialsList = control1.Controls.Find("labelMaterialsList", true);
				var labelMaterialsHead = control1.Controls.Find("labelMaterialsHead", true);
				TypeandName[0].Text = element.Name;
				LabelArticul[0].Text = element.Telephone;
				LabelMaterialsHead[0].Text = element.Patronymic;
				labelMaterialsList[0].Text = "Материал 1, Материал 2";
				labelMaterialsHead[0].Text = element.DepartmentId.ToString();
				control1.Left = 50;
				control1.Top += top;
				this.Controls.Add(control1);
				top += 250;
			}
		}

		private void Control1_Click(object? sender, EventArgs e)
		{
			CustomControl cust_control = (CustomControl)sender;
			Staff staff = (Staff)cust_control.Tag;
			CRUDForm crudForm = new CRUDForm();
			crudForm.SaveDataStaff(staff.StaffId);
			crudForm.Show();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Hide();
			AuthorizationForm authorization = new AuthorizationForm();
			authorization.Show();
		}
	}
}
