namespace Grivin_Vasiliy_Task14_15
{
	partial class MainForm
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.tabControl = new System.Windows.Forms.TabControl();
			this.tabPUsers = new System.Windows.Forms.TabPage();
			this.dgvUser = new System.Windows.Forms.DataGridView();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.ctlFile = new System.Windows.Forms.ToolStripMenuItem();
			this.ctlClose = new System.Windows.Forms.ToolStripMenuItem();
			this.изминитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ctlCorrectUser = new System.Windows.Forms.ToolStripMenuItem();
			this.ctlAddUser = new System.Windows.Forms.ToolStripMenuItem();
			this.ctlFixedUser = new System.Windows.Forms.ToolStripMenuItem();
			this.ctlRemoveUser = new System.Windows.Forms.ToolStripMenuItem();
			this.tabPAwards = new System.Windows.Forms.TabPage();
			this.dgvAwards = new System.Windows.Forms.DataGridView();
			this.menuStrip2 = new System.Windows.Forms.MenuStrip();
			this.ctlCorrectAwards = new System.Windows.Forms.ToolStripMenuItem();
			this.ctlAddAward = new System.Windows.Forms.ToolStripMenuItem();
			this.ctlFixedAward = new System.Windows.Forms.ToolStripMenuItem();
			this.ctlRemoveAward = new System.Windows.Forms.ToolStripMenuItem();
			this.tabControl.SuspendLayout();
			this.tabPUsers.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.tabPAwards.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvAwards)).BeginInit();
			this.menuStrip2.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl
			// 
			this.tabControl.Controls.Add(this.tabPUsers);
			this.tabControl.Controls.Add(this.tabPAwards);
			this.tabControl.Location = new System.Drawing.Point(0, 2);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(800, 448);
			this.tabControl.TabIndex = 1;
			// 
			// tabPUsers
			// 
			this.tabPUsers.Controls.Add(this.dgvUser);
			this.tabPUsers.Controls.Add(this.menuStrip1);
			this.tabPUsers.Location = new System.Drawing.Point(4, 22);
			this.tabPUsers.Name = "tabPUsers";
			this.tabPUsers.Padding = new System.Windows.Forms.Padding(3);
			this.tabPUsers.Size = new System.Drawing.Size(792, 422);
			this.tabPUsers.TabIndex = 0;
			this.tabPUsers.Text = "Пользователи";
			this.tabPUsers.UseVisualStyleBackColor = true;
			// 
			// dgvUser
			// 
			this.dgvUser.AllowUserToAddRows = false;
			this.dgvUser.AllowUserToDeleteRows = false;
			this.dgvUser.AllowUserToResizeColumns = false;
			this.dgvUser.AllowUserToResizeRows = false;
			this.dgvUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvUser.Location = new System.Drawing.Point(3, 30);
			this.dgvUser.Name = "dgvUser";
			this.dgvUser.Size = new System.Drawing.Size(789, 392);
			this.dgvUser.TabIndex = 0;
			this.dgvUser.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvUser_ColumnHeaderMouseClick);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctlFile,
            this.изминитьToolStripMenuItem,
            this.ctlCorrectUser});
			this.menuStrip1.Location = new System.Drawing.Point(3, 3);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(786, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// ctlFile
			// 
			this.ctlFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctlClose});
			this.ctlFile.Name = "ctlFile";
			this.ctlFile.Size = new System.Drawing.Size(48, 20);
			this.ctlFile.Text = "Файл";
			// 
			// ctlClose
			// 
			this.ctlClose.Name = "ctlClose";
			this.ctlClose.Size = new System.Drawing.Size(108, 22);
			this.ctlClose.Text = "Выход";
			this.ctlClose.Click += new System.EventHandler(this.ctlClouse_Click);
			// 
			// изминитьToolStripMenuItem
			// 
			this.изминитьToolStripMenuItem.Name = "изминитьToolStripMenuItem";
			this.изминитьToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
			// 
			// ctlCorrectUser
			// 
			this.ctlCorrectUser.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctlAddUser,
            this.ctlFixedUser,
            this.ctlRemoveUser});
			this.ctlCorrectUser.Name = "ctlCorrectUser";
			this.ctlCorrectUser.Size = new System.Drawing.Size(73, 20);
			this.ctlCorrectUser.Text = "Изменить";
			// 
			// ctlAddUser
			// 
			this.ctlAddUser.Name = "ctlAddUser";
			this.ctlAddUser.Size = new System.Drawing.Size(142, 22);
			this.ctlAddUser.Text = "Добавить...";
			this.ctlAddUser.Click += new System.EventHandler(this.ctlAddUser_Click);
			// 
			// ctlFixedUser
			// 
			this.ctlFixedUser.Name = "ctlFixedUser";
			this.ctlFixedUser.Size = new System.Drawing.Size(142, 22);
			this.ctlFixedUser.Text = "Исправить...";
			this.ctlFixedUser.Click += new System.EventHandler(this.ctlFixedUser_Click);
			// 
			// ctlRemoveUser
			// 
			this.ctlRemoveUser.Name = "ctlRemoveUser";
			this.ctlRemoveUser.Size = new System.Drawing.Size(142, 22);
			this.ctlRemoveUser.Text = "Удалить...";
			this.ctlRemoveUser.Click += new System.EventHandler(this.ctlRemoveUser_Click);
			// 
			// tabPAwards
			// 
			this.tabPAwards.Controls.Add(this.dgvAwards);
			this.tabPAwards.Controls.Add(this.menuStrip2);
			this.tabPAwards.Location = new System.Drawing.Point(4, 22);
			this.tabPAwards.Name = "tabPAwards";
			this.tabPAwards.Padding = new System.Windows.Forms.Padding(3);
			this.tabPAwards.Size = new System.Drawing.Size(792, 422);
			this.tabPAwards.TabIndex = 1;
			this.tabPAwards.Text = "Награды";
			this.tabPAwards.UseVisualStyleBackColor = true;
			// 
			// dgvAwards
			// 
			this.dgvAwards.AllowUserToAddRows = false;
			this.dgvAwards.AllowUserToDeleteRows = false;
			this.dgvAwards.AllowUserToResizeRows = false;
			this.dgvAwards.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvAwards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvAwards.Location = new System.Drawing.Point(3, 31);
			this.dgvAwards.Name = "dgvAwards";
			this.dgvAwards.Size = new System.Drawing.Size(786, 391);
			this.dgvAwards.TabIndex = 0;
			this.dgvAwards.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAwards_ColumnHeaderMouseClick);
			// 
			// menuStrip2
			// 
			this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctlCorrectAwards});
			this.menuStrip2.Location = new System.Drawing.Point(3, 3);
			this.menuStrip2.Name = "menuStrip2";
			this.menuStrip2.Size = new System.Drawing.Size(786, 24);
			this.menuStrip2.TabIndex = 1;
			this.menuStrip2.Text = "menuStrip2";
			// 
			// ctlCorrectAwards
			// 
			this.ctlCorrectAwards.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctlAddAward,
            this.ctlFixedAward,
            this.ctlRemoveAward});
			this.ctlCorrectAwards.Name = "ctlCorrectAwards";
			this.ctlCorrectAwards.Size = new System.Drawing.Size(73, 20);
			this.ctlCorrectAwards.Text = "Изменить";
			// 
			// ctlAddAward
			// 
			this.ctlAddAward.Name = "ctlAddAward";
			this.ctlAddAward.Size = new System.Drawing.Size(180, 22);
			this.ctlAddAward.Text = "Добавить...";
			this.ctlAddAward.Click += new System.EventHandler(this.ctlAddAward_Click);
			// 
			// ctlFixedAward
			// 
			this.ctlFixedAward.Name = "ctlFixedAward";
			this.ctlFixedAward.Size = new System.Drawing.Size(180, 22);
			this.ctlFixedAward.Text = "Исправить...";
			this.ctlFixedAward.Click += new System.EventHandler(this.ctlFixedAward_Click);
			// 
			// ctlRemoveAward
			// 
			this.ctlRemoveAward.Name = "ctlRemoveAward";
			this.ctlRemoveAward.Size = new System.Drawing.Size(180, 22);
			this.ctlRemoveAward.Text = "Удалить";
			this.ctlRemoveAward.Click += new System.EventHandler(this.ctlRemoveAward_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.tabControl);
			this.MainMenuStrip = this.menuStrip2;
			this.Name = "MainForm";
			this.Text = "Награды";
			this.tabControl.ResumeLayout(false);
			this.tabPUsers.ResumeLayout(false);
			this.tabPUsers.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.tabPAwards.ResumeLayout(false);
			this.tabPAwards.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvAwards)).EndInit();
			this.menuStrip2.ResumeLayout(false);
			this.menuStrip2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage tabPUsers;
		private System.Windows.Forms.TabPage tabPAwards;
		private System.Windows.Forms.DataGridView dgvAwards;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem ctlFile;
		private System.Windows.Forms.ToolStripMenuItem ctlClose;
		private System.Windows.Forms.ToolStripMenuItem изминитьToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ctlCorrectUser;
		private System.Windows.Forms.ToolStripMenuItem ctlAddUser;
		private System.Windows.Forms.ToolStripMenuItem ctlFixedUser;
		private System.Windows.Forms.ToolStripMenuItem ctlRemoveUser;
		private System.Windows.Forms.MenuStrip menuStrip2;
		private System.Windows.Forms.ToolStripMenuItem ctlCorrectAwards;
		private System.Windows.Forms.ToolStripMenuItem ctlAddAward;
		private System.Windows.Forms.ToolStripMenuItem ctlFixedAward;
		private System.Windows.Forms.ToolStripMenuItem ctlRemoveAward;
		private System.Windows.Forms.DataGridView dgvUser;
	}
}

