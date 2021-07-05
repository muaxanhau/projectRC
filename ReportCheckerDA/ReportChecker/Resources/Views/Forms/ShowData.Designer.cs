/*
 * Author: 
 * Created: 
 * Description: 
 */
namespace ReportChecker.Resources.Views.Forms
{
	partial class ShowData
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private Guna.UI2.WinForms.Guna2Panel pnlMainView;
		private Guna.UI2.WinForms.Guna2Button btnAddSub;
		private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
		private Guna.UI2.WinForms.Guna2Button btnCancel;
		private Guna.UI2.WinForms.Guna2DragControl dctForm;
		private System.Windows.Forms.DataGridView dgvMainView;
		private System.Windows.Forms.DataGridViewTextBoxColumn col1;
		private System.Windows.Forms.DataGridViewTextBoxColumn col2;
		private System.Windows.Forms.DataGridViewTextBoxColumn col3;
		private System.Windows.Forms.DataGridViewTextBoxColumn col4;
		private System.Windows.Forms.DataGridViewTextBoxColumn col5;
		private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowData));
			this.pnlMainView = new Guna.UI2.WinForms.Guna2Panel();
			this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
			this.dgvMainView = new System.Windows.Forms.DataGridView();
			this.col1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.col2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.col3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.col4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.col5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.btnAddSub = new Guna.UI2.WinForms.Guna2Button();
			this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
			this.dctForm = new Guna.UI2.WinForms.Guna2DragControl(this.components);
			this.pnlMainView.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvMainView)).BeginInit();
			this.SuspendLayout();
			// 
			// pnlMainView
			// 
			this.pnlMainView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(70)))), ((int)(((byte)(112)))));
			this.pnlMainView.Controls.Add(this.guna2PictureBox1);
			this.pnlMainView.Controls.Add(this.dgvMainView);
			this.pnlMainView.Controls.Add(this.guna2HtmlLabel1);
			this.pnlMainView.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlMainView.Location = new System.Drawing.Point(0, 0);
			this.pnlMainView.Name = "pnlMainView";
			this.pnlMainView.ShadowDecoration.Parent = this.pnlMainView;
			this.pnlMainView.Size = new System.Drawing.Size(426, 310);
			this.pnlMainView.TabIndex = 0;
			// 
			// guna2PictureBox1
			// 
			this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
			this.guna2PictureBox1.Location = new System.Drawing.Point(400, 0);
			this.guna2PictureBox1.Name = "guna2PictureBox1";
			this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
			this.guna2PictureBox1.Size = new System.Drawing.Size(26, 31);
			this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.guna2PictureBox1.TabIndex = 5;
			this.guna2PictureBox1.TabStop = false;
			// 
			// dgvMainView
			// 
			this.dgvMainView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
			this.dgvMainView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvMainView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.col1,
			this.col2,
			this.col3,
			this.col4,
			this.col5});
			this.dgvMainView.Location = new System.Drawing.Point(12, 38);
			this.dgvMainView.Name = "dgvMainView";
			this.dgvMainView.RowHeadersVisible = false;
			this.dgvMainView.Size = new System.Drawing.Size(402, 257);
			this.dgvMainView.TabIndex = 4;
			// 
			// col1
			// 
			this.col1.HeaderText = "STT";
			this.col1.Name = "col1";
			this.col1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.col1.Width = 36;
			// 
			// col2
			// 
			this.col2.HeaderText = "Tên Sản Phẩm";
			this.col2.Name = "col2";
			this.col2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.col2.Width = 150;
			// 
			// col3
			// 
			this.col3.HeaderText = "Màu Sắc";
			this.col3.Name = "col3";
			this.col3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// col4
			// 
			this.col4.HeaderText = "Size";
			this.col4.Name = "col4";
			this.col4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.col4.Width = 60;
			// 
			// col5
			// 
			this.col5.HeaderText = "SL";
			this.col5.Name = "col5";
			this.col5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.col5.Width = 36;
			// 
			// guna2HtmlLabel1
			// 
			this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
			this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(229)))), ((int)(((byte)(243)))));
			this.guna2HtmlLabel1.Location = new System.Drawing.Point(12, 12);
			this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
			this.guna2HtmlLabel1.Size = new System.Drawing.Size(140, 20);
			this.guna2HtmlLabel1.TabIndex = 3;
			this.guna2HtmlLabel1.Text = "Kết quả xem trước";
			// 
			// btnAddSub
			// 
			this.btnAddSub.CheckedState.Parent = this.btnAddSub;
			this.btnAddSub.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 4);
			this.btnAddSub.CustomImages.Parent = this.btnAddSub;
			this.btnAddSub.FillColor = System.Drawing.Color.Transparent;
			this.btnAddSub.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnAddSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(78)))), ((int)(((byte)(89)))));
			this.btnAddSub.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(59)))), ((int)(((byte)(120)))));
			this.btnAddSub.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(63)))), ((int)(((byte)(148)))));
			this.btnAddSub.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddSub.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(243)))), ((int)(((byte)(200)))));
			this.btnAddSub.HoverState.Parent = this.btnAddSub;
			this.btnAddSub.Location = new System.Drawing.Point(196, 316);
			this.btnAddSub.Name = "btnAddSub";
			this.btnAddSub.ShadowDecoration.Parent = this.btnAddSub;
			this.btnAddSub.Size = new System.Drawing.Size(106, 29);
			this.btnAddSub.TabIndex = 2;
			this.btnAddSub.Text = "Thêm";
			this.btnAddSub.Click += new System.EventHandler(this.BtnAddSubClick);
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
			this.btnCancel.Location = new System.Drawing.Point(308, 316);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.ShadowDecoration.Parent = this.btnCancel;
			this.btnCancel.Size = new System.Drawing.Size(106, 29);
			this.btnCancel.TabIndex = 3;
			this.btnCancel.Text = "Bỏ";
			this.btnCancel.Click += new System.EventHandler(this.BtnCancelClick);
			// 
			// dctForm
			// 
			this.dctForm.ContainerControl = this;
			this.dctForm.TargetControl = this.pnlMainView;
			this.dctForm.TransparentWhileDrag = true;
			this.dctForm.UseTransparentDrag = true;
			// 
			// ShowData
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(202)))), ((int)(((byte)(241)))));
			this.ClientSize = new System.Drawing.Size(426, 357);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnAddSub);
			this.Controls.Add(this.pnlMainView);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "ShowData";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "ShowData";
			this.TransparencyKey = System.Drawing.Color.Fuchsia;
			this.pnlMainView.ResumeLayout(false);
			this.pnlMainView.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvMainView)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
