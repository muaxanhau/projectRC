/*
 * Author: 
 * Created: 
 * Description: 
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ReportChecker.Resources.Views.Forms
{
	/// <summary>
	/// Description of Alert.
	/// </summary>
	public partial class Alert : Form
	{
		private enum enmAction
		{
			Start,
			Wait,
			Close
		}
		private enmAction action;
		private int x, y;
		private bool isAbsoluteClosed = false;
		private bool isAbsoluteOpened = true;
		public void showAlert(string message)
		{
			this.Opacity = 0.0;
			this.StartPosition = FormStartPosition.Manual;
			
			string fName;
			for (int i = 1; i < 10; i++) {
				fName = "Alert" + i;
				var frm = (Alert)Application.OpenForms[fName];
				if (frm == null) {
					this.Name = fName;
					this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 15;
					this.y = Screen.PrimaryScreen.WorkingArea.Height - this.Height * i - 5 * i;
					this.Location = new Point(this.x, this.y);
					break;
				}
			}
			this.x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;
			
			this.labMessage.Text = message;
			this.Show();
			this.action = enmAction.Start;
			this.tmrMain.Interval = 1;
			this.tmrMain.Start();
		}
		public Alert()
		{
			InitializeComponent();
			
		}
		private void setupForCloseForm()
		{
			this.isAbsoluteClosed = true;
			this.action = enmAction.Close;
			this.tmrMain.Interval = 1;
			this.tmrMain.Start();
		}
		void BtnCloseClick(object sender, EventArgs e)
		{
			this.setupForCloseForm();
		}
		void PnlMainClick(object sender, EventArgs e)
		{
			if (Application.OpenForms["App"].WindowState == FormWindowState.Minimized) {
				Application.OpenForms["App"].WindowState = FormWindowState.Normal;
			} else {
				Application.OpenForms["App"].BringToFront();
			}
			this.setupForCloseForm();
		}
		void TmrMainTick(object sender, EventArgs e)
		{
			switch (this.action) {
				case enmAction.Wait: {
					this.tmrMain.Interval = 5000;
					this.action = enmAction.Close;
					break;
				}
				case enmAction.Start: {
					this.tmrMain.Interval = 1;
					this.Opacity += 0.1;
					if (this.x < this.Location.X) {
						this.Left--;
					} else {
						if (this.Opacity.Equals(1.0F)) {
							this.isAbsoluteOpened = false;
							this.action = enmAction.Wait;
						}
					}
					break;
				}
				case enmAction.Close: {
					this.isAbsoluteClosed = true;
					this.tmrMain.Interval = 1;
					this.Opacity -= 0.1;
					this.Left -= 3;
					if (base.Opacity.Equals(0.0F)) {
						base.Close();
					}
					break;
				}
			}
		}
		void PnlMainMouseHover(object sender, EventArgs e)
		{
			if (this.isAbsoluteClosed || this.isAbsoluteOpened) {
				return;
			}
			this.btnClose.Visible = true;
			this.labMessage.ForeColor = Color.FromArgb(18, 243, 200);
			this.labMessage.BringToFront();
			this.pnlMain.BringToFront();
			this.btnClose.BringToFront();
			this.tmrMain.Stop();
		}
		void PnlMainMouseLeave(object sender, EventArgs e)
		{
			if (this.isAbsoluteClosed) {
				return;
			}
			bool isInWidth = (this.Location.X < Cursor.Position.X) && ((this.Location.X + this.Width) > Cursor.Position.X);
			bool isInHeight = (this.Location.Y < Cursor.Position.Y) && ((this.Location.Y + this.Height) > Cursor.Position.Y);
			if (isInWidth && isInHeight) {
				return;
			}
			this.btnClose.Visible = false;
			this.labMessage.ForeColor = Color.FromArgb(245, 245, 245);
			this.labMessage.BringToFront();
			this.pnlMain.BringToFront();
			this.action = enmAction.Wait;
			this.tmrMain.Interval = 1;
			this.tmrMain.Start();
		}
	}
}
