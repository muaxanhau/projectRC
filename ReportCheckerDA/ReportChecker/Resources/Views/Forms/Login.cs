/*
 * Author: 
 * Created: 
 * Description: 
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;
using System.Threading.Tasks;
using System.Linq;

namespace ReportChecker.Resources.Views.Forms
{
	/// <summary>
	/// Description of Login.
	/// </summary>
	public partial class Login : Form
	{
		private Hashtable noteDictionary;
		
		public Login()
		{
			InitializeComponent();
			this.defineTooltipDictionary();
			this.customeComponents();
		}
		#region Private method
		private void defineTooltipDictionary()
		{
			this.noteDictionary = new Hashtable() {
				{ this.btnExit.Name, "Thoát chương trình" },
				{ this.btnMinimize.Name, "Thu nhỏ" }
			};
		}
		private void customeComponents()
		{
			this.proLoading.Visible = false;
			this.btnMinimize.MouseHover += this.EventButtonMouseHover;
			this.btnExit.MouseHover += this.EventButtonMouseHover;
			
			this.btnMinimize.MouseLeave += this.EventButtonMouseLeave;
			this.btnExit.MouseLeave += this.EventButtonMouseLeave;
			
			this.txbPassword.Select();
		}
		private void closeNote()
		{
			try {
				Application.OpenForms["Note"].Close();
			} catch(Exception e) {
				Console.Write(e);
			}
		}
		private void exitComfirm()
		{
			using (var form = new Confirm("Bạn có chắc muốn thoát?")) {
				form.ShowDialog();
				if (form.isCancel) {
					return;
				}
			}
			Environment.Exit(0);
			Application.Exit();
		}
		private void toggleLoading()
		{
			this.txbPassword.Enabled = !this.txbPassword.Enabled;
			this.btnLogin.Enabled = !this.btnLogin.Enabled;
			this.proLoading.Visible = !this.proLoading.Visible;
			this.proLoading.AutoStart = !this.proLoading.AutoStart;
		}
		private async void asyncCheckLogin(Task<bool> task)
        {
			this.toggleLoading();
			bool isSuccess = await task;
			this.toggleLoading();
			this.txbPassword.Clear();
			if (isSuccess) {
				this.Hide();
				using (var fr = new App()) {
					fr.ShowDialog();
				}
				this.Show();
			} else {
				using (var fr = new Confirm("Không thành công!")) {
					fr.ShowDialog();
				}
			}
        }
		private Task<bool> taskCheckLogin()
		{
			return Task.Factory.StartNew(() => checkLogin());
		}
		private bool checkLogin()
		{
			const string username = "admin";
			string password = this.txbPassword.Text;
			return DBEntity.Method.loginUser(username, password);
		}
		#endregion
		
		#region UI Event
		void EventButtonMouseHover(object sender, EventArgs e)
		{
			var btn = (Guna.UI2.WinForms.Guna2ImageButton)sender;
			
			Point locationBtn = btn.PointToScreen(Point.Empty);
			var locationNote = new Point(locationBtn.X + btn.Width / 2 - 7, locationBtn.Y + btn.Height + 2);
			var form = new Tooltip(this.noteDictionary[btn.Name].ToString(), locationNote);
			form.Show();
		}
		void EventButtonMouseLeave(object sender, EventArgs e)
		{
			this.closeNote();
		}
		void BtnExitClick(object sender, EventArgs e)
		{
			this.exitComfirm();
		}
		void BtnMinimizeClick(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}
		void BtnLoginClick(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(this.txbPassword.Text)) {
				using (var fr = new Confirm("Mật khẩu trống!")) {
					fr.ShowDialog();
				}
				return;
			}
			this.asyncCheckLogin(taskCheckLogin());
		}
		#endregion
	}
}
