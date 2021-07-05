/*
 * Author: 
 * Created: 
 * Description: 
 */
namespace ReportChecker.Resources.Views.Forms
{
	partial class Confirm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private Guna.UI2.WinForms.Guna2Panel pnlTitle;
		private Guna.UI2.WinForms.Guna2HtmlLabel labTitle;
		private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
		private Guna.UI2.WinForms.Guna2Button btnOk;
		private Guna.UI2.WinForms.Guna2Button btnCancel;
		private Guna.UI2.WinForms.Guna2DragControl drcConfirm;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Confirm));
			this.pnlTitle = new Guna.UI2.WinForms.Guna2Panel();
			this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
			this.labTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.btnOk = new Guna.UI2.WinForms.Guna2Button();
			this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
			this.drcConfirm = new Guna.UI2.WinForms.Guna2DragControl(this.components);
			this.pnlTitle.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pnlTitle
			// 
			this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(70)))), ((int)(((byte)(112)))));
			this.pnlTitle.Controls.Add(this.guna2PictureBox1);
			this.pnlTitle.Controls.Add(this.labTitle);
			this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlTitle.Location = new System.Drawing.Point(0, 0);
			this.pnlTitle.Name = "pnlTitle";
			this.pnlTitle.ShadowDecoration.Parent = this.pnlTitle;
			this.pnlTitle.Size = new System.Drawing.Size(477, 66);
			this.pnlTitle.TabIndex = 0;
			// 
			// guna2PictureBox1
			// 
			this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
			this.guna2PictureBox1.Location = new System.Drawing.Point(451, 0);
			this.guna2PictureBox1.Name = "guna2PictureBox1";
			this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
			this.guna2PictureBox1.Size = new System.Drawing.Size(26, 31);
			this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.guna2PictureBox1.TabIndex = 2;
			this.guna2PictureBox1.TabStop = false;
			// 
			// labTitle
			// 
			this.labTitle.BackColor = System.Drawing.Color.Transparent;
			this.labTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(229)))), ((int)(((byte)(243)))));
			this.labTitle.Location = new System.Drawing.Point(15, 24);
			this.labTitle.Name = "labTitle";
			this.labTitle.Size = new System.Drawing.Size(104, 20);
			this.labTitle.TabIndex = 1;
			this.labTitle.Text = "Title ........... !";
			// 
			// btnOk
			// 
			this.btnOk.CheckedState.Parent = this.btnOk;
			this.btnOk.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 4);
			this.btnOk.CustomImages.Parent = this.btnOk;
			this.btnOk.FillColor = System.Drawing.Color.Transparent;
			this.btnOk.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnOk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(78)))), ((int)(((byte)(89)))));
			this.btnOk.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(59)))), ((int)(((byte)(120)))));
			this.btnOk.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(63)))), ((int)(((byte)(148)))));
			this.btnOk.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOk.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(243)))), ((int)(((byte)(200)))));
			this.btnOk.HoverState.Parent = this.btnOk;
			this.btnOk.Location = new System.Drawing.Point(247, 72);
			this.btnOk.Name = "btnOk";
			this.btnOk.ShadowDecoration.Parent = this.btnOk;
			this.btnOk.Size = new System.Drawing.Size(106, 29);
			this.btnOk.TabIndex = 1;
			this.btnOk.Text = "Đồng ý";
			this.btnOk.Click += new System.EventHandler(this.BtnOkClick);
			// 
			// btnCancel
			// 
			this.btnCancel.CheckedState.Parent = this.btnCancel;
			this.btnCancel.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 4);
			this.btnCancel.CustomImages.Parent = this.btnCancel;
			this.btnCancel.FillColor = System.Drawing.Color.Transparent;
			this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(78)))), ((int)(((byte)(89)))));
			this.btnCancel.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(59)))), ((int)(((byte)(120)))));
			this.btnCancel.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(63)))), ((int)(((byte)(148)))));
			this.btnCancel.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancel.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(243)))), ((int)(((byte)(200)))));
			this.btnCancel.HoverState.Parent = this.btnCancel;
			this.btnCancel.Location = new System.Drawing.Point(359, 72);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.ShadowDecoration.Parent = this.btnCancel;
			this.btnCancel.Size = new System.Drawing.Size(106, 29);
			this.btnCancel.TabIndex = 2;
			this.btnCancel.Text = "Hủy bỏ";
			this.btnCancel.Click += new System.EventHandler(this.BtnCancelClick);
			// 
			// drcConfirm
			// 
			this.drcConfirm.ContainerControl = this;
			this.drcConfirm.TargetControl = this.pnlTitle;
			this.drcConfirm.TransparentWhileDrag = true;
			this.drcConfirm.UseTransparentDrag = true;
			// 
			// Confirm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(202)))), ((int)(((byte)(241)))));
			this.ClientSize = new System.Drawing.Size(477, 113);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOk);
			this.Controls.Add(this.pnlTitle);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Confirm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Confirm";
			this.TransparencyKey = System.Drawing.Color.Fuchsia;
			this.pnlTitle.ResumeLayout(false);
			this.pnlTitle.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
