using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entities;
namespace Grivin_Vasiliy_Task14_15
{
	public partial class AddUser : Form
	{
		
		private string firstName;
		private string lastName;
		private DateTime birthday;
		private List<Award> allAwards;
		private List<Award> usersAwards;
		private CheckBox[] checks;
		private Storage storage;

		
		public string FirstName
		{
			get
			{
				return firstName;
			}
		}

		public string LastName
		{
			get
			{
				return lastName;
			}
		}

		public DateTime Birthday
		{
			get
			{
				return birthday;
			}
		}

		public List<Award> UsersAwards
		{
			get
			{
				return usersAwards;
			}
		}
		


		public AddUser(Storage storage)
		{
			InitializeComponent();

			this.storage = storage;

			allAwards = storage.GetAwards();

			checks = new CheckBox[allAwards.Count];
			int i = 0;

			foreach (Award award in allAwards)
			{
				checks[i] = new CheckBox();
				checks[i].Name = award.Title;
				checks[i].Text = award.Title;
				ctlAwardsCollection.Controls.Add(checks[i]);
				i++;
			}
		}

		public AddUser(int currentrow, Storage storage)
		{
			InitializeComponent();

			this.storage = storage;

			User user = storage.GetUser(currentrow);
			List<Award> usersAwards = user.GetUserAwards();

			tbUserFistName.Text = user.FirstName;
			tbUserLastName.Text = user.LastName;
			dateTimePicker1.Value = user.BirthDay;

			allAwards = storage.GetAwards();

			checks = new CheckBox[allAwards.Count];
			int i = 0;

			foreach (Award award in allAwards)
			{
				checks[i] = new CheckBox();
				checks[i].Name = award.Title;
				checks[i].Text = award.Title;
				ctlAwardsCollection.Controls.Add(checks[i]);

				foreach (Award _award in usersAwards)
				{
					if (checks[i].Text.Equals(_award.Title))
					{
						checks[i].Checked = true;
					}
				}

				i++;
			}

		}

		private void btnOK_Click_1(object sender, EventArgs e)
		{
			firstName = tbUserFistName.Text.Trim();
			lastName = tbUserLastName.Text.Trim();
			birthday = dateTimePicker1.Value.Date;

			usersAwards = new List<Award>();

			for (int i = 0; i < allAwards.Count; i++)
			{
				if (checks[i].Checked)
				{
					foreach (Award award in allAwards)
					{
						if (checks[i].Name.Equals(award.Title))
						{
							usersAwards.Add(award);
						}
					}

				}
			}

			this.Close();

		}

		private void btnOFF_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
