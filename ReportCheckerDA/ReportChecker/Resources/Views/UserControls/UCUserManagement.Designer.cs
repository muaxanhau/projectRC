/*
 * Author: 
 * Created: 
 * Description: 
 */
namespace ReportChecker.Resources.Views.UserControls
{
	partial class UCUserManagement
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private Guna.UI2.WinForms.Guna2Button btnManagement;
		private Guna.UI2.WinForms.Guna2Button btnCreation;
		
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
			this.btnManagement = new Guna.UI2.WinForms.Guna2Button();
			this.btnCreation = new Guna.UI2.WinForms.Guna2Button();
			this.SuspendLayout();
			// 
			// btnManagement
			// 
			this.btnManagement.BackColor = System.Drawing.SystemColors.Control;
			this.btnManagement.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
			this.btnManagement.Checked = true;
			this.btnManagement.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(59)))), ((int)(((byte)(120)))));
			this.btnManagement.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(63)))), ((int)(((byte)(148)))));
			this.btnManagement.CheckedState.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.btnManagement.CheckedState.Parent = this.btnManagement;
			this.btnManagement.CustomBorderColor = System.Drawing.Color.Transparent;
			this.btnManagement.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 4);
			this.btnManagement.CustomImages.Parent = this.btnManagement;
			this.btnManagement.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(229)))), ((int)(((byte)(243)))));
			this.btnManagement.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnManagement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(70)))), ((int)(((byte)(112)))));
			this.btnManagement.HoverState.BorderColor = System.Drawing.Color.Transparent;
			this.btnManagement.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(59)))), ((int)(((byte)(120)))));
			this.btnManagement.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(87)))), ((int)(((byte)(231)))));
			this.btnManagement.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(243)))), ((int)(((byte)(200)))));
			this.btnManagement.HoverState.Parent = this.btnManagement;
			this.btnManagement.Location = new System.Drawing.Point(21, 23);
			this.btnManagement.Name = "btnManagement";
			this.btnManagement.ShadowDecoration.Parent = this.btnManagement;
			this.btnManagement.Size = new System.Drawing.Size(83, 29);
			this.btnManagement.TabIndex = 0;
			this.btnManagement.Text = "tất cả";
			this.btnManagement.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
			this.btnManagement.Click += new System.EventHandler(this.BtnManagementClick);
			// 
			// btnCreation
			// 
			this.btnCreation.BackColor = System.Drawing.SystemColors.Control;
			this.btnCreation.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
			this.btnCreation.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(59)))), ((int)(((byte)(120)))));
			this.btnCreation.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(63)))), ((int)(((byte)(148)))));
			this.btnCreation.CheckedState.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.btnCreation.CheckedState.Parent = this.btnCreation;
			this.btnCreation.CustomBorderColor = System.Drawing.Color.Transparent;
			this.btnCreation.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 4);
			this.btnCreation.CustomImages.Parent = this.btnCreation;
			this.btnCreation.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(229)))), ((int)(((byte)(243)))));
			this.btnCreation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCreation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(70)))), ((int)(((byte)(112)))));
			this.btnCreation.HoverState.BorderColor = System.Drawing.Color.Transparent;
			this.btnCreation.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(59)))), ((int)(((byte)(120)))));
			this.btnCreation.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(87)))), ((int)(((byte)(231)))));
			this.btnCreation.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(243)))), ((int)(((byte)(200)))));
			this.btnCreation.HoverState.Parent = this.btnCreation;
			this.btnCreation.Location = new System.Drawing.Point(104, 23);
			this.btnCreation.Name = "btnCreation";
			this.btnCreation.ShadowDecoration.Parent = this.btnCreation;
			this.btnCreation.Size = new System.Drawing.Size(83, 29);
			this.btnCreation.TabIndex = 1;
			this.btnCreation.Text = "tạo mới";
			this.btnCreation.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
			this.btnCreation.Click += new System.EventHandler(this.BtnCreationClick);
			// 
			// UCUserManagement
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.btnCreation);
			this.Controls.Add(this.btnManagement);
			this.Name = "UCUserManagement";
			this.Size = new System.Drawing.Size(601, 490);
			this.ResumeLayout(false);

		}
	}
}
