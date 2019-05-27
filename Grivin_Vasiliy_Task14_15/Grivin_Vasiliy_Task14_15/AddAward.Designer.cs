namespace Grivin_Vasiliy_Task14_15
{
	partial class AddAward
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
			this.lbTitle = new System.Windows.Forms.Label();
			this.lbDiscription = new System.Windows.Forms.Label();
			this.tbDiscription = new System.Windows.Forms.TextBox();
			this.tbTitle = new System.Windows.Forms.TextBox();
			this.btnOKAward = new System.Windows.Forms.Button();
			this.btnOFFAward = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lbTitle
			// 
			this.lbTitle.AutoSize = true;
			this.lbTitle.Location = new System.Drawing.Point(35, 35);
			this.lbTitle.Name = "lbTitle";
			this.lbTitle.Size = new System.Drawing.Size(60, 13);
			this.lbTitle.TabIndex = 0;
			this.lbTitle.Text = "Название:";
			// 
			// lbDiscription
			// 
			this.lbDiscription.AutoSize = true;
			this.lbDiscription.Location = new System.Drawing.Point(35, 94);
			this.lbDiscription.Name = "lbDiscription";
			this.lbDiscription.Size = new System.Drawing.Size(60, 13);
			this.lbDiscription.TabIndex = 1;
			this.lbDiscription.Text = "Описание:";
			// 
			// tbDiscription
			// 
			this.tbDiscription.Location = new System.Drawing.Point(118, 94);
			this.tbDiscription.Name = "tbDiscription";
			this.tbDiscription.Size = new System.Drawing.Size(212, 20);
			this.tbDiscription.TabIndex = 2;
			// 
			// tbTitle
			// 
			this.tbTitle.Location = new System.Drawing.Point(118, 35);
			this.tbTitle.Name = "tbTitle";
			this.tbTitle.Size = new System.Drawing.Size(212, 20);
			this.tbTitle.TabIndex = 3;
			// 
			// btnOKAward
			// 
			this.btnOKAward.Location = new System.Drawing.Point(118, 150);
			this.btnOKAward.Name = "btnOKAward";
			this.btnOKAward.Size = new System.Drawing.Size(75, 23);
			this.btnOKAward.TabIndex = 4;
			this.btnOKAward.Text = "OK";
			this.btnOKAward.UseVisualStyleBackColor = true;
			this.btnOKAward.Click += new System.EventHandler(this.btnOKAward_Click);
			// 
			// btnOFFAward
			// 
			this.btnOFFAward.Location = new System.Drawing.Point(255, 150);
			this.btnOFFAward.Name = "btnOFFAward";
			this.btnOFFAward.Size = new System.Drawing.Size(75, 23);
			this.btnOFFAward.TabIndex = 5;
			this.btnOFFAward.Text = "Отмена";
			this.btnOFFAward.UseVisualStyleBackColor = true;
			// 
			// AddAward
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(419, 185);
			this.Controls.Add(this.btnOFFAward);
			this.Controls.Add(this.btnOKAward);
			this.Controls.Add(this.tbTitle);
			this.Controls.Add(this.tbDiscription);
			this.Controls.Add(this.lbDiscription);
			this.Controls.Add(this.lbTitle);
			this.MaximumSize = new System.Drawing.Size(435, 224);
			this.MinimumSize = new System.Drawing.Size(435, 224);
			this.Name = "AddAward";
			this.Text = "Награда";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbTitle;
		private System.Windows.Forms.Label lbDiscription;
		private System.Windows.Forms.TextBox tbDiscription;
		private System.Windows.Forms.TextBox tbTitle;
		private System.Windows.Forms.Button btnOKAward;
		private System.Windows.Forms.Button btnOFFAward;
	}
}