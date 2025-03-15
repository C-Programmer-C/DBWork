using DBWork.Models;
using Microsoft.EntityFrameworkCore;
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
	public partial class CRUDForm : Form
	{
		public Staff staffData;
		public User userData;

		public CRUDForm()
		{
			InitializeComponent();
		}

		public void SaveDataStaff(int idStaff, User user = null)
		{
			//foreach (var item in customControl1.Controls)
			//{
			//	if (item is Label a)
			//	{
			//		var b = a.Name;
			//	}
			//} 

			using (StaffDbContext db = new StaffDbContext())
			{
				staffData = db.Staff.Find(idStaff);
				userData = user;
				richTextBox1.Text = staffData?.Surname;
				richTextBox2.Text = staffData?.Name;
				richTextBox3.Text = staffData?.Patronymic;
				richTextBox4.Text = staffData?.Telephone;
				Department? departmentFound = db.Departments.Find(staffData?.DepartmentId);
				comboBox1.Items.Add(departmentFound.Name);
				var b = db.Departments.Where(i => i.DepartmentId != departmentFound.DepartmentId).Select(i => i.Name).ToList();
				b.ForEach(i => comboBox1.Items.Add(i));
				comboBox1.SelectedIndex = 0;

				//richTextBox6.Text = user.Email;
				//richTextBox7.Text = user.Password;

			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			using (StaffDbContext db = new StaffDbContext())
			{
				db.Update(staffData);
				db.Update(userData);
				staffData.Surname = richTextBox1.Text;
				staffData.Name = richTextBox2.Text;
				staffData.Patronymic = richTextBox3.Text;
				staffData.Telephone = richTextBox4.Text;
				var depString = comboBox1.SelectedItem.ToString();
				var dep = db.Departments.SingleOrDefault(i => i.Name == depString);
				staffData.DepartmentId = dep.DepartmentId;
				db.SaveChanges();
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		private void CRUDForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}
	}
}
