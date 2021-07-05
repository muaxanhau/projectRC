/*
 * Author: 
 * Created: 
 * Description: 
 */
namespace ReportChecker.Resources.Views.UserControls
{
	partial class UCUserItem
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private Guna.UI2.WinForms.Guna2Button btnRemove;
		private Guna.UI2.WinForms.Guna2HtmlLabel labUsername;
		private Guna.UI2.WinForms.Guna2HtmlLabel labPassword;
		private Guna.UI2.WinForms.Guna2ProgressIndicator proLoading;
		private Guna.UI2.WinForms.Guna2HtmlLabel labLabelUsername;
		private Guna.UI2.WinForms.Guna2HtmlLabel labLabelPassword;
		
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
			this.labUsername = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.labPassword = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.btnRemove = new Guna.UI2.WinForms.Guna2Button();
			this.proLoading = new Guna.UI2.WinForms.Guna2ProgressIndicator();
			this.labLabelUsername = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.labLabelPassword = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.SuspendLayout();
			// 
			// labUsername
			// 
			this.labUsername.BackColor = System.Drawing.Color.Transparent;
			this.labUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
			this.labUsername.Location = new System.Drawing.Point(119, 30);
			this.labUsername.Name = "labUsername";
			this.labUsername.Size = new System.Drawing.Size(71, 18);
			this.labUsername.TabIndex = 0;
			this.labUsername.Text = "username";
			// 
			// labPassword
			// 
			this.labPassword.BackColor = System.Drawing.Color.Transparent;
			this.labPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
			this.labPassword.Location = new System.Drawing.Point(317, 30);
			this.labPassword.Name = "labPassword";
			this.labPassword.Size = new System.Drawing.Size(56, 17);
			this.labPassword.TabIndex = 1;
			this.labPassword.Text = "password";
			// 
			// btnRemove
			// 
			this.btnRemove.CheckedState.Parent = this.btnRemove;
			this.btnRemove.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 4);
			this.btnRemove.CustomImages.Parent = this.btnRemove;
			this.btnRemove.FillColor = System.Drawing.Color.Transparent;
			this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRemove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(70)))), ((int)(((byte)(112)))));
			this.btnRemove.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(59)))), ((int)(((byte)(120)))));
			this.btnRemove.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(87)))), ((int)(((byte)(231)))));
			this.btnRemove.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(243)))), ((int)(((byte)(200)))));
			this.btnRemove.HoverState.Parent = this.btnRemove;
			this.btnRemove.Location = new System.Drawing.Point(460, 25);
			this.btnRemove.Name = "btnRemove";
			this.btnRemove.ShadowDecoration.Parent = this.btnRemove;
			this.btnRemove.Size = new System.Drawing.Size(55, 30);
			this.btnRemove.TabIndex = 2;
			this.btnRemove.Text = "Xóa";
			this.btnRemove.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
			this.btnRemove.Click += new System.EventHandler(this.BtnRemoveClick);
			// 
			// proLoading
			// 
			this.proLoading.CircleSize = 1F;
			this.proLoading.Location = new System.Drawing.Point(424, 25);
			this.proLoading.Name = "proLoading";
			this.proLoading.Size = new System.Drawing.Size(30, 30);
			this.proLoading.TabIndex = 28;
			this.proLoading.Visible = false;
			// 
			// labLabelUsername
			// 
			this.labLabelUsername.BackColor = System.Drawing.Color.Transparent;
			this.labLabelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labLabelUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(59)))), ((int)(((byte)(120)))));
			this.labLabelUsername.Location = new System.Drawing.Point(12, 30);
			this.labLabelUsername.Name = "labLabelUsername";
			this.labLabelUsername.Size = new System.Drawing.Size(101, 18);
			this.labLabelUsername.TabIndex = 29;
			this.labLabelUsername.Text = "Tên tài khoản:";
			// 
			// labLabelPassword
			// 
			this.labLabelPassword.BackColor = System.Drawing.Color.Transparent;
			this.labLabelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labLabelPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(59)))), ((int)(((byte)(120)))));
			this.labLabelPassword.Location = new System.Drawing.Point(242, 30);
			this.labLabelPassword.Name = "labLabelPassword";
			this.labLabelPassword.Size = new System.Drawing.Size(69, 18);
			this.labLabelPassword.TabIndex = 30;
			this.labLabelPassword.Text = "Mật khẩu:";
			// 
			// UCUserItem
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(229)))), ((int)(((byte)(243)))));
			this.Controls.Add(this.labLabelPassword);
			this.Controls.Add(this.labLabelUsername);
			this.Controls.Add(this.proLoading);
			this.Controls.Add(this.btnRemove);
			this.Controls.Add(this.labPassword);
			this.Controls.Add(this.labUsername);
			this.Name = "UCUserItem";
			this.Size = new System.Drawing.Size(535, 79);
			this.MouseLeave += new System.EventHandler(this.UCUserItemMouseLeave);
			this.MouseHover += new System.EventHandler(this.UCUserItemMouseHover);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
