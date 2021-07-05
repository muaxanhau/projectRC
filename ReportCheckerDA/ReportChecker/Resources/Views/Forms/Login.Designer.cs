/*
 * Author: 
 * Created: 
 * Description: 
 */
namespace ReportChecker.Resources.Views.Forms
{
	partial class Login
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private Guna.UI2.WinForms.Guna2DragControl drcLogin;
		private Guna.UI2.WinForms.Guna2Elipse eclLogin;
		private Guna.UI2.WinForms.Guna2Panel pnlMain;
		private Guna.UI2.WinForms.Guna2Elipse eclMainPanel;
		private Guna.UI2.WinForms.Guna2HtmlLabel labAppName;
		private Guna.UI2.WinForms.Guna2PictureBox ptbLogo;
		private Guna.UI2.WinForms.Guna2ImageButton btnMinimize;
		private Guna.UI2.WinForms.Guna2ImageButton btnExit;
		private Guna.UI2.WinForms.Guna2HtmlLabel labLogin;
		private Guna.UI2.WinForms.Guna2TextBox txbPassword;
		private Guna.UI2.WinForms.Guna2Button btnLogin;
		private Guna.UI2.WinForms.Guna2HtmlLabel labAdmin;
		private Guna.UI2.WinForms.Guna2ProgressIndicator proLoading;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
			this.drcLogin = new Guna.UI2.WinForms.Guna2DragControl(this.components);
			this.eclLogin = new Guna.UI2.WinForms.Guna2Elipse(this.components);
			this.pnlMain = new Guna.UI2.WinForms.Guna2Panel();
			this.proLoading = new Guna.UI2.WinForms.Guna2ProgressIndicator();
			this.labAdmin = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
			this.txbPassword = new Guna.UI2.WinForms.Guna2TextBox();
			this.labLogin = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.btnMinimize = new Guna.UI2.WinForms.Guna2ImageButton();
			this.btnExit = new Guna.UI2.WinForms.Guna2ImageButton();
			this.eclMainPanel = new Guna.UI2.WinForms.Guna2Elipse(this.components);
			this.labAppName = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.ptbLogo = new Guna.UI2.WinForms.Guna2PictureBox();
			this.pnlMain.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).BeginInit();
			this.SuspendLayout();
			// 
			// drcLogin
			// 
			this.drcLogin.ContainerControl = this;
			this.drcLogin.TargetControl = this;
			this.drcLogin.TransparentWhileDrag = true;
			this.drcLogin.UseTransparentDrag = true;
			// 
			// eclLogin
			// 
			this.eclLogin.BorderRadius = 10;
			this.eclLogin.TargetControl = this;
			// 
			// pnlMain
			// 
			this.pnlMain.BackColor = System.Drawing.Color.White;
			this.pnlMain.Controls.Add(this.proLoading);
			this.pnlMain.Controls.Add(this.labAdmin);
			this.pnlMain.Controls.Add(this.btnLogin);
			this.pnlMain.Controls.Add(this.txbPassword);
			this.pnlMain.Controls.Add(this.labLogin);
			this.pnlMain.Controls.Add(this.btnMinimize);
			this.pnlMain.Controls.Add(this.btnExit);
			this.pnlMain.Location = new System.Drawing.Point(262, 12);
			this.pnlMain.Name = "pnlMain";
			this.pnlMain.ShadowDecoration.Parent = this.pnlMain;
			this.pnlMain.Size = new System.Drawing.Size(284, 334);
			this.pnlMain.TabIndex = 0;
			// 
			// proLoading
			// 
			this.proLoading.CircleSize = 1F;
			this.proLoading.Location = new System.Drawing.Point(129, 198);
			this.proLoading.Name = "proLoading";
			this.proLoading.Size = new System.Drawing.Size(30, 30);
			this.proLoading.TabIndex = 9;
			this.proLoading.Visible = false;
			// 
			// labAdmin
			// 
			this.labAdmin.BackColor = System.Drawing.Color.Transparent;
			this.labAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(70)))), ((int)(((byte)(112)))));
			this.labAdmin.Location = new System.Drawing.Point(82, 120);
			this.labAdmin.Name = "labAdmin";
			this.labAdmin.Size = new System.Drawing.Size(122, 26);
			this.labAdmin.TabIndex = 7;
			this.labAdmin.Text = "Quản trị viên";
			// 
			// btnLogin
			// 
			this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnLogin.CheckedState.Parent = this.btnLogin;
			this.btnLogin.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 4);
			this.btnLogin.CustomImages.Parent = this.btnLogin;
			this.btnLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(229)))), ((int)(((byte)(243)))));
			this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(70)))), ((int)(((byte)(112)))));
			this.btnLogin.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(59)))), ((int)(((byte)(120)))));
			this.btnLogin.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(87)))), ((int)(((byte)(231)))));
			this.btnLogin.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(243)))), ((int)(((byte)(200)))));
			this.btnLogin.HoverState.Parent = this.btnLogin;
			this.btnLogin.Location = new System.Drawing.Point(92, 234);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.ShadowDecoration.Parent = this.btnLogin;
			this.btnLogin.Size = new System.Drawing.Size(102, 37);
			this.btnLogin.TabIndex = 6;
			this.btnLogin.Text = "Đăng nhập";
			this.btnLogin.Click += new System.EventHandler(this.BtnLoginClick);
			// 
			// txbPassword
			// 
			this.txbPassword.AcceptsReturn = true;
			this.txbPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txbPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txbPassword.DefaultText = "";
			this.txbPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txbPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txbPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txbPassword.DisabledState.Parent = this.txbPassword;
			this.txbPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txbPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txbPassword.FocusedState.Parent = this.txbPassword;
			this.txbPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txbPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txbPassword.HoverState.Parent = this.txbPassword;
			this.txbPassword.IconLeft = ((System.Drawing.Image)(resources.GetObject("txbPassword.IconLeft")));
			this.txbPassword.Location = new System.Drawing.Point(47, 153);
			this.txbPassword.Margin = new System.Windows.Forms.Padding(4);
			this.txbPassword.Name = "txbPassword";
			this.txbPassword.PasswordChar = '\0';
			this.txbPassword.PlaceholderText = "Mật khẩu";
			this.txbPassword.SelectedText = "";
			this.txbPassword.ShadowDecoration.Parent = this.txbPassword;
			this.txbPassword.Size = new System.Drawing.Size(193, 38);
			this.txbPassword.TabIndex = 5;
			this.txbPassword.UseSystemPasswordChar = true;
			// 
			// labLogin
			// 
			this.labLogin.BackColor = System.Drawing.Color.Transparent;
			this.labLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(63)))), ((int)(((byte)(148)))));
			this.labLogin.Location = new System.Drawing.Point(72, 34);
			this.labLogin.Name = "labLogin";
			this.labLogin.Size = new System.Drawing.Size(144, 33);
			this.labLogin.TabIndex = 3;
			this.labLogin.Text = "Đăng nhập";
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
			this.btnMinimize.Location = new System.Drawing.Point(231, 3);
			this.btnMinimize.Name = "btnMinimize";
			this.btnMinimize.PressedState.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.PressedState.Image")));
			this.btnMinimize.PressedState.ImageSize = new System.Drawing.Size(17, 17);
			this.btnMinimize.PressedState.Parent = this.btnMinimize;
			this.btnMinimize.Size = new System.Drawing.Size(22, 22);
			this.btnMinimize.TabIndex = 3;
			this.btnMinimize.UseTransparentBackground = true;
			this.btnMinimize.Click += new System.EventHandler(this.BtnMinimizeClick);
			// 
			// btnExit
			// 
			this.btnExit.BackColor = System.Drawing.Color.Transparent;
			this.btnExit.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
			this.btnExit.CheckedState.Parent = this.btnExit;
			this.btnExit.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.HoverState.Image")));
			this.btnExit.HoverState.ImageSize = new System.Drawing.Size(22, 22);
			this.btnExit.HoverState.Parent = this.btnExit;
			this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
			this.btnExit.ImageRotate = 0F;
			this.btnExit.ImageSize = new System.Drawing.Size(22, 22);
			this.btnExit.Location = new System.Drawing.Point(259, 3);
			this.btnExit.Name = "btnExit";
			this.btnExit.PressedState.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.PressedState.Image")));
			this.btnExit.PressedState.ImageSize = new System.Drawing.Size(17, 17);
			this.btnExit.PressedState.Parent = this.btnExit;
			this.btnExit.Size = new System.Drawing.Size(22, 22);
			this.btnExit.TabIndex = 2;
			this.btnExit.UseTransparentBackground = true;
			this.btnExit.Click += new System.EventHandler(this.BtnExitClick);
			// 
			// eclMainPanel
			// 
			this.eclMainPanel.BorderRadius = 10;
			this.eclMainPanel.TargetControl = this.pnlMain;
			// 
			// labAppName
			// 
			this.labAppName.BackColor = System.Drawing.Color.Transparent;
			this.labAppName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labAppName.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.labAppName.Location = new System.Drawing.Point(61, 12);
			this.labAppName.Name = "labAppName";
			this.labAppName.Size = new System.Drawing.Size(143, 26);
			this.labAppName.TabIndex = 1;
			this.labAppName.Text = "ReportChecker";
			// 
			// ptbLogo
			// 
			this.ptbLogo.Image = ((System.Drawing.Image)(resources.GetObject("ptbLogo.Image")));
			this.ptbLogo.Location = new System.Drawing.Point(61, 101);
			this.ptbLogo.Name = "ptbLogo";
			this.ptbLogo.ShadowDecoration.Parent = this.ptbLogo;
			this.ptbLogo.Size = new System.Drawing.Size(143, 136);
			this.ptbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.ptbLogo.TabIndex = 2;
			this.ptbLogo.TabStop = false;
			// 
			// Login
			// 
			this.AcceptButton = this.btnLogin;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(87)))), ((int)(((byte)(231)))));
			this.ClientSize = new System.Drawing.Size(558, 358);
			this.Controls.Add(this.ptbLogo);
			this.Controls.Add(this.labAppName);
			this.Controls.Add(this.pnlMain);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Login";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login";
			this.pnlMain.ResumeLayout(false);
			this.pnlMain.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
