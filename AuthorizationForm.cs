using DBWork.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace DBWork
{
	public partial class AuthorizationForm : Form
	{
		public AuthorizationForm()
		{
			InitializeComponent();

		}



		private void button1_Click(object sender, EventArgs e)
		{

			string roleUser = String.Empty;
			int staffid;

			using StaffDbContext db = new();
			var foundUser = db.Users.SingleOrDefault(i => i.Email == textBox1.Text && i.Password == textBox2.Text);

			if (foundUser != null)
			{
				staffid = foundUser.UserId;
				roleUser = foundUser.role;
				var crudForm = new CRUDForm();

				this.Visible = false;
				//crudForm.Show();
				//crudForm.SaveDataStaff(staffid, foundUser);
				this.Hide();
				ViewStaffForm viewStaff = new ViewStaffForm();
				viewStaff.Show();


			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			ViewStaffForm viewStaffForm = new ViewStaffForm();
			viewStaffForm.Show();

		}

		private void button3_Click(object sender, EventArgs e)
		{
			Registation registation = new Registation();
			registation.Show();
		}

		private void AuthorizationForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}
	}
}
