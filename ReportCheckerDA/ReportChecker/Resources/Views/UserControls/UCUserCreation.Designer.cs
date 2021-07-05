/*
 * Author: 
 * Created: 
 * Description: 
 */
namespace ReportChecker.Resources.Views.UserControls
{
	partial class UCUserCreation
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private Guna.UI2.WinForms.Guna2TextBox txbPassword;
		private Guna.UI2.WinForms.Guna2TextBox txbUsername;
		private Guna.UI2.WinForms.Guna2Button btnCreate;
		private Guna.UI2.WinForms.Guna2ProgressIndicator proLoading;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCUserCreation));
			this.txbPassword = new Guna.UI2.WinForms.Guna2TextBox();
			this.txbUsername = new Guna.UI2.WinForms.Guna2TextBox();
			this.btnCreate = new Guna.UI2.WinForms.Guna2Button();
			this.proLoading = new Guna.UI2.WinForms.Guna2ProgressIndicator();
			this.SuspendLayout();
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
			this.txbPassword.Location = new System.Drawing.Point(179, 177);
			this.txbPassword.Margin = new System.Windows.Forms.Padding(4);
			this.txbPassword.Name = "txbPassword";
			this.txbPassword.PasswordChar = '\0';
			this.txbPassword.PlaceholderText = "Mật khẩu";
			this.txbPassword.SelectedText = "";
			this.txbPassword.ShadowDecoration.Parent = this.txbPassword;
			this.txbPassword.Size = new System.Drawing.Size(193, 38);
			this.txbPassword.TabIndex = 1;
			this.txbPassword.UseSystemPasswordChar = true;
			// 
			// txbUsername
			// 
			this.txbUsername.AcceptsReturn = true;
			this.txbUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txbUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txbUsername.DefaultText = "";
			this.txbUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txbUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txbUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txbUsername.DisabledState.Parent = this.txbUsername;
			this.txbUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txbUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txbUsername.FocusedState.Parent = this.txbUsername;
			this.txbUsername.Font = new System.Drawing.Font("Century Gothic", 9.75F);
			this.txbUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txbUsername.HoverState.Parent = this.txbUsername;
			this.txbUsername.IconLeft = ((System.Drawing.Image)(resources.GetObject("txbUsername.IconLeft")));
			this.txbUsername.Location = new System.Drawing.Point(179, 131);
			this.txbUsername.Margin = new System.Windows.Forms.Padding(4);
			this.txbUsername.Name = "txbUsername";
			this.txbUsername.PasswordChar = '\0';
			this.txbUsername.PlaceholderText = "Tên tài khoản";
			this.txbUsername.SelectedText = "";
			this.txbUsername.ShadowDecoration.Parent = this.txbUsername;
			this.txbUsername.Size = new System.Drawing.Size(193, 38);
			this.txbUsername.TabIndex = 0;
			// 
			// btnCreate
			// 
			this.btnCreate.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnCreate.CheckedState.Parent = this.btnCreate;
			this.btnCreate.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 4);
			this.btnCreate.CustomImages.Parent = this.btnCreate;
			this.btnCreate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(229)))), ((int)(((byte)(243)))));
			this.btnCreate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCreate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(70)))), ((int)(((byte)(112)))));
			this.btnCreate.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(59)))), ((int)(((byte)(120)))));
			this.btnCreate.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(87)))), ((int)(((byte)(231)))));
			this.btnCreate.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(243)))), ((int)(((byte)(200)))));
			this.btnCreate.HoverState.Parent = this.btnCreate;
			this.btnCreate.Location = new System.Drawing.Point(225, 222);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.ShadowDecoration.Parent = this.btnCreate;
			this.btnCreate.Size = new System.Drawing.Size(102, 37);
			this.btnCreate.TabIndex = 2;
			this.btnCreate.Text = "Tạo";
			this.btnCreate.Click += new System.EventHandler(this.BtnCreateClick);
			// 
			// proLoading
			// 
			this.proLoading.CircleSize = 1F;
			this.proLoading.Location = new System.Drawing.Point(259, 94);
			this.proLoading.Name = "proLoading";
			this.proLoading.Size = new System.Drawing.Size(30, 30);
			this.proLoading.TabIndex = 26;
			this.proLoading.Visible = false;
			// 
			// UCUserCreation
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.proLoading);
			this.Controls.Add(this.btnCreate);
			this.Controls.Add(this.txbUsername);
			this.Controls.Add(this.txbPassword);
			this.Name = "UCUserCreation";
			this.Size = new System.Drawing.Size(558, 392);
			this.ResumeLayout(false);

		}
	}
}
