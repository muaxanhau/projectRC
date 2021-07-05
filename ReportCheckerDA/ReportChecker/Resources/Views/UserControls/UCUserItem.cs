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

namespace ReportChecker.Resources.Views.UserControls
{
	/// <summary>
	/// Description of UCUserItem.
	/// </summary>
	public partial class UCUserItem : UserControl
	{
		private string username;
		private string password;
		
		public UCUserItem(string username, string password)
		{
			InitializeComponent();
			
			this.username = username;
			this.password = password;
			
			this.customeComponent();
		}
		private void customeComponent()
		{
			this.labUsername.Text = this.username;
			this.labPassword.Text = this.password;
		}
		void UCUserItemMouseHover(object sender, EventArgs e)
		{
			this.BackColor = Color.FromArgb(24, 63, 148);
			this.labUsername.ForeColor = Color.FromArgb(18, 243, 200);
			this.labPassword.ForeColor = Color.FromArgb(18, 243, 200);
			this.btnRemove.ForeColor = Color.FromArgb(18, 243, 200);
		}
		void UCUserItemMouseLeave(object sender, EventArgs e)
		{
			bool isInWidth = (PointToScreen(Point.Empty).X < Cursor.Position.X) && ((PointToScreen(Point.Empty).X + this.Width) > Cursor.Position.X);
			bool isInHeight = (PointToScreen(Point.Empty).Y < Cursor.Position.Y) && ((PointToScreen(Point.Empty).Y + this.Height) > Cursor.Position.Y);
			if (isInWidth && isInHeight) {
				return;
			}
			this.BackColor = Color.FromArgb(230, 229, 243);
			this.labUsername.ForeColor = Color.FromArgb(55, 0, 60);
			this.labPassword.ForeColor = Color.FromArgb(55, 0, 60);
			this.btnRemove.ForeColor = Color.FromArgb(55, 70, 112);
		}
		private void toggleLoading()
		{
			this.Enabled = !this.Enabled;
			this.proLoading.Visible = !this.proLoading.Visible;
			this.proLoading.AutoStart = !this.proLoading.AutoStart;
		}
		private async void asyncRemoveUser(Task<bool> task)
        {
			this.toggleLoading();
			bool isSuccess = await task;
			this.toggleLoading();
			if (isSuccess) {
				this.Parent.Controls.Remove(this);
			} else {
				using (var fr = new Forms.Confirm("Không thành công!")) {
					fr.ShowDialog();
				}
			}
        }
		private Task<bool> taskRemoveUser(string usernameC)
		{
			return Task.Factory.StartNew(() => removeUser(usernameC));
		}
		private bool removeUser(string usernameC)
		{			
			var result =  DBEntity.Method.removeUser(usernameC);
			return result;
		}
		void BtnRemoveClick(object sender, EventArgs e)
		{
			using (var fr = new Forms.Confirm("Bạn có chắc muốn xóa?")) {
				fr.ShowDialog();
				if (!fr.isOk) {
					return;
				}
			}
			this.asyncRemoveUser(taskRemoveUser(this.username));
		}
	}
}
