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

namespace Grivin_Vasiliy_Task14_15
{
	public partial class MainForm : Form
	{
		private enum SortMode { Asceding, Desceding };
		Storage storage = new Storage();
		private SortMode usersSortMode = SortMode.Asceding;
		private SortMode awardsSortMode = SortMode.Asceding;
		public MainForm()
		{
			InitializeComponent();
			CreateUserGrid();
			CreateAwardGrid();
		}

		private void ctlClouse_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		//add
		private void ctlAddUser_Click(object sender, EventArgs e)
		{
			AddUser addUser = new AddUser(storage);
			addUser.Text = "Add User";
			if (addUser.ShowDialog() != DialogResult.OK)
			{

				storage.AddUser(addUser.FirstName, addUser.LastName, addUser.Birthday, addUser.UsersAwards);
				displayUsers();

			}
		}
		private void ctlAddAward_Click(object sender, EventArgs e)
		{
			AddAward addAward = new AddAward();
			addAward.Text = "Add Award";
			if (addAward.ShowDialog() != DialogResult.OK)
			{

				storage.AddAward(addAward.Title, addAward.Description);
				displayAwards();

			}
		}
		//update
		private void ctlFixedAward_Click(object sender, EventArgs e)
		{
			if (dgvAwards.CurrentRow != null)
			{

				int currentrow = Int32.Parse(dgvAwards.CurrentRow.Cells[0].Value.ToString());

				AddAward updateAward = new AddAward(currentrow, storage);

				if (updateAward.ShowDialog() != DialogResult.OK)
				{

					storage.UpdateAward(currentrow, updateAward.Title, updateAward.Description);
					displayAwards();

				}
			}
		}
		private void ctlFixedUser_Click(object sender, EventArgs e)
		{
			if (dgvUser.CurrentRow != null)
			{

				int currentrow = Int32.Parse(dgvUser.CurrentRow.Cells[0].Value.ToString());

				AddUser updateUser = new AddUser(currentrow, storage);

				updateUser.Text = "Update User";

				if (updateUser.ShowDialog() != DialogResult.OK)
				{

					storage.UpdateUser(currentrow, updateUser.FirstName, updateUser.LastName, updateUser.Birthday, updateUser.UsersAwards);
					displayUsers();

				}

			}
		}

		//create DGV
		private void displayUsers()
		{
			dgvUser.DataSource = null;
			dgvUser.DataSource = storage.GetUsersList();
		}
		private void displayAwards()
		{
			dgvAwards.DataSource = null;
			dgvAwards.DataSource = storage.GetAwards();
		}
		private void CreateUserGrid()
		{
			dgvUser.AutoGenerateColumns = false;

			dgvUser.Columns.Add(new DataGridViewColumn()
			{
				CellTemplate = new DataGridViewTextBoxCell(),
				DataPropertyName = "ID",
				Visible = false,
			});

			dgvUser.Columns.Add(new DataGridViewColumn()
			{
				CellTemplate = new DataGridViewTextBoxCell(),
				DataPropertyName = "FirstName",
				HeaderText = "Имя",
				Width = 200
			});

			dgvUser.Columns.Add(new DataGridViewColumn()
			{
				CellTemplate = new DataGridViewTextBoxCell(),
				DataPropertyName = "LastName",
				HeaderText = "Фамилия",
				Width = 200
			});

			dgvUser.Columns.Add(new DataGridViewColumn()
			{
				CellTemplate = new DataGridViewTextBoxCell(),
				DataPropertyName = "Birthday",
				HeaderText = "Дата рождения",
				Width = 100,
			});

			dgvUser.Columns.Add(new DataGridViewColumn()
			{
				CellTemplate = new DataGridViewTextBoxCell(),
				DataPropertyName = "Age",
				HeaderText = "Возраст",
				Width = 100,
			});

			dgvUser.Columns.Add(new DataGridViewColumn()
			{
				CellTemplate = new DataGridViewTextBoxCell(),
				DataPropertyName = "StrOfUsersAwawrds",
				HeaderText = "Награды",
				Width = 400,
			});

		}
		private void CreateAwardGrid()
		{
			dgvAwards.AutoGenerateColumns = false;

			dgvAwards.Columns.Add(new DataGridViewColumn()
			{
				CellTemplate = new DataGridViewTextBoxCell(),
				DataPropertyName = "ID",
				Visible = false,
			});

			dgvAwards.Columns.Add(new DataGridViewColumn()
			{
				CellTemplate = new DataGridViewTextBoxCell(),
				DataPropertyName = "Title",
				HeaderText = "Название",
				Width = 200
			});

			dgvAwards.Columns.Add(new DataGridViewColumn()
			{
				CellTemplate = new DataGridViewTextBoxCell(),
				DataPropertyName = "Description",
				HeaderText = "Описание",
				Width = 200
			});

			dgvAwards.DataSource = null;
		}

		//remove
		private void ctlRemoveUser_Click(object sender, EventArgs e)
		{
			if (dgvUser.CurrentRow != null)
			{

				SureForm form = new SureForm();
				int currentrow = Int32.Parse(dgvUser.CurrentRow.Cells[0].Value.ToString());

				if (form.ShowDialog() == DialogResult.OK)
				{
					storage.RemoveUser(currentrow);

					displayUsers();
				}
			}
		}
		private void ctlRemoveAward_Click(object sender, EventArgs e)
		{
			if (dgvAwards.CurrentRow != null)
			{
				SureForm answear = new SureForm();

				int currentrow = Int32.Parse(dgvAwards.CurrentRow.Cells[0].Value.ToString());

				if (answear.ShowDialog() == DialogResult.OK)
				{
					storage.RemoveAward(currentrow);

					displayAwards();
				}
			}

		}


		private void dgvUser_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			if (e.ColumnIndex == 1)
			{
				if (awardsSortMode == SortMode.Asceding)
				{
					dgvUser.DataSource = storage.SortUsersByFirstNameDesc();
					awardsSortMode = SortMode.Desceding;
				}
				else
				{
					dgvUser.DataSource = storage.SortUsersByFirstNameAsc();
					awardsSortMode = SortMode.Asceding;
				}
			}

			if (e.ColumnIndex == 2)
			{
				if (awardsSortMode == SortMode.Asceding)
				{
					dgvUser.DataSource = storage.SortUsersByLastNameDesc();
					awardsSortMode = SortMode.Desceding;
				}
				else
				{
					dgvUser.DataSource = storage.SortUsersByLastNameAsc();
					awardsSortMode = SortMode.Asceding;
				}
			}
			if (e.ColumnIndex == 3)
			{
				if (awardsSortMode == SortMode.Asceding)
				{
					dgvUser.DataSource = storage.SortUsersByBirthdayDesc();
					awardsSortMode = SortMode.Desceding;
				}
				else
				{
					dgvUser.DataSource = storage.SortUsersByBirthdayAsc();
					awardsSortMode = SortMode.Asceding;
				}
			}
			if (e.ColumnIndex == 4)
			{
				if (awardsSortMode == SortMode.Asceding)
				{
					dgvUser.DataSource = storage.SortUsersByAgeDesc();
					awardsSortMode = SortMode.Desceding;
				}
				else
				{
					dgvUser.DataSource = storage.SortUsersByAgeAsc();
					awardsSortMode = SortMode.Asceding;
				}
			}
			if (e.ColumnIndex == 5)
			{
				if (awardsSortMode == SortMode.Asceding)
				{
					dgvUser.DataSource = storage.SortUsersByAwardsDesc();
					awardsSortMode = SortMode.Desceding;
				}
				else
				{
					dgvUser.DataSource = storage.SortUsersByAwardsAsc();
					awardsSortMode = SortMode.Asceding;
				}
			}
		}
		private void dgvAwards_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			if (e.ColumnIndex == 1)
			{
				if (awardsSortMode == SortMode.Asceding)
				{
					dgvAwards.DataSource = storage.SortAwardsByTitleDesc();
					awardsSortMode = SortMode.Desceding;
				}
				else
				{
					dgvAwards.DataSource = storage.SortAwardsByTitleAsc();
					awardsSortMode = SortMode.Asceding;
				}
			}

			if (e.ColumnIndex == 2)
			{
				if (awardsSortMode == SortMode.Asceding)
				{
					dgvAwards.DataSource = storage.SortAwardsByDescriptionDesc();
					awardsSortMode = SortMode.Desceding;
				}
				else
				{
					dgvAwards.DataSource = storage.SortAwardsByDescriptionAsc();
					awardsSortMode = SortMode.Asceding;
				}
			}
		}

	}	
}
