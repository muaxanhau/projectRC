/*
 * Author: 
 * Created: 
 * Description: 
 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ReportChecker.Resources.Views.UserControls
{
	/// <summary>
	/// Description of UCUserManagement.
	/// </summary>
	public partial class UCUserManagement : UserControl
	{
		private UCUserList userListUC = new UCUserList();
		private UCUserCreation userCreationUC = new UCUserCreation();
		
		public UCUserManagement()
		{
			InitializeComponent();
			this.customeComponents();
			
		}
		private void customeComponents()
		{
			this.Controls.Add(this.userListUC);
			this.Controls.Add(this.userCreationUC);
			
			this.userListUC.Location = new Point(21, 58);
			this.userCreationUC.Location = new Point(21, 58);
			
			this.userListUC.BringToFront();
		}
		void BtnManagementClick(object sender, EventArgs e)
		{
			this.userListUC.BringToFront();
		}
		void BtnCreationClick(object sender, EventArgs e)
		{
			this.userCreationUC.BringToFront();
		}
	}
}
