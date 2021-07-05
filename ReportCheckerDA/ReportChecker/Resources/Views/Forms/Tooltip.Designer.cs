/*
 * Author: 
 * Created: 
 * Description: 
 */
namespace ReportChecker.Resources.Views.Forms
{
	partial class Tooltip
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label labMessage;
		private System.Windows.Forms.Panel panel1;
		private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
		private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tooltip));
			this.labMessage = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
			this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
			this.guna2Panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// labMessage
			// 
			this.labMessage.BackColor = System.Drawing.Color.Transparent;
			this.labMessage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(243)))), ((int)(((byte)(200)))));
			this.labMessage.Location = new System.Drawing.Point(0, 0);
			this.labMessage.Name = "labMessage";
			this.labMessage.Padding = new System.Windows.Forms.Padding(3);
			this.labMessage.Size = new System.Drawing.Size(130, 23);
			this.labMessage.TabIndex = 0;
			this.labMessage.Text = "TItle...!";
			this.labMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Fuchsia;
			this.panel1.Controls.Add(this.guna2PictureBox1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(130, 7);
			this.panel1.TabIndex = 1;
			// 
			// guna2PictureBox1
			// 
			this.guna2PictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
			this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
			this.guna2PictureBox1.Location = new System.Drawing.Point(0, 0);
			this.guna2PictureBox1.Name = "guna2PictureBox1";
			this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
			this.guna2PictureBox1.Size = new System.Drawing.Size(14, 7);
			this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.guna2PictureBox1.TabIndex = 0;
			this.guna2PictureBox1.TabStop = false;
			// 
			// guna2Panel1
			// 
			this.guna2Panel1.Controls.Add(this.labMessage);
			this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.guna2Panel1.Location = new System.Drawing.Point(0, 7);
			this.guna2Panel1.Name = "guna2Panel1";
			this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
			this.guna2Panel1.Size = new System.Drawing.Size(130, 23);
			this.guna2Panel1.TabIndex = 2;
			// 
			// Note
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(63)))), ((int)(((byte)(148)))));
			this.ClientSize = new System.Drawing.Size(130, 30);
			this.Controls.Add(this.guna2Panel1);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Note";
			this.ShowInTaskbar = false;
			this.Text = "Note";
			this.TransparencyKey = System.Drawing.Color.Fuchsia;
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
			this.guna2Panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
