using DBWork.Models;
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
	public partial class Registation : Form
	{
		public Registation()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			using (StaffDbContext db = new StaffDbContext())
			{
				User user = new User
				{
					UserId = 4,
					Email = textBox1.Text,
					Password = textBox2.Text,
					role = textBox3.Text
				};
				db.Users.Add(user);
				db.SaveChanges();
			}
		}

		private void Registation_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}
	}
}
