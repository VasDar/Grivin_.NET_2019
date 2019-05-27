namespace Grivin_Vasiliy_Task14_15
{
	partial class AddUser
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
			this.performanceCounter1 = new System.Diagnostics.PerformanceCounter();
			this.label1 = new System.Windows.Forms.Label();
			this.lbUserFistName = new System.Windows.Forms.Label();
			this.lbUserLastName = new System.Windows.Forms.Label();
			this.lbUserBisthday = new System.Windows.Forms.Label();
			this.tbUserFistName = new System.Windows.Forms.TextBox();
			this.tbUserLastName = new System.Windows.Forms.TextBox();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.lbAwards = new System.Windows.Forms.Label();
			this.ctlAwardsCollection = new System.Windows.Forms.CheckedListBox();
			this.btnOK = new System.Windows.Forms.Button();
			this.btnOFF = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			// 
			// lbUserFistName
			// 
			this.lbUserFistName.AutoSize = true;
			this.lbUserFistName.Location = new System.Drawing.Point(68, 23);
			this.lbUserFistName.Name = "lbUserFistName";
			this.lbUserFistName.Size = new System.Drawing.Size(32, 13);
			this.lbUserFistName.TabIndex = 1;
			this.lbUserFistName.Text = "Имя:";
			// 
			// lbUserLastName
			// 
			this.lbUserLastName.AutoSize = true;
			this.lbUserLastName.Location = new System.Drawing.Point(41, 56);
			this.lbUserLastName.Name = "lbUserLastName";
			this.lbUserLastName.Size = new System.Drawing.Size(59, 13);
			this.lbUserLastName.TabIndex = 2;
			this.lbUserLastName.Text = "Фамилия:";
			// 
			// lbUserBisthday
			// 
			this.lbUserBisthday.AutoSize = true;
			this.lbUserBisthday.Location = new System.Drawing.Point(12, 90);
			this.lbUserBisthday.Name = "lbUserBisthday";
			this.lbUserBisthday.Size = new System.Drawing.Size(89, 13);
			this.lbUserBisthday.TabIndex = 3;
			this.lbUserBisthday.Text = "Дата рождения:";
			// 
			// tbUserFistName
			// 
			this.tbUserFistName.Location = new System.Drawing.Point(115, 16);
			this.tbUserFistName.Name = "tbUserFistName";
			this.tbUserFistName.Size = new System.Drawing.Size(200, 20);
			this.tbUserFistName.TabIndex = 4;
			// 
			// tbUserLastName
			// 
			this.tbUserLastName.Location = new System.Drawing.Point(115, 49);
			this.tbUserLastName.Name = "tbUserLastName";
			this.tbUserLastName.Size = new System.Drawing.Size(200, 20);
			this.tbUserLastName.TabIndex = 5;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(115, 84);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
			this.dateTimePicker1.TabIndex = 6;
			// 
			// lbAwards
			// 
			this.lbAwards.AutoSize = true;
			this.lbAwards.Location = new System.Drawing.Point(44, 119);
			this.lbAwards.Name = "lbAwards";
			this.lbAwards.Size = new System.Drawing.Size(55, 13);
			this.lbAwards.TabIndex = 7;
			this.lbAwards.Text = "Награды:";
			// 
			// ctlAwardsCollection
			// 
			this.ctlAwardsCollection.FormattingEnabled = true;
			this.ctlAwardsCollection.Location = new System.Drawing.Point(115, 119);
			this.ctlAwardsCollection.Name = "ctlAwardsCollection";
			this.ctlAwardsCollection.Size = new System.Drawing.Size(200, 169);
			this.ctlAwardsCollection.TabIndex = 8;
			// 
			// btnOK
			// 
			this.btnOK.Location = new System.Drawing.Point(115, 386);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 9;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click_1);
			// 
			// btnOFF
			// 
			this.btnOFF.Location = new System.Drawing.Point(235, 386);
			this.btnOFF.Name = "btnOFF";
			this.btnOFF.Size = new System.Drawing.Size(75, 23);
			this.btnOFF.TabIndex = 10;
			this.btnOFF.Text = "Отмена";
			this.btnOFF.UseVisualStyleBackColor = true;
			this.btnOFF.Click += new System.EventHandler(this.btnOFF_Click);
			// 
			// AddUser
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(405, 450);
			this.Controls.Add(this.btnOFF);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.ctlAwardsCollection);
			this.Controls.Add(this.lbAwards);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.tbUserLastName);
			this.Controls.Add(this.tbUserFistName);
			this.Controls.Add(this.lbUserBisthday);
			this.Controls.Add(this.lbUserLastName);
			this.Controls.Add(this.lbUserFistName);
			this.Controls.Add(this.label1);
			this.Name = "AddUser";
			this.Text = "Пользователь";
			//((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Diagnostics.PerformanceCounter performanceCounter1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lbUserFistName;
		private System.Windows.Forms.Label lbUserLastName;
		private System.Windows.Forms.Label lbUserBisthday;
		private System.Windows.Forms.TextBox tbUserFistName;
		private System.Windows.Forms.TextBox tbUserLastName;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Label lbAwards;
		private System.Windows.Forms.CheckedListBox ctlAwardsCollection;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnOFF;
	}
}