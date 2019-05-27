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
	public partial class AddAward : Form
	{
		private string title;
		private string description;

		public string Title
		{
			get
			{
				return title;
			}
		}

		public string Description
		{
			get
			{
				return description;
			}
		}

		public AddAward()
		{
			InitializeComponent();
		}

		public AddAward(int currentrow, Storage storage)
		{
			InitializeComponent();

			Award award =  storage.GetAward(currentrow);

			tbTitle.Text = award.Title;
			tbDiscription.Text = award.Description;


		}


		private void btnOKAward_Click(object sender, EventArgs e)
		{
			title = tbTitle.Text.Trim();
			description = tbDiscription.Text.Trim();
			this.Close();
		}
	}
}
