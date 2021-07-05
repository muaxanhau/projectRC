/*
 * Author: 
 * Created: 
 * Description: 
 */
namespace ReportChecker.Resources.Views.Forms
{
	partial class App
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private Guna.UI2.WinForms.Guna2DragControl drcApp;
		private Guna.UI2.WinForms.Guna2Elipse eclApp;
		private Guna.UI2.WinForms.Guna2Button btnFilter;
		private System.Windows.Forms.Label labAppName;
		private Guna.UI2.WinForms.Guna2Panel pnlMainView;
		private Guna.UI2.WinForms.Guna2ImageButton btnExitMain;
		private Guna.UI2.WinForms.Guna2Elipse eclPnlMain;
		private Guna.UI2.WinForms.Guna2ImageButton btnMinimize;
		private Guna.UI2.WinForms.Guna2ImageButton btnLogout;
		private Guna.UI2.WinForms.Guna2Button btnHelper;
		private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
		private System.Windows.Forms.Label labVersion;
		private Guna.UI2.WinForms.Guna2ImageButton btnIcon;
		private Guna.UI2.WinForms.Guna2VSeparator sprVertical;
		private Guna.UI2.WinForms.Guna2ImageButton btnRestorePreviousWorking;
		private Guna.UI2.WinForms.Guna2ImageButton btnDraftData;
		private Guna.UI2.WinForms.Guna2Button btnUser;
		private Guna.UI2.WinForms.Guna2Button btnStatistical;
		
		/// <summary>
		/// Disposes resources used by the form.
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(App));
			this.drcApp = new Guna.UI2.WinForms.Guna2DragControl(this.components);
			this.eclApp = new Guna.UI2.WinForms.Guna2Elipse(this.components);
			this.pnlMainView = new Guna.UI2.WinForms.Guna2Panel();
			this.btnRestorePreviousWorking = new Guna.UI2.WinForms.Guna2ImageButton();
			this.btnDraftData = new Guna.UI2.WinForms.Guna2ImageButton();
			this.btnMinimize = new Guna.UI2.WinForms.Guna2ImageButton();
			this.btnExitMain = new Guna.UI2.WinForms.Guna2ImageButton();
			this.btnFilter = new Guna.UI2.WinForms.Guna2Button();
			this.eclPnlMain = new Guna.UI2.WinForms.Guna2Elipse(this.components);
			this.btnLogout = new Guna.UI2.WinForms.Guna2ImageButton();
			this.btnHelper = new Guna.UI2.WinForms.Guna2Button();
			this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
			this.labVersion = new System.Windows.Forms.Label();
			this.btnIcon = new Guna.UI2.WinForms.Guna2ImageButton();
			this.sprVertical = new Guna.UI2.WinForms.Guna2VSeparator();
			this.labAppName = new System.Windows.Forms.Label();
			this.btnUser = new Guna.UI2.WinForms.Guna2Button();
			this.btnStatistical = new Guna.UI2.WinForms.Guna2Button();
			this.pnlMainView.SuspendLayout();
			this.SuspendLayout();
			// 
			// drcApp
			// 
			this.drcApp.ContainerControl = this;
			this.drcApp.TargetControl = this;
			this.drcApp.TransparentWhileDrag = true;
			this.drcApp.UseTransparentDrag = true;
			// 
			// eclApp
			// 
			this.eclApp.BorderRadius = 10;
			this.eclApp.TargetControl = this;
			// 
			// pnlMainView
			// 
			this.pnlMainView.BackColor = System.Drawing.Color.White;
			this.pnlMainView.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(62)))), ((int)(((byte)(148)))));
			this.pnlMainView.Controls.Add(this.btnRestorePreviousWorking);
			this.pnlMainView.Controls.Add(this.btnDraftData);
			this.pnlMainView.Controls.Add(this.btnMinimize);
			this.pnlMainView.Controls.Add(this.btnExitMain);
			this.pnlMainView.Location = new System.Drawing.Point(182, 12);
			this.pnlMainView.Name = "pnlMainView";
			this.pnlMainView.ShadowDecoration.Parent = this.pnlMainView;
			this.pnlMainView.Size = new System.Drawing.Size(601, 530);
			this.pnlMainView.TabIndex = 0;
			// 
			// btnRestorePreviousWorking
			// 
			this.btnRestorePreviousWorking.BackColor = System.Drawing.Color.Transparent;
			this.btnRestorePreviousWorking.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
			this.btnRestorePreviousWorking.CheckedState.Parent = this.btnRestorePreviousWorking;
			this.btnRestorePreviousWorking.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("btnRestorePreviousWorking.HoverState.Image")));
			this.btnRestorePreviousWorking.HoverState.ImageSize = new System.Drawing.Size(22, 22);
			this.btnRestorePreviousWorking.HoverState.Parent = this.btnRestorePreviousWorking;
			this.btnRestorePreviousWorking.Image = ((System.Drawing.Image)(resources.GetObject("btnRestorePreviousWorking.Image")));
			this.btnRestorePreviousWorking.ImageRotate = 0F;
			this.btnRestorePreviousWorking.ImageSize = new System.Drawing.Size(22, 22);
			this.btnRestorePreviousWorking.Location = new System.Drawing.Point(8, 8);
			this.btnRestorePreviousWorking.Name = "btnRestorePreviousWorking";
			this.btnRestorePreviousWorking.PressedState.Image = ((System.Drawing.Image)(resources.GetObject("btnRestorePreviousWorking.PressedState.Image")));
			this.btnRestorePreviousWorking.PressedState.ImageSize = new System.Drawing.Size(17, 17);
			this.btnRestorePreviousWorking.PressedState.Parent = this.btnRestorePreviousWorking;
			this.btnRestorePreviousWorking.Size = new System.Drawing.Size(22, 22);
			this.btnRestorePreviousWorking.TabIndex = 5;
			this.btnRestorePreviousWorking.UseTransparentBackground = true;
			this.btnRestorePreviousWorking.Click += new System.EventHandler(this.BtnRestorePreviousWorkingClick);
			// 
			// btnDraftData
			// 
			this.btnDraftData.BackColor = System.Drawing.Color.Transparent;
			this.btnDraftData.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
			this.btnDraftData.CheckedState.Parent = this.btnDraftData;
			this.btnDraftData.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("btnDraftData.HoverState.Image")));
			this.btnDraftData.HoverState.ImageSize = new System.Drawing.Size(22, 22);
			this.btnDraftData.HoverState.Parent = this.btnDraftData;
			this.btnDraftData.Image = ((System.Drawing.Image)(resources.GetObject("btnDraftData.Image")));
			this.btnDraftData.ImageRotate = 0F;
			this.btnDraftData.ImageSize = new System.Drawing.Size(22, 22);
			this.btnDraftData.Location = new System.Drawing.Point(36, 8);
			this.btnDraftData.Name = "btnDraftData";
			this.btnDraftData.PressedState.Image = ((System.Drawing.Image)(resources.GetObject("btnDraftData.PressedState.Image")));
			this.btnDraftData.PressedState.ImageSize = new System.Drawing.Size(17, 17);
			this.btnDraftData.PressedState.Parent = this.btnDraftData;
			this.btnDraftData.Size = new System.Drawing.Size(22, 22);
			this.btnDraftData.TabIndex = 3;
			this.btnDraftData.UseTransparentBackground = true;
			this.btnDraftData.Click += new System.EventHandler(this.BtnDraftDataClick);
			// 
			// btnMinimize
			// 
			this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
			this.btnMinimize.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
			this.btnMinimize.CheckedState.Parent = this.btnMinimize;
			this.btnMinimize.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.HoverState.Image")));
			this.btnMinimize.HoverState.ImageSize = new System.Drawing.Size(22, 22);
			this.btnMinimize.HoverState.Parent = this.btnMinimize;
			this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
			this.btnMinimize.ImageRotate = 0F;
			this.btnMinimize.ImageSize = new System.Drawing.Size(22, 22);
			this.btnMinimize.Location = new System.Drawing.Point(546, 8);
			this.btnMinimize.Name = "btnMinimize";
			this.btnMinimize.PressedState.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.PressedState.Image")));
			this.btnMinimize.PressedState.ImageSize = new System.Drawing.Size(17, 17);
			this.btnMinimize.PressedState.Parent = this.btnMinimize;
			this.btnMinimize.Size = new System.Drawing.Size(22, 22);
			this.btnMinimize.TabIndex = 1;
			this.btnMinimize.UseTransparentBackground = true;
			this.btnMinimize.Click += new System.EventHandler(this.BtnMinimizeClick);
			// 
			// btnExitMain
			// 
			this.btnExitMain.BackColor = System.Drawing.Color.Transparent;
			this.btnExitMain.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
			this.btnExitMain.CheckedState.Parent = this.btnExitMain;
			this.btnExitMain.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("btnExitMain.HoverState.Image")));
			this.btnExitMain.HoverState.ImageSize = new System.Drawing.Size(22, 22);
			this.btnExitMain.HoverState.Parent = this.btnExitMain;
			this.btnExitMain.Image = ((System.Drawing.Image)(resources.GetObject("btnExitMain.Image")));
			this.btnExitMain.ImageRotate = 0F;
			this.btnExitMain.ImageSize = new System.Drawing.Size(22, 22);
			this.btnExitMain.Location = new System.Drawing.Point(574, 8);
			this.btnExitMain.Name = "btnExitMain";
			this.btnExitMain.PressedState.Image = ((System.Drawing.Image)(resources.GetObject("btnExitMain.PressedState.Image")));
			this.btnExitMain.PressedState.ImageSize = new System.Drawing.Size(17, 17);
			this.btnExitMain.PressedState.Parent = this.btnExitMain;
			this.btnExitMain.Size = new System.Drawing.Size(22, 22);
			this.btnExitMain.TabIndex = 0;
			this.btnExitMain.UseTransparentBackground = true;
			this.btnExitMain.Click += new System.EventHandler(this.BtnExitMainClick);
			// 
			// btnFilter
			// 
			this.btnFilter.BackColor = System.Drawing.Color.Transparent;
			this.btnFilter.BorderRadius = 5;
			this.btnFilter.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
			this.btnFilter.Checked = true;
			this.btnFilter.CheckedState.FillColor = System.Drawing.Color.White;
			this.btnFilter.CheckedState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFilter.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(63)))), ((int)(((byte)(148)))));
			this.btnFilter.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("btnFilter.CheckedState.Image")));
			this.btnFilter.CheckedState.Parent = this.btnFilter;
			this.btnFilter.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnFilter.CustomImages.Parent = this.btnFilter;
			this.btnFilter.FillColor = System.Drawing.Color.Transparent;
			this.btnFilter.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.btnFilter.ForeColor = System.Drawing.Color.White;
			this.btnFilter.HoverState.FillColor = System.Drawing.Color.Transparent;
			this.btnFilter.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFilter.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(243)))), ((int)(((byte)(200)))));
			this.btnFilter.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("btnFilter.HoverState.Image")));
			this.btnFilter.HoverState.Parent = this.btnFilter;
			this.btnFilter.Image = ((System.Drawing.Image)(resources.GetObject("btnFilter.Image")));
			this.btnFilter.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.btnFilter.Location = new System.Drawing.Point(52, 158);
			this.btnFilter.Name = "btnFilter";
			this.btnFilter.ShadowDecoration.Parent = this.btnFilter;
			this.btnFilter.Size = new System.Drawing.Size(135, 45);
			this.btnFilter.TabIndex = 4;
			this.btnFilter.Text = "Kiểm hàng";
			this.btnFilter.TextOffset = new System.Drawing.Point(10, 0);
			this.btnFilter.UseTransparentBackground = true;
			this.btnFilter.Click += new System.EventHandler(this.BtnFilterClick);
			// 
			// eclPnlMain
			// 
			this.eclPnlMain.BorderRadius = 10;
			this.eclPnlMain.TargetControl = this.pnlMainView;
			// 
			// btnLogout
			// 
			this.btnLogout.BackColor = System.Drawing.Color.Transparent;
			this.btnLogout.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
			this.btnLogout.CheckedState.Parent = this.btnLogout;
			this.btnLogout.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.HoverState.Image")));
			this.btnLogout.HoverState.ImageSize = new System.Drawing.Size(22, 22);
			this.btnLogout.HoverState.Parent = this.btnLogout;
			this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
			this.btnLogout.ImageRotate = 0F;
			this.btnLogout.ImageSize = new System.Drawing.Size(22, 22);
			this.btnLogout.Location = new System.Drawing.Point(12, 520);
			this.btnLogout.Name = "btnLogout";
			this.btnLogout.PressedState.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.PressedState.Image")));
			this.btnLogout.PressedState.ImageSize = new System.Drawing.Size(17, 17);
			this.btnLogout.PressedState.Parent = this.btnLogout;
			this.btnLogout.Size = new System.Drawing.Size(22, 22);
			this.btnLogout.TabIndex = 5;
			this.btnLogout.UseTransparentBackground = true;
			this.btnLogout.Click += new System.EventHandler(this.BtnLogoutClick);
			// 
			// btnHelper
			// 
			this.btnHelper.BackColor = System.Drawing.Color.Transparent;
			this.btnHelper.BorderRadius = 5;
			this.btnHelper.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
			this.btnHelper.CheckedState.FillColor = System.Drawing.Color.White;
			this.btnHelper.CheckedState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnHelper.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(63)))), ((int)(((byte)(148)))));
			this.btnHelper.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("btnHelper.CheckedState.Image")));
			this.btnHelper.CheckedState.Parent = this.btnHelper;
			this.btnHelper.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnHelper.CustomImages.Parent = this.btnHelper;
			this.btnHelper.FillColor = System.Drawing.Color.Transparent;
			this.btnHelper.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnHelper.ForeColor = System.Drawing.Color.White;
			this.btnHelper.HoverState.FillColor = System.Drawing.Color.Transparent;
			this.btnHelper.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnHelper.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(243)))), ((int)(((byte)(200)))));
			this.btnHelper.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("btnHelper.HoverState.Image")));
			this.btnHelper.HoverState.Parent = this.btnHelper;
			this.btnHelper.Image = ((System.Drawing.Image)(resources.GetObject("btnHelper.Image")));
			this.btnHelper.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.btnHelper.Location = new System.Drawing.Point(52, 311);
			this.btnHelper.Name = "btnHelper";
			this.btnHelper.ShadowDecoration.Parent = this.btnHelper;
			this.btnHelper.Size = new System.Drawing.Size(135, 45);
			this.btnHelper.TabIndex = 7;
			this.btnHelper.Text = "Trợ giúp";
			this.btnHelper.TextOffset = new System.Drawing.Point(10, 0);
			this.btnHelper.UseTransparentBackground = true;
			this.btnHelper.Click += new System.EventHandler(this.BtnHelperClick);
			// 
			// guna2Separator1
			// 
			this.guna2Separator1.Location = new System.Drawing.Point(0, 0);
			this.guna2Separator1.Name = "guna2Separator1";
			this.guna2Separator1.Size = new System.Drawing.Size(200, 10);
			this.guna2Separator1.TabIndex = 0;
			// 
			// labVersion
			// 
			this.labVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(229)))), ((int)(((byte)(243)))));
			this.labVersion.Location = new System.Drawing.Point(40, 520);
			this.labVersion.Name = "labVersion";
			this.labVersion.Size = new System.Drawing.Size(124, 22);
			this.labVersion.TabIndex = 9;
			this.labVersion.Text = "Phiên bản 1.1";
			this.labVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnIcon
			// 
			this.btnIcon.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
			this.btnIcon.CheckedState.Parent = this.btnIcon;
			this.btnIcon.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("btnIcon.HoverState.Image")));
			this.btnIcon.HoverState.ImageSize = new System.Drawing.Size(22, 22);
			this.btnIcon.HoverState.Parent = this.btnIcon;
			this.btnIcon.Image = ((System.Drawing.Image)(resources.GetObject("btnIcon.Image")));
			this.btnIcon.ImageRotate = 0F;
			this.btnIcon.ImageSize = new System.Drawing.Size(22, 22);
			this.btnIcon.Location = new System.Drawing.Point(12, 12);
			this.btnIcon.Name = "btnIcon";
			this.btnIcon.PressedState.ImageSize = new System.Drawing.Size(22, 22);
			this.btnIcon.PressedState.Parent = this.btnIcon;
			this.btnIcon.Size = new System.Drawing.Size(22, 22);
			this.btnIcon.TabIndex = 10;
			// 
			// sprVertical
			// 
			this.sprVertical.BackColor = System.Drawing.Color.Transparent;
			this.sprVertical.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(243)))), ((int)(((byte)(200)))));
			this.sprVertical.FillThickness = 2;
			this.sprVertical.Location = new System.Drawing.Point(12, 40);
			this.sprVertical.Name = "sprVertical";
			this.sprVertical.Size = new System.Drawing.Size(22, 474);
			this.sprVertical.TabIndex = 11;
			this.sprVertical.UseTransparentBackground = true;
			// 
			// labAppName
			// 
			this.labAppName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labAppName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(229)))), ((int)(((byte)(243)))));
			this.labAppName.Location = new System.Drawing.Point(40, 9);
			this.labAppName.Name = "labAppName";
			this.labAppName.Size = new System.Drawing.Size(124, 25);
			this.labAppName.TabIndex = 15;
			this.labAppName.Text = "ReportChecker";
			this.labAppName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnUser
			// 
			this.btnUser.BackColor = System.Drawing.Color.Transparent;
			this.btnUser.BorderRadius = 5;
			this.btnUser.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
			this.btnUser.CheckedState.FillColor = System.Drawing.Color.White;
			this.btnUser.CheckedState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUser.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(63)))), ((int)(((byte)(148)))));
			this.btnUser.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("btnUser.CheckedState.Image")));
			this.btnUser.CheckedState.Parent = this.btnUser;
			this.btnUser.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnUser.CustomImages.Parent = this.btnUser;
			this.btnUser.FillColor = System.Drawing.Color.Transparent;
			this.btnUser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUser.ForeColor = System.Drawing.Color.White;
			this.btnUser.HoverState.FillColor = System.Drawing.Color.Transparent;
			this.btnUser.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUser.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(243)))), ((int)(((byte)(200)))));
			this.btnUser.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("btnUser.HoverState.Image")));
			this.btnUser.HoverState.Parent = this.btnUser;
			this.btnUser.Image = ((System.Drawing.Image)(resources.GetObject("btnUser.Image")));
			this.btnUser.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.btnUser.Location = new System.Drawing.Point(52, 260);
			this.btnUser.Name = "btnUser";
			this.btnUser.ShadowDecoration.Parent = this.btnUser;
			this.btnUser.Size = new System.Drawing.Size(135, 45);
			this.btnUser.TabIndex = 16;
			this.btnUser.Text = "Tài khoản";
			this.btnUser.TextOffset = new System.Drawing.Point(10, 0);
			this.btnUser.UseTransparentBackground = true;
			this.btnUser.Click += new System.EventHandler(this.BtnUserClick);
			// 
			// btnStatistical
			// 
			this.btnStatistical.BackColor = System.Drawing.Color.Transparent;
			this.btnStatistical.BorderRadius = 5;
			this.btnStatistical.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
			this.btnStatistical.CheckedState.FillColor = System.Drawing.Color.White;
			this.btnStatistical.CheckedState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnStatistical.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(63)))), ((int)(((byte)(148)))));
			this.btnStatistical.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("btnStatistical.CheckedState.Image")));
			this.btnStatistical.CheckedState.Parent = this.btnStatistical;
			this.btnStatistical.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnStatistical.CustomImages.Parent = this.btnStatistical;
			this.btnStatistical.FillColor = System.Drawing.Color.Transparent;
			this.btnStatistical.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnStatistical.ForeColor = System.Drawing.Color.White;
			this.btnStatistical.HoverState.FillColor = System.Drawing.Color.Transparent;
			this.btnStatistical.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnStatistical.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(243)))), ((int)(((byte)(200)))));
			this.btnStatistical.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("btnStatistical.HoverState.Image")));
			this.btnStatistical.HoverState.Parent = this.btnStatistical;
			this.btnStatistical.Image = ((System.Drawing.Image)(resources.GetObject("btnStatistical.Image")));
			this.btnStatistical.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.btnStatistical.Location = new System.Drawing.Point(52, 209);
			this.btnStatistical.Name = "btnStatistical";
			this.btnStatistical.ShadowDecoration.Parent = this.btnStatistical;
			this.btnStatistical.Size = new System.Drawing.Size(135, 45);
			this.btnStatistical.TabIndex = 17;
			this.btnStatistical.Text = "Thống kê";
			this.btnStatistical.TextOffset = new System.Drawing.Point(10, 0);
			this.btnStatistical.UseTransparentBackground = true;
			this.btnStatistical.Click += new System.EventHandler(this.BtnStatisticalClick);
			// 
			// App
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(87)))), ((int)(((byte)(231)))));
			this.ClientSize = new System.Drawing.Size(795, 554);
			this.Controls.Add(this.btnStatistical);
			this.Controls.Add(this.btnUser);
			this.Controls.Add(this.sprVertical);
			this.Controls.Add(this.labAppName);
			this.Controls.Add(this.btnIcon);
			this.Controls.Add(this.labVersion);
			this.Controls.Add(this.btnLogout);
			this.Controls.Add(this.pnlMainView);
			this.Controls.Add(this.btnHelper);
			this.Controls.Add(this.btnFilter);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "App";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "App";
			this.pnlMainView.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
