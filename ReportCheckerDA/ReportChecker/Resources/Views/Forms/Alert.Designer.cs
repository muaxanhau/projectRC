/*
 * Author: 
 * Created: 
 * Description: 
 */
namespace ReportChecker.Resources.Views.Forms
{
	partial class Alert
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
		private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
		private Guna.UI2.WinForms.Guna2ImageButton btnClose;
		private System.Windows.Forms.Label labMessage;
		private System.Windows.Forms.Timer tmrMain;
		private Guna.UI2.WinForms.Guna2Panel pnlMain;
		private System.Windows.Forms.Label label1;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alert));
			this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
			this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
			this.btnClose = new Guna.UI2.WinForms.Guna2ImageButton();
			this.labMessage = new System.Windows.Forms.Label();
			this.tmrMain = new System.Windows.Forms.Timer(this.components);
			this.pnlMain = new Guna.UI2.WinForms.Guna2Panel();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// guna2PictureBox1
			// 
			this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
			this.guna2PictureBox1.Location = new System.Drawing.Point(269, 0);
			this.guna2PictureBox1.Name = "guna2PictureBox1";
			this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
			this.guna2PictureBox1.Size = new System.Drawing.Size(26, 31);
			this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.guna2PictureBox1.TabIndex = 1;
			this.guna2PictureBox1.TabStop = false;
			// 
			// guna2PictureBox2
			// 
			this.guna2PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox2.Image")));
			this.guna2PictureBox2.Location = new System.Drawing.Point(12, 17);
			this.guna2PictureBox2.Name = "guna2PictureBox2";
			this.guna2PictureBox2.ShadowDecoration.Parent = this.guna2PictureBox2;
			this.guna2PictureBox2.Size = new System.Drawing.Size(35, 35);
			this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.guna2PictureBox2.TabIndex = 2;
			this.guna2PictureBox2.TabStop = false;
			// 
			// btnClose
			// 
			this.btnClose.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
			this.btnClose.CheckedState.Parent = this.btnClose;
			this.btnClose.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.HoverState.Image")));
			this.btnClose.HoverState.ImageSize = new System.Drawing.Size(22, 22);
			this.btnClose.HoverState.Parent = this.btnClose;
			this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
			this.btnClose.ImageRotate = 0F;
			this.btnClose.ImageSize = new System.Drawing.Size(22, 22);
			this.btnClose.Location = new System.Drawing.Point(259, 24);
			this.btnClose.Name = "btnClose";
			this.btnClose.PressedState.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.PressedState.Image")));
			this.btnClose.PressedState.ImageSize = new System.Drawing.Size(22, 22);
			this.btnClose.PressedState.Parent = this.btnClose;
			this.btnClose.Size = new System.Drawing.Size(22, 22);
			this.btnClose.TabIndex = 4;
			this.btnClose.Visible = false;
			this.btnClose.Click += new System.EventHandler(this.BtnCloseClick);
			// 
			// labMessage
			// 
			this.labMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labMessage.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.labMessage.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.labMessage.Location = new System.Drawing.Point(53, 17);
			this.labMessage.Name = "labMessage";
			this.labMessage.Size = new System.Drawing.Size(200, 19);
			this.labMessage.TabIndex = 5;
			this.labMessage.Text = "Title... !";
			this.labMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tmrMain
			// 
			this.tmrMain.Tick += new System.EventHandler(this.TmrMainTick);
			// 
			// pnlMain
			// 
			this.pnlMain.BackColor = System.Drawing.Color.Transparent;
			this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlMain.Location = new System.Drawing.Point(0, 0);
			this.pnlMain.Name = "pnlMain";
			this.pnlMain.ShadowDecoration.Parent = this.pnlMain;
			this.pnlMain.Size = new System.Drawing.Size(293, 68);
			this.pnlMain.TabIndex = 6;
			this.pnlMain.UseTransparentBackground = true;
			this.pnlMain.Click += new System.EventHandler(this.PnlMainClick);
			this.pnlMain.MouseLeave += new System.EventHandler(this.PnlMainMouseLeave);
			this.pnlMain.MouseHover += new System.EventHandler(this.PnlMainMouseHover);
			// 
			// label1
			// 
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(202)))), ((int)(((byte)(241)))));
			this.label1.Location = new System.Drawing.Point(53, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(200, 16);
			this.label1.TabIndex = 7;
			this.label1.Text = "Nhấp vào để xem";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Alert
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(63)))), ((int)(((byte)(148)))));
			this.ClientSize = new System.Drawing.Size(293, 68);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.pnlMain);
			this.Controls.Add(this.labMessage);
			this.Controls.Add(this.guna2PictureBox2);
			this.Controls.Add(this.guna2PictureBox1);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Alert";
			this.ShowInTaskbar = false;
			this.Text = "Alert";
			this.TopMost = true;
			this.TransparencyKey = System.Drawing.Color.Fuchsia;
			((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
