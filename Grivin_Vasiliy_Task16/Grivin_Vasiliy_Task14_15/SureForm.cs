using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grivin_Vasiliy_Task14_15
{
	public partial class SureForm : Form
	{
		public SureForm()
		{
			InitializeComponent();
		}

		private void btnYes_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.OK;
			this.Close();
		
		}

		private void btnNo_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.No;
			this.Close();

		}
	}
}
