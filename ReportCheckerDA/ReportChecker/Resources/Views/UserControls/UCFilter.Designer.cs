/*
 * Author: 
 * Created: 
 * Description: 
 */
namespace ReportChecker.Resources.Views.UserControls
{
	partial class UCFilter
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.RichTextBox rtbRawDataInput;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private Guna.UI2.WinForms.Guna2Button btnFilter;
		private Guna.UI2.WinForms.Guna2Button btnClearRawDataInput;
		private System.Windows.Forms.DataGridView dgvMainView;
		private System.Windows.Forms.DataGridViewTextBoxColumn col1;
		private System.Windows.Forms.DataGridViewTextBoxColumn col2;
		private System.Windows.Forms.DataGridViewTextBoxColumn col3;
		private System.Windows.Forms.DataGridViewTextBoxColumn col4;
		private System.Windows.Forms.DataGridViewTextBoxColumn col5;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private Guna.UI2.WinForms.Guna2Button btnClearDataGridView;
		private Guna.UI2.WinForms.Guna2Button btnUndoDataGridView;
		private Guna.UI2.WinForms.Guna2Button btnCreateExcel;
		private Guna.UI2.WinForms.Guna2Button btnOption1;
		private Guna.UI2.WinForms.Guna2Button btnOption2;
		private System.Windows.Forms.Label label4;
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
			this.rtbRawDataInput = new System.Windows.Forms.RichTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btnFilter = new Guna.UI2.WinForms.Guna2Button();
			this.btnClearRawDataInput = new Guna.UI2.WinForms.Guna2Button();
			this.dgvMainView = new System.Windows.Forms.DataGridView();
			this.col1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.col2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.col3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.col4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.col5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.btnClearDataGridView = new Guna.UI2.WinForms.Guna2Button();
			this.btnUndoDataGridView = new Guna.UI2.WinForms.Guna2Button();
			this.btnCreateExcel = new Guna.UI2.WinForms.Guna2Button();
			this.btnOption1 = new Guna.UI2.WinForms.Guna2Button();
			this.label4 = new System.Windows.Forms.Label();
			this.btnOption2 = new Guna.UI2.WinForms.Guna2Button();
			this.proLoading = new Guna.UI2.WinForms.Guna2ProgressIndicator();
			((System.ComponentModel.ISupportInitialize)(this.dgvMainView)).BeginInit();
			this.SuspendLayout();
			// 
			// rtbRawDataInput
			// 
			this.rtbRawDataInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.rtbRawDataInput.Location = new System.Drawing.Point(24, 91);
			this.rtbRawDataInput.Name = "rtbRawDataInput";
			this.rtbRawDataInput.Size = new System.Drawing.Size(138, 207);
			this.rtbRawDataInput.TabIndex = 0;
			this.rtbRawDataInput.Text = "";
			this.rtbRawDataInput.Enter += new System.EventHandler(this.RtbRawDataInputEnter);
			this.rtbRawDataInput.Leave += new System.EventHandler(this.RtbRawDataInputLeave);
			this.rtbRawDataInput.MouseLeave += new System.EventHandler(this.RtbRawDataInputMouseLeave);
			this.rtbRawDataInput.MouseHover += new System.EventHandler(this.RtbRawDataInputMouseHover);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(202)))), ((int)(((byte)(241)))));
			this.label1.Location = new System.Drawing.Point(21, 87);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(145, 1);
			this.label1.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(202)))), ((int)(((byte)(241)))));
			this.label2.Location = new System.Drawing.Point(21, 301);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(145, 1);
			this.label2.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(202)))), ((int)(((byte)(241)))));
			this.label3.Location = new System.Drawing.Point(21, 88);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(1, 213);
			this.label3.TabIndex = 4;
			// 
			// btnFilter
			// 
			this.btnFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(229)))), ((int)(((byte)(243)))));
			this.btnFilter.CheckedState.Parent = this.btnFilter;
			this.btnFilter.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 4);
			this.btnFilter.CustomImages.Parent = this.btnFilter;
			this.btnFilter.FillColor = System.Drawing.Color.Transparent;
			this.btnFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(78)))), ((int)(((byte)(89)))));
			this.btnFilter.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(59)))), ((int)(((byte)(120)))));
			this.btnFilter.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(87)))), ((int)(((byte)(231)))));
			this.btnFilter.HoverState.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFilter.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(243)))), ((int)(((byte)(200)))));
			this.btnFilter.HoverState.Parent = this.btnFilter;
			this.btnFilter.Location = new System.Drawing.Point(21, 305);
			this.btnFilter.Name = "btnFilter";
			this.btnFilter.ShadowDecoration.Parent = this.btnFilter;
			this.btnFilter.Size = new System.Drawing.Size(91, 29);
			this.btnFilter.TabIndex = 6;
			this.btnFilter.Text = "Lọc dữ liệu";
			this.btnFilter.Click += new System.EventHandler(this.BtnFilterClick);
			// 
			// btnClearRawDataInput
			// 
			this.btnClearRawDataInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(229)))), ((int)(((byte)(243)))));
			this.btnClearRawDataInput.CheckedState.Parent = this.btnClearRawDataInput;
			this.btnClearRawDataInput.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 4);
			this.btnClearRawDataInput.CustomImages.Parent = this.btnClearRawDataInput;
			this.btnClearRawDataInput.FillColor = System.Drawing.Color.Transparent;
			this.btnClearRawDataInput.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnClearRawDataInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(78)))), ((int)(((byte)(89)))));
			this.btnClearRawDataInput.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(59)))), ((int)(((byte)(120)))));
			this.btnClearRawDataInput.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(87)))), ((int)(((byte)(231)))));
			this.btnClearRawDataInput.HoverState.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClearRawDataInput.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(243)))), ((int)(((byte)(200)))));
			this.btnClearRawDataInput.HoverState.Parent = this.btnClearRawDataInput;
			this.btnClearRawDataInput.Location = new System.Drawing.Point(118, 305);
			this.btnClearRawDataInput.Name = "btnClearRawDataInput";
			this.btnClearRawDataInput.ShadowDecoration.Parent = this.btnClearRawDataInput;
			this.btnClearRawDataInput.Size = new System.Drawing.Size(48, 29);
			this.btnClearRawDataInput.TabIndex = 7;
			this.btnClearRawDataInput.Text = "Xóa";
			this.btnClearRawDataInput.Click += new System.EventHandler(this.BtnClearRawDataInputClick);
			// 
			// dgvMainView
			// 
			this.dgvMainView.AllowUserToAddRows = false;
			this.dgvMainView.AllowUserToDeleteRows = false;
			this.dgvMainView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
			this.dgvMainView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvMainView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.col1,
			this.col2,
			this.col3,
			this.col4,
			this.col5});
			this.dgvMainView.Location = new System.Drawing.Point(185, 55);
			this.dgvMainView.Name = "dgvMainView";
			this.dgvMainView.ReadOnly = true;
			this.dgvMainView.RowHeadersVisible = false;
			this.dgvMainView.Size = new System.Drawing.Size(402, 247);
			this.dgvMainView.TabIndex = 10;
			// 
			// col1
			// 
			this.col1.HeaderText = "STT";
			this.col1.Name = "col1";
			this.col1.ReadOnly = true;
			this.col1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.col1.Width = 36;
			// 
			// col2
			// 
			this.col2.HeaderText = "Tên Sản Phẩm";
			this.col2.Name = "col2";
			this.col2.ReadOnly = true;
			this.col2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.col2.Width = 150;
			// 
			// col3
			// 
			this.col3.HeaderText = "Màu Sắc";
			this.col3.Name = "col3";
			this.col3.ReadOnly = true;
			this.col3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// col4
			// 
			this.col4.HeaderText = "Size";
			this.col4.Name = "col4";
			this.col4.ReadOnly = true;
			this.col4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.col4.Width = 60;
			// 
			// col5
			// 
			this.col5.HeaderText = "SL";
			this.col5.Name = "col5";
			this.col5.ReadOnly = true;
			this.col5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.col5.Width = 36;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(63)))), ((int)(((byte)(148)))));
			this.label7.Location = new System.Drawing.Point(21, 23);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(145, 23);
			this.label7.TabIndex = 11;
			this.label7.Text = "Dữ liệu thô";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(63)))), ((int)(((byte)(148)))));
			this.label8.Location = new System.Drawing.Point(185, 23);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(402, 23);
			this.label8.TabIndex = 12;
			this.label8.Text = "Bảng tổng kết";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnClearDataGridView
			// 
			this.btnClearDataGridView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(229)))), ((int)(((byte)(243)))));
			this.btnClearDataGridView.CheckedState.Parent = this.btnClearDataGridView;
			this.btnClearDataGridView.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 4);
			this.btnClearDataGridView.CustomImages.Parent = this.btnClearDataGridView;
			this.btnClearDataGridView.FillColor = System.Drawing.Color.Transparent;
			this.btnClearDataGridView.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnClearDataGridView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(78)))), ((int)(((byte)(89)))));
			this.btnClearDataGridView.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(59)))), ((int)(((byte)(120)))));
			this.btnClearDataGridView.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(87)))), ((int)(((byte)(231)))));
			this.btnClearDataGridView.HoverState.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClearDataGridView.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(243)))), ((int)(((byte)(200)))));
			this.btnClearDataGridView.HoverState.Parent = this.btnClearDataGridView;
			this.btnClearDataGridView.Location = new System.Drawing.Point(539, 305);
			this.btnClearDataGridView.Name = "btnClearDataGridView";
			this.btnClearDataGridView.ShadowDecoration.Parent = this.btnClearDataGridView;
			this.btnClearDataGridView.Size = new System.Drawing.Size(48, 29);
			this.btnClearDataGridView.TabIndex = 13;
			this.btnClearDataGridView.Text = "Xóa";
			this.btnClearDataGridView.Click += new System.EventHandler(this.BtnClearDataGridViewClick);
			// 
			// btnUndoDataGridView
			// 
			this.btnUndoDataGridView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(229)))), ((int)(((byte)(243)))));
			this.btnUndoDataGridView.CheckedState.Parent = this.btnUndoDataGridView;
			this.btnUndoDataGridView.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 4);
			this.btnUndoDataGridView.CustomImages.Parent = this.btnUndoDataGridView;
			this.btnUndoDataGridView.FillColor = System.Drawing.Color.Transparent;
			this.btnUndoDataGridView.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnUndoDataGridView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(78)))), ((int)(((byte)(89)))));
			this.btnUndoDataGridView.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(59)))), ((int)(((byte)(120)))));
			this.btnUndoDataGridView.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(87)))), ((int)(((byte)(231)))));
			this.btnUndoDataGridView.HoverState.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUndoDataGridView.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(243)))), ((int)(((byte)(200)))));
			this.btnUndoDataGridView.HoverState.Parent = this.btnUndoDataGridView;
			this.btnUndoDataGridView.Location = new System.Drawing.Point(442, 305);
			this.btnUndoDataGridView.Name = "btnUndoDataGridView";
			this.btnUndoDataGridView.ShadowDecoration.Parent = this.btnUndoDataGridView;
			this.btnUndoDataGridView.Size = new System.Drawing.Size(91, 29);
			this.btnUndoDataGridView.TabIndex = 15;
			this.btnUndoDataGridView.Text = "Quay lại";
			this.btnUndoDataGridView.Click += new System.EventHandler(this.BtnUndoDataGridViewClick);
			// 
			// btnCreateExcel
			// 
			this.btnCreateExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(229)))), ((int)(((byte)(243)))));
			this.btnCreateExcel.CheckedState.Parent = this.btnCreateExcel;
			this.btnCreateExcel.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 4);
			this.btnCreateExcel.CustomImages.Parent = this.btnCreateExcel;
			this.btnCreateExcel.FillColor = System.Drawing.Color.Transparent;
			this.btnCreateExcel.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnCreateExcel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(78)))), ((int)(((byte)(89)))));
			this.btnCreateExcel.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(59)))), ((int)(((byte)(120)))));
			this.btnCreateExcel.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(87)))), ((int)(((byte)(231)))));
			this.btnCreateExcel.HoverState.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCreateExcel.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(243)))), ((int)(((byte)(200)))));
			this.btnCreateExcel.HoverState.Parent = this.btnCreateExcel;
			this.btnCreateExcel.Location = new System.Drawing.Point(185, 388);
			this.btnCreateExcel.Name = "btnCreateExcel";
			this.btnCreateExcel.ShadowDecoration.Parent = this.btnCreateExcel;
			this.btnCreateExcel.Size = new System.Drawing.Size(402, 29);
			this.btnCreateExcel.TabIndex = 17;
			this.btnCreateExcel.Text = "Tạo file Excel";
			this.btnCreateExcel.Click += new System.EventHandler(this.BtnSaveClick);
			// 
			// btnOption1
			// 
			this.btnOption1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(229)))), ((int)(((byte)(243)))));
			this.btnOption1.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
			this.btnOption1.Checked = true;
			this.btnOption1.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(59)))), ((int)(((byte)(120)))));
			this.btnOption1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(63)))), ((int)(((byte)(148)))));
			this.btnOption1.CheckedState.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.btnOption1.CheckedState.Parent = this.btnOption1;
			this.btnOption1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 4);
			this.btnOption1.CustomImages.Parent = this.btnOption1;
			this.btnOption1.FillColor = System.Drawing.Color.Transparent;
			this.btnOption1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOption1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(78)))), ((int)(((byte)(89)))));
			this.btnOption1.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(59)))), ((int)(((byte)(120)))));
			this.btnOption1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(87)))), ((int)(((byte)(231)))));
			this.btnOption1.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(243)))), ((int)(((byte)(200)))));
			this.btnOption1.HoverState.Parent = this.btnOption1;
			this.btnOption1.Location = new System.Drawing.Point(21, 55);
			this.btnOption1.Name = "btnOption1";
			this.btnOption1.ShadowDecoration.Parent = this.btnOption1;
			this.btnOption1.Size = new System.Drawing.Size(73, 29);
			this.btnOption1.TabIndex = 19;
			this.btnOption1.Text = "Loại 1";
			this.btnOption1.Click += new System.EventHandler(this.BtnOption1Click);
			this.btnOption1.MouseLeave += new System.EventHandler(this.BtnOption1MouseLeave);
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(202)))), ((int)(((byte)(241)))));
			this.label4.Location = new System.Drawing.Point(165, 88);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(1, 213);
			this.label4.TabIndex = 23;
			// 
			// btnOption2
			// 
			this.btnOption2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(229)))), ((int)(((byte)(243)))));
			this.btnOption2.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
			this.btnOption2.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(59)))), ((int)(((byte)(120)))));
			this.btnOption2.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(63)))), ((int)(((byte)(148)))));
			this.btnOption2.CheckedState.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.btnOption2.CheckedState.Parent = this.btnOption2;
			this.btnOption2.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 4);
			this.btnOption2.CustomImages.Parent = this.btnOption2;
			this.btnOption2.FillColor = System.Drawing.Color.Transparent;
			this.btnOption2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOption2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(78)))), ((int)(((byte)(89)))));
			this.btnOption2.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(59)))), ((int)(((byte)(120)))));
			this.btnOption2.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(87)))), ((int)(((byte)(231)))));
			this.btnOption2.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(243)))), ((int)(((byte)(200)))));
			this.btnOption2.HoverState.Parent = this.btnOption2;
			this.btnOption2.Location = new System.Drawing.Point(94, 55);
			this.btnOption2.Name = "btnOption2";
			this.btnOption2.ShadowDecoration.Parent = this.btnOption2;
			this.btnOption2.Size = new System.Drawing.Size(72, 29);
			this.btnOption2.TabIndex = 24;
			this.btnOption2.Text = "Loại 2";
			this.btnOption2.Click += new System.EventHandler(this.BtnOption2Click);
			this.btnOption2.MouseLeave += new System.EventHandler(this.BtnOption2MouseLeave);
			// 
			// proLoading
			// 
			this.proLoading.CircleSize = 1F;
			this.proLoading.Location = new System.Drawing.Point(82, 340);
			this.proLoading.Name = "proLoading";
			this.proLoading.Size = new System.Drawing.Size(30, 30);
			this.proLoading.TabIndex = 25;
			this.proLoading.Visible = false;
			// 
			// UCFilter
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.Controls.Add(this.proLoading);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnOption1);
			this.Controls.Add(this.btnCreateExcel);
			this.Controls.Add(this.btnUndoDataGridView);
			this.Controls.Add(this.btnClearDataGridView);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.dgvMainView);
			this.Controls.Add(this.btnClearRawDataInput);
			this.Controls.Add(this.btnFilter);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.rtbRawDataInput);
			this.Controls.Add(this.btnOption2);
			this.Name = "UCFilter";
			this.Size = new System.Drawing.Size(601, 490);
			((System.ComponentModel.ISupportInitialize)(this.dgvMainView)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
