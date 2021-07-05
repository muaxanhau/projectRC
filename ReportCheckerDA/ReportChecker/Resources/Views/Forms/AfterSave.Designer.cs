/*
 * Author: 
 * Created: 
 * Description: 
 */
namespace ReportChecker.Resources.Views.Forms
{
	partial class AfterSave
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private Guna.UI2.WinForms.Guna2Panel pnlMainView;
		private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
		private Guna.UI2.WinForms.Guna2HtmlLabel labTitle;
		private Guna.UI2.WinForms.Guna2Button btnCancel;
		private Guna.UI2.WinForms.Guna2Button btnOpen;
		private Guna.UI2.WinForms.Guna2DragControl dctForm;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AfterSave));
			this.pnlMainView = new Guna.UI2.WinForms.Guna2Panel();
			this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
			this.labTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
			this.btnOpen = new Guna.UI2.WinForms.Guna2Button();
			this.dctForm = new Guna.UI2.WinForms.Guna2DragControl(this.components);
			this.pnlMainView.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pnlMainView
			// 
			this.pnlMainView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(70)))), ((int)(((byte)(112)))));
			this.pnlMainView.Controls.Add(this.guna2PictureBox1);
			this.pnlMainView.Controls.Add(this.labTitle);
			this.pnlMainView.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlMainView.Location = new System.Drawing.Point(0, 0);
			this.pnlMainView.Name = "pnlMainView";
			this.pnlMainView.ShadowDecoration.Parent = this.pnlMainView;
			this.pnlMainView.Size = new System.Drawing.Size(477, 66);
			this.pnlMainView.TabIndex = 0;
			// 
			// guna2PictureBox1
			// 
			this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
			this.guna2PictureBox1.Location = new System.Drawing.Point(451, 0);
			this.guna2PictureBox1.Name = "guna2PictureBox1";
			this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
			this.guna2PictureBox1.Size = new System.Drawing.Size(26, 31);
			this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.guna2PictureBox1.TabIndex = 3;
			this.guna2PictureBox1.TabStop = false;
			// 
			// labTitle
			// 
			this.labTitle.BackColor = System.Drawing.Color.Transparent;
			this.labTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(229)))), ((int)(((byte)(243)))));
			this.labTitle.Location = new System.Drawing.Point(12, 25);
			this.labTitle.Name = "labTitle";
			this.labTitle.Size = new System.Drawing.Size(445, 20);
			this.labTitle.TabIndex = 2;
			this.labTitle.Text = "Tạo Excel thành công, bạn có muốn mở thư mục chứa file?";
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
			this.btnCancel.TabIndex = 12;
			this.btnCancel.Text = "Đóng";
			this.btnCancel.Click += new System.EventHandler(this.BtnCancelClick);
			// 
			// btnOpen
			// 
			this.btnOpen.CheckedState.Parent = this.btnOpen;
			this.btnOpen.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 4);
			this.btnOpen.CustomImages.Parent = this.btnOpen;
			this.btnOpen.FillColor = System.Drawing.Color.Transparent;
			this.btnOpen.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnOpen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(78)))), ((int)(((byte)(89)))));
			this.btnOpen.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(59)))), ((int)(((byte)(120)))));
			this.btnOpen.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(63)))), ((int)(((byte)(148)))));
			this.btnOpen.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOpen.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(243)))), ((int)(((byte)(200)))));
			this.btnOpen.HoverState.Parent = this.btnOpen;
			this.btnOpen.Location = new System.Drawing.Point(247, 72);
			this.btnOpen.Name = "btnOpen";
			this.btnOpen.ShadowDecoration.Parent = this.btnOpen;
			this.btnOpen.Size = new System.Drawing.Size(106, 29);
			this.btnOpen.TabIndex = 11;
			this.btnOpen.Text = "Mở thư mục";
			this.btnOpen.Click += new System.EventHandler(this.BtnOpenClick);
			// 
			// dctForm
			// 
			this.dctForm.ContainerControl = this;
			this.dctForm.TargetControl = this.pnlMainView;
			this.dctForm.TransparentWhileDrag = true;
			this.dctForm.UseTransparentDrag = true;
			// 
			// AfterSave
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(477, 113);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOpen);
			this.Controls.Add(this.pnlMainView);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "AfterSave";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AfterSave";
			this.TransparencyKey = System.Drawing.Color.Fuchsia;
			this.pnlMainView.ResumeLayout(false);
			this.pnlMainView.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
