/*
 * Author: 
 * Created: 
 * Description: 
 */
namespace ReportChecker.Resources.Views.Forms
{
	partial class SaveDialog
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private Guna.UI2.WinForms.Guna2Panel pnlMainView;
		private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
		private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
		private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
		private Guna.UI2.WinForms.Guna2TextBox txbAddress;
		private Guna.UI2.WinForms.Guna2TextBox txbFileName;
		private Guna.UI2.WinForms.Guna2Button btnDefault;
		private Guna.UI2.WinForms.Guna2Button btnCancel;
		private Guna.UI2.WinForms.Guna2Button btnSave;
		private Guna.UI2.WinForms.Guna2DragControl dctForm;
		private Guna.UI2.WinForms.Guna2ImageButton btnClearFileName;
		private Guna.UI2.WinForms.Guna2ImageButton btnClearAddress;
		private Guna.UI2.WinForms.Guna2CheckBox cbxSaveDB;
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaveDialog));
			this.pnlMainView = new Guna.UI2.WinForms.Guna2Panel();
			this.cbxSaveDB = new Guna.UI2.WinForms.Guna2CheckBox();
			this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
			this.btnClearAddress = new Guna.UI2.WinForms.Guna2ImageButton();
			this.btnClearFileName = new Guna.UI2.WinForms.Guna2ImageButton();
			this.txbAddress = new Guna.UI2.WinForms.Guna2TextBox();
			this.txbFileName = new Guna.UI2.WinForms.Guna2TextBox();
			this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.btnDefault = new Guna.UI2.WinForms.Guna2Button();
			this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
			this.btnSave = new Guna.UI2.WinForms.Guna2Button();
			this.dctForm = new Guna.UI2.WinForms.Guna2DragControl(this.components);
			this.proLoading = new Guna.UI2.WinForms.Guna2ProgressIndicator();
			this.pnlMainView.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pnlMainView
			// 
			this.pnlMainView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(70)))), ((int)(((byte)(112)))));
			this.pnlMainView.Controls.Add(this.cbxSaveDB);
			this.pnlMainView.Controls.Add(this.guna2PictureBox1);
			this.pnlMainView.Controls.Add(this.btnClearAddress);
			this.pnlMainView.Controls.Add(this.btnClearFileName);
			this.pnlMainView.Controls.Add(this.txbAddress);
			this.pnlMainView.Controls.Add(this.txbFileName);
			this.pnlMainView.Controls.Add(this.guna2HtmlLabel2);
			this.pnlMainView.Controls.Add(this.guna2HtmlLabel1);
			this.pnlMainView.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlMainView.Location = new System.Drawing.Point(0, 0);
			this.pnlMainView.Name = "pnlMainView";
			this.pnlMainView.ShadowDecoration.Parent = this.pnlMainView;
			this.pnlMainView.Size = new System.Drawing.Size(477, 114);
			this.pnlMainView.TabIndex = 0;
			// 
			// cbxSaveDB
			// 
			this.cbxSaveDB.Animated = true;
			this.cbxSaveDB.BackColor = System.Drawing.Color.Transparent;
			this.cbxSaveDB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.cbxSaveDB.Checked = true;
			this.cbxSaveDB.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbxSaveDB.CheckedState.BorderRadius = 0;
			this.cbxSaveDB.CheckedState.BorderThickness = 0;
			this.cbxSaveDB.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(59)))), ((int)(((byte)(120)))));
			this.cbxSaveDB.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbxSaveDB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(202)))), ((int)(((byte)(241)))));
			this.cbxSaveDB.Location = new System.Drawing.Point(97, 85);
			this.cbxSaveDB.Name = "cbxSaveDB";
			this.cbxSaveDB.Size = new System.Drawing.Size(147, 26);
			this.cbxSaveDB.TabIndex = 14;
			this.cbxSaveDB.Text = "Lưu cả về kho dữ liệu";
			this.cbxSaveDB.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
			this.cbxSaveDB.UncheckedState.BorderRadius = 0;
			this.cbxSaveDB.UncheckedState.BorderThickness = 0;
			this.cbxSaveDB.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
			this.cbxSaveDB.UseVisualStyleBackColor = false;
			// 
			// guna2PictureBox1
			// 
			this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
			this.guna2PictureBox1.Location = new System.Drawing.Point(451, 0);
			this.guna2PictureBox1.Name = "guna2PictureBox1";
			this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
			this.guna2PictureBox1.Size = new System.Drawing.Size(26, 31);
			this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.guna2PictureBox1.TabIndex = 13;
			this.guna2PictureBox1.TabStop = false;
			// 
			// btnClearAddress
			// 
			this.btnClearAddress.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
			this.btnClearAddress.CheckedState.Parent = this.btnClearAddress;
			this.btnClearAddress.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("btnClearAddress.HoverState.Image")));
			this.btnClearAddress.HoverState.ImageSize = new System.Drawing.Size(22, 22);
			this.btnClearAddress.HoverState.Parent = this.btnClearAddress;
			this.btnClearAddress.Image = ((System.Drawing.Image)(resources.GetObject("btnClearAddress.Image")));
			this.btnClearAddress.ImageRotate = 0F;
			this.btnClearAddress.ImageSize = new System.Drawing.Size(22, 22);
			this.btnClearAddress.Location = new System.Drawing.Point(433, 57);
			this.btnClearAddress.Name = "btnClearAddress";
			this.btnClearAddress.PressedState.ImageSize = new System.Drawing.Size(22, 22);
			this.btnClearAddress.PressedState.Parent = this.btnClearAddress;
			this.btnClearAddress.Size = new System.Drawing.Size(22, 22);
			this.btnClearAddress.TabIndex = 12;
			this.btnClearAddress.Click += new System.EventHandler(this.BtnClearAddressClick);
			// 
			// btnClearFileName
			// 
			this.btnClearFileName.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
			this.btnClearFileName.CheckedState.Parent = this.btnClearFileName;
			this.btnClearFileName.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("btnClearFileName.HoverState.Image")));
			this.btnClearFileName.HoverState.ImageSize = new System.Drawing.Size(22, 22);
			this.btnClearFileName.HoverState.Parent = this.btnClearFileName;
			this.btnClearFileName.Image = ((System.Drawing.Image)(resources.GetObject("btnClearFileName.Image")));
			this.btnClearFileName.ImageRotate = 0F;
			this.btnClearFileName.ImageSize = new System.Drawing.Size(22, 22);
			this.btnClearFileName.Location = new System.Drawing.Point(433, 29);
			this.btnClearFileName.Name = "btnClearFileName";
			this.btnClearFileName.PressedState.ImageSize = new System.Drawing.Size(22, 22);
			this.btnClearFileName.PressedState.Parent = this.btnClearFileName;
			this.btnClearFileName.Size = new System.Drawing.Size(22, 22);
			this.btnClearFileName.TabIndex = 11;
			this.btnClearFileName.Click += new System.EventHandler(this.BtnClearFileNameClick);
			// 
			// txbAddress
			// 
			this.txbAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txbAddress.DefaultText = "";
			this.txbAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txbAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txbAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txbAddress.DisabledState.Parent = this.txbAddress;
			this.txbAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txbAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txbAddress.FocusedState.Parent = this.txbAddress;
			this.txbAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txbAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txbAddress.HoverState.Parent = this.txbAddress;
			this.txbAddress.Location = new System.Drawing.Point(97, 59);
			this.txbAddress.Name = "txbAddress";
			this.txbAddress.PasswordChar = '\0';
			this.txbAddress.PlaceholderText = "C:\\...";
			this.txbAddress.SelectedText = "";
			this.txbAddress.ShadowDecoration.Parent = this.txbAddress;
			this.txbAddress.Size = new System.Drawing.Size(330, 20);
			this.txbAddress.TabIndex = 7;
			// 
			// txbFileName
			// 
			this.txbFileName.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txbFileName.DefaultText = "";
			this.txbFileName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txbFileName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txbFileName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txbFileName.DisabledState.Parent = this.txbFileName;
			this.txbFileName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txbFileName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txbFileName.FocusedState.Parent = this.txbFileName;
			this.txbFileName.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txbFileName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txbFileName.HoverState.Parent = this.txbFileName;
			this.txbFileName.Location = new System.Drawing.Point(97, 33);
			this.txbFileName.Name = "txbFileName";
			this.txbFileName.PasswordChar = '\0';
			this.txbFileName.PlaceholderText = "Aa...";
			this.txbFileName.SelectedText = "";
			this.txbFileName.ShadowDecoration.Parent = this.txbFileName;
			this.txbFileName.Size = new System.Drawing.Size(330, 20);
			this.txbFileName.TabIndex = 6;
			// 
			// guna2HtmlLabel2
			// 
			this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
			this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(229)))), ((int)(((byte)(243)))));
			this.guna2HtmlLabel2.Location = new System.Drawing.Point(12, 59);
			this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
			this.guna2HtmlLabel2.Size = new System.Drawing.Size(79, 20);
			this.guna2HtmlLabel2.TabIndex = 5;
			this.guna2HtmlLabel2.Text = "Đường dẫn:";
			// 
			// guna2HtmlLabel1
			// 
			this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
			this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(229)))), ((int)(((byte)(243)))));
			this.guna2HtmlLabel1.Location = new System.Drawing.Point(12, 33);
			this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
			this.guna2HtmlLabel1.Size = new System.Drawing.Size(54, 20);
			this.guna2HtmlLabel1.TabIndex = 4;
			this.guna2HtmlLabel1.Text = "Tên file:";
			// 
			// btnDefault
			// 
			this.btnDefault.CheckedState.Parent = this.btnDefault;
			this.btnDefault.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 4);
			this.btnDefault.CustomImages.Parent = this.btnDefault;
			this.btnDefault.FillColor = System.Drawing.Color.Transparent;
			this.btnDefault.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnDefault.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(78)))), ((int)(((byte)(89)))));
			this.btnDefault.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(59)))), ((int)(((byte)(120)))));
			this.btnDefault.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(63)))), ((int)(((byte)(148)))));
			this.btnDefault.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDefault.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(243)))), ((int)(((byte)(200)))));
			this.btnDefault.HoverState.Parent = this.btnDefault;
			this.btnDefault.Location = new System.Drawing.Point(12, 120);
			this.btnDefault.Name = "btnDefault";
			this.btnDefault.ShadowDecoration.Parent = this.btnDefault;
			this.btnDefault.Size = new System.Drawing.Size(106, 29);
			this.btnDefault.TabIndex = 11;
			this.btnDefault.Text = "Mặc định";
			this.btnDefault.Click += new System.EventHandler(this.BtnDefaultClick);
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
			this.btnCancel.Location = new System.Drawing.Point(359, 120);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.ShadowDecoration.Parent = this.btnCancel;
			this.btnCancel.Size = new System.Drawing.Size(106, 29);
			this.btnCancel.TabIndex = 13;
			this.btnCancel.Text = "Hủy";
			this.btnCancel.Click += new System.EventHandler(this.BtnCancelClick);
			// 
			// btnSave
			// 
			this.btnSave.CheckedState.Parent = this.btnSave;
			this.btnSave.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 4);
			this.btnSave.CustomImages.Parent = this.btnSave;
			this.btnSave.FillColor = System.Drawing.Color.Transparent;
			this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(78)))), ((int)(((byte)(89)))));
			this.btnSave.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(59)))), ((int)(((byte)(120)))));
			this.btnSave.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(63)))), ((int)(((byte)(148)))));
			this.btnSave.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSave.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(243)))), ((int)(((byte)(200)))));
			this.btnSave.HoverState.Parent = this.btnSave;
			this.btnSave.Location = new System.Drawing.Point(247, 120);
			this.btnSave.Name = "btnSave";
			this.btnSave.ShadowDecoration.Parent = this.btnSave;
			this.btnSave.Size = new System.Drawing.Size(106, 29);
			this.btnSave.TabIndex = 15;
			this.btnSave.Text = "Lưu";
			this.btnSave.Click += new System.EventHandler(this.BtnSaveClick);
			// 
			// dctForm
			// 
			this.dctForm.ContainerControl = this;
			this.dctForm.TargetControl = this.pnlMainView;
			this.dctForm.TransparentWhileDrag = true;
			this.dctForm.UseTransparentDrag = true;
			// 
			// proLoading
			// 
			this.proLoading.CircleSize = 1F;
			this.proLoading.Location = new System.Drawing.Point(189, 120);
			this.proLoading.Name = "proLoading";
			this.proLoading.Size = new System.Drawing.Size(30, 30);
			this.proLoading.TabIndex = 16;
			this.proLoading.Visible = false;
			// 
			// SaveDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(202)))), ((int)(((byte)(241)))));
			this.ClientSize = new System.Drawing.Size(477, 161);
			this.Controls.Add(this.proLoading);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnDefault);
			this.Controls.Add(this.pnlMainView);
			this.Controls.Add(this.btnSave);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "SaveDialog";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "SaveDialog";
			this.TransparencyKey = System.Drawing.Color.Fuchsia;
			this.pnlMainView.ResumeLayout(false);
			this.pnlMainView.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
