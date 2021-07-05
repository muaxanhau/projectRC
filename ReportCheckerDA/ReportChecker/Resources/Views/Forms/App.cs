/*
 * Author: 
 * Created: 
 * Description: 
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using ReportChecker.Resources.Views.Forms;
using ReportChecker.Resources.Views.UserControls;
using System.Collections;

namespace ReportChecker.Resources.Views.Forms
{
	/// <summary>
	/// Description of App.
	/// </summary>
	public partial class App : Form
	{
		private UCFilter filterUC = new UCFilter();
		private UCStatistical statisticalUC = new UCStatistical();
		private UCUserManagement userUC = new UCUserManagement();
		private UCHelper helperUC = new UCHelper();
		
		private Hashtable noteDictionary;
		
		public App()
		{
			InitializeComponent();
			this.defineTooltipDictionary();
			this.customeComponents();
		}
		#region private methods
		private void defineTooltipDictionary()
		{
			this.noteDictionary = new Hashtable() {
				{ this.btnDraftData.Name, "Lưu tạm thời dữ liệu, có thể khôi phục ở phiên làm việc kế tiếp" },
				{ this.btnRestorePreviousWorking.Name, "Lấy lại dữ liệu đã lưu trước đó" },
				{ this.btnExitMain.Name, "Thoát chương trình" },
				{ this.btnLogout.Name, "Đăng xuất" },
				{ this.btnMinimize.Name, "Thu nhỏ" }
			};
		}
		private void customeComponents()
		{
			this.labAppName.MouseHover += this.EventLabelMouseHover;
			this.labVersion.MouseHover += this.EventLabelMouseHover;
			this.btnDraftData.MouseHover += this.EventButtonMouseHover;
			this.btnRestorePreviousWorking.MouseHover += this.EventButtonMouseHover;
			this.btnExitMain.MouseHover += this.EventButtonMouseHover;
			this.btnLogout.MouseHover += this.EventButtonMouseHover;
			this.btnMinimize.MouseHover += this.EventButtonMouseHover;
			
			this.labAppName.MouseLeave += this.EventLabelMouseLeave;
			this.labVersion.MouseLeave += this.EventLabelMouseLeave;
			this.btnDraftData.MouseLeave += this.EventButtonMouseLeave;
			this.btnRestorePreviousWorking.MouseLeave += this.EventButtonMouseLeave;
			this.btnExitMain.MouseLeave += this.EventButtonMouseLeave;
			this.btnLogout.MouseLeave += this.EventButtonMouseLeave;
			this.btnMinimize.MouseLeave += this.EventButtonMouseLeave;

			this.pnlMainView.Controls.Add(this.filterUC);
			this.pnlMainView.Controls.Add(this.statisticalUC);
			this.pnlMainView.Controls.Add(this.userUC);
			this.pnlMainView.Controls.Add(this.helperUC);
			
			this.filterUC.Location = new Point(0, 40);
			this.statisticalUC.Location = new Point(0, 40);
			this.userUC.Location = new Point(0, 40);
			this.helperUC.Location = new Point(0, 40);
			
			this.filterUC.BringToFront();
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
		private void closeNote()
		{
			try {
				Application.OpenForms["Note"].Close();
			} catch(Exception e) {
				Console.Write(e);
			}
		}
		#endregion
		#region UI events
		void EventLabelMouseHover(object sender, EventArgs e)
		{
			var lab = (Label)sender;
			lab.ForeColor = Color.FromArgb(18, 243, 200);
		}
		void EventLabelMouseLeave(object sender, EventArgs e)
		{
			var lab = (Label)sender;
			lab.ForeColor = Color.FromArgb(230, 229, 243);
		}
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
		void BtnFilterClick(object sender, EventArgs e)
		{
			this.filterUC.BringToFront();
		}
		void BtnStatisticalClick(object sender, EventArgs e)
		{
			this.statisticalUC.BringToFront();
		}
		void BtnUserClick(object sender, EventArgs e)
		{
			this.userUC.BringToFront();
		}
		void BtnHelperClick(object sender, EventArgs e)
		{
			this.helperUC.BringToFront();
		}
		void BtnDraftDataClick(object sender, EventArgs e)
		{
			this.filterUC.draftData();
		}
		void BtnRestorePreviousWorkingClick(object sender, EventArgs e)
		{
			this.filterUC.restoreData();
		}
		void BtnExitMainClick(object sender, EventArgs e)
		{
			this.exitComfirm();
		}
		void BtnLogoutClick(object sender, EventArgs e)
		{
			this.Close();
		}
		void BtnMinimizeClick(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}
		#endregion
	}
}

