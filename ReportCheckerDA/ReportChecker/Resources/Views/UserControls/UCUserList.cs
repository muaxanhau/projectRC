/*
 * Author: 
 * Created: 
 * Description: 
 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;

namespace ReportChecker.Resources.Views.UserControls
{
	/// <summary>
	/// Description of UCUserList.
	/// </summary>
	public partial class UCUserList : UserControl
	{
		public UCUserList()
		{
			InitializeComponent();
			this.customeComponent();
		}
		private void customeComponent()
		{
			this.asyncGetUser(taskGetUser());
		}
		private void toggleLoading()
		{
			this.Enabled = !this.Enabled;
			this.proLoading.Visible = !this.proLoading.Visible;
			this.proLoading.AutoStart = !this.proLoading.AutoStart;
		}
		private async void asyncGetUser(Task<dynamic> task)
        {
			this.toggleLoading();
			dynamic userList = await task;
			this.toggleLoading();
			
			if (userList.Count == 0) {
				this.labEmpty.Visible = true;
				return;
			}
			this.labEmpty.Visible = false;
			foreach (dynamic item in userList) {
				var uc = new UCUserItem(item.Username, item.Password);
				this.pnlListUser.Controls.Add(uc);
			}
        }
		private Task<dynamic> taskGetUser()
		{
			return Task.Factory.StartNew(() => getUser());
		}
		private dynamic getUser()
		{
			dynamic result = DBEntity.Method.getAllUsers();
			return result;
		}
		void BtnRefreshClick(object sender, EventArgs e)
		{
			this.pnlListUser.Controls.Clear();
			this.asyncGetUser(taskGetUser());
		}
	}
}
