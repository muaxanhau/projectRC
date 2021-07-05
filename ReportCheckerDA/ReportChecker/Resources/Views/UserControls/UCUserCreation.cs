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
using ReportChecker.Resources.Views.Forms;

namespace ReportChecker.Resources.Views.UserControls
{
	/// <summary>
	/// Description of UCUserCreation.
	/// </summary>
	public partial class UCUserCreation : UserControl
	{
		public UCUserCreation()
		{
			InitializeComponent();
			
		}
		private void toggleLoading()
		{
			this.Enabled = !this.Enabled;
			this.proLoading.Visible = !this.proLoading.Visible;
			this.proLoading.AutoStart = !this.proLoading.AutoStart;
		}
		private async void asyncCreateUser(Task<bool> task)
        {
			toggleLoading();
			bool isSuccess = await task;
			toggleLoading();
			
			this.txbUsername.Clear();
			this.txbPassword.Clear();
			using (var fr = new Confirm(isSuccess ? "Tạo thành công." : "Không thành công!")) {
				fr.ShowDialog();
			}
        }
		private Task<bool> taskCreateUser(string username, string password)
		{
			return Task.Factory.StartNew(() => createUser(username, password));
		}
		private bool createUser(string username, string password)
		{
			bool result =  DBEntity.Method.addUser(username, password);
			return result;
		}
		void BtnCreateClick(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(this.txbUsername.Text) || string.IsNullOrEmpty(this.txbPassword.Text)) {
				using (var fr = new Confirm("Không bỏ trống!")) {
					fr.ShowDialog();
				}
				return;
			}
			this.asyncCreateUser(taskCreateUser(this.txbUsername.Text.ToLower(), this.txbPassword.Text));
		}
	}
}
