/*
 * Author: 
 * Created: 
 * Description: 
 */
namespace ReportChecker.Resources.Views.UserControls
{
	partial class UCUserList
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private Guna.UI2.WinForms.Guna2Button btnRefresh;
		private System.Windows.Forms.FlowLayoutPanel pnlListUser;
		private Guna.UI2.WinForms.Guna2ProgressIndicator proLoading;
		private Guna.UI2.WinForms.Guna2HtmlLabel labEmpty;
		
		/// <summary>
		/// Disposes resources used by the control.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.pnlListUser = new System.Windows.Forms.FlowLayoutPanel();
			this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
			this.proLoading = new Guna.UI2.WinForms.Guna2ProgressIndicator();
			this.labEmpty = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.SuspendLayout();
			// 
			// pnlListUser
			// 
			this.pnlListUser.AutoScroll = true;
			this.pnlListUser.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pnlListUser.Location = new System.Drawing.Point(0, 38);
			this.pnlListUser.Name = "pnlListUser";
			this.pnlListUser.Size = new System.Drawing.Size(558, 354);
			this.pnlListUser.TabIndex = 10;
			// 
			// btnRefresh
			// 
			this.btnRefresh.BorderColor = System.Drawing.Color.Transparent;
			this.btnRefresh.CheckedState.Parent = this.btnRefresh;
			this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnRefresh.CustomImages.Parent = this.btnRefresh;
			this.btnRefresh.FillColor = System.Drawing.Color.Transparent;
			this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(70)))), ((int)(((byte)(112)))));
			this.btnRefresh.HoverState.Parent = this.btnRefresh;
			this.btnRefresh.Location = new System.Drawing.Point(473, 3);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.PressedColor = System.Drawing.Color.Transparent;
			this.btnRefresh.ShadowDecoration.Parent = this.btnRefresh;
			this.btnRefresh.Size = new System.Drawing.Size(85, 29);
			this.btnRefresh.TabIndex = 11;
			this.btnRefresh.Text = "Làm mới";
			this.btnRefresh.Click += new System.EventHandler(this.BtnRefreshClick);
			// 
			// proLoading
			// 
			this.proLoading.CircleSize = 1F;
			this.proLoading.Location = new System.Drawing.Point(437, 3);
			this.proLoading.Name = "proLoading";
			this.proLoading.Size = new System.Drawing.Size(30, 30);
			this.proLoading.TabIndex = 27;
			this.proLoading.Visible = false;
			// 
			// labEmpty
			// 
			this.labEmpty.BackColor = System.Drawing.Color.Transparent;
			this.labEmpty.Location = new System.Drawing.Point(260, 12);
			this.labEmpty.Name = "labEmpty";
			this.labEmpty.Size = new System.Drawing.Size(37, 15);
			this.labEmpty.TabIndex = 28;
			this.labEmpty.Text = "(Trống)";
			this.labEmpty.Visible = false;
			// 
			// UCUserList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.labEmpty);
			this.Controls.Add(this.proLoading);
			this.Controls.Add(this.btnRefresh);
			this.Controls.Add(this.pnlListUser);
			this.Name = "UCUserList";
			this.Size = new System.Drawing.Size(558, 392);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
