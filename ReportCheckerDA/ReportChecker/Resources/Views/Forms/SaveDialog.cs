/*
 * Author: 
 * Created: 
 * Description: 
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using ReportChecker.Resources.ClassObjects;
using System.Collections.Generic;
using Excel = Microsoft.Office.Interop.Excel;
using System.Linq;
using System.IO;
using ReportChecker.Resources.Views.Forms;
using System.Threading.Tasks;

namespace ReportChecker.Resources.Views.Forms
{
	/// <summary>
	/// Description of SaveDialog.
	/// </summary>
	public partial class SaveDialog : Form
	{
		private List<CItem> Items = new List<CItem>();
		private string pathDirectory;
		private string excelFileName;
		
		public SaveDialog(List<CItem> items)
		{
			InitializeComponent();
			
			foreach (var item in items) {
				this.Items.Add(new CItem(item));
			}

			string currentPathDirectory = Application.StartupPath + @"\";

			string officialPath = currentPathDirectory + Resources.Constants.CStatic.excelFolderName;
			if (!Directory.Exists(officialPath)) {
				Directory.CreateDirectory(officialPath);
			}	
			
			DateTime date = DateTime.Now;
			string sFileName = date.Year + "-" + date.Month + "-" + date.Day + "__"  +  date.Hour + "-" + date.Minute + "-" + date.Second;
			
			this.pathDirectory = officialPath + @"\";
			this.excelFileName = sFileName;
			
			this.txbAddress.Text = this.pathDirectory;
			this.txbFileName.Text = this.excelFileName;
		}
		#region private methods
		private void releaseObject(object obj)  
        {  
            try {
				System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);	
            } finally {
				obj = null;
				GC.Collect();
            }
        }
		private void createExcel()
		{
			Excel.Application xlSamp = new Microsoft.Office.Interop.Excel.Application();
			
			Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            
            xlWorkBook = xlSamp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            
            xlWorkSheet.Cells[1, 1] = "STT";
            xlWorkSheet.Cells[1, 2] = "Tên Sản Phẩm";
            xlWorkSheet.Cells[1, 3] = "Màu";
            xlWorkSheet.Cells[1, 4] = "Size";
            xlWorkSheet.Cells[1, 5] = "SL";
            xlWorkSheet.Cells[1, 6] = "Ghi Chú";
            
            int rowCounter = 2;
            for (int i = 0; i < this.Items.Count; i++) {
            	var item = this.Items.ElementAt(i);
            	xlWorkSheet.Cells[rowCounter, 1] = i + 1;
            	xlWorkSheet.Cells[rowCounter, 2] = item.Name;
            	for (int j = 0; j < item.Colors.Count; j++) {
            		var color = item.Colors.ElementAt(j);
            		xlWorkSheet.Cells[rowCounter, 3] = color.Name;
            		for (int k = 0; k < color.Sizes.Count; k++) {
            			var size = color.Sizes.ElementAt(k);
            			xlWorkSheet.Cells[rowCounter, 4] = size.Name;
            			xlWorkSheet.Cells[rowCounter, 5] = size.Quantity;
            			rowCounter++;
            		}	
            	}
            }

            xlWorkBook.SaveAs(this.txbAddress.Text + this.txbFileName.Text + Resources.Constants.CStatic.excelExtension, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlSamp.Quit();

            releaseObject(xlWorkSheet);  
            releaseObject(xlWorkBook); 
            releaseObject(xlSamp);
		}
		private void saveToDatabase()
		{
			foreach (var item in this.Items) {
				foreach (var color in item.Colors) {
					foreach (var size in color.Sizes) {
						bool isSuccess =  DBEntity.Method.addDateAndItem(item.Name, color.Name, size.Name, Convert.ToInt16(size.Quantity));
						if (!isSuccess) {
							using (var fr = new Confirm("Lỗi!")) {
								fr.ShowDialog();
								return;
							}
						}
					}
				}
			}
		}
		private void toggleLoading()
		{
			this.txbAddress.Enabled = !this.txbAddress.Enabled;
			this.txbFileName.Enabled = !this.txbFileName.Enabled;
			this.btnCancel.Enabled = !this.btnCancel.Enabled;
			this.btnDefault.Enabled = !this.btnDefault.Enabled;
			this.btnSave.Enabled = !this.btnSave.Enabled;
			this.btnClearAddress.Enabled = !this.btnClearAddress.Enabled;
			this.btnClearFileName.Enabled = !this.btnClearFileName.Enabled;
			this.cbxSaveDB.Enabled = !this.cbxSaveDB.Enabled;
			this.proLoading.Visible = !this.proLoading.Visible;
			this.proLoading.AutoStart = !this.proLoading.AutoStart;
		}
		private async void asyncSaveData(Task<byte> task)
        {
			this.toggleLoading();
			byte errCode = await task;
			this.toggleLoading();
			
			if (errCode == 0) {
				this.Hide();
				using (var fr = new AfterSave(this.txbAddress.Text)) {
					fr.ShowDialog();
				}
			} else {
				using (var fr = new Confirm(errCode == 1 ? "Lỗi tên hoặc đường dẫn!" : "Lưu về kho dữ liệu thất bại!")) {
					fr.ShowDialog();
				}
			}
			this.Close();
        }
		private Task<byte> taskSaveData(bool isSaveDB)
		{
			return Task.Factory.StartNew(() => saveData(isSaveDB));
		}
		private byte saveData(bool isSaveDB)
		{
			bool createExcelSuccess = true;
			bool createDBSuccess = true;
			try {
				this.createExcel();
				if (isSaveDB) {
					try {
						this.saveToDatabase();	
					} catch {
						createDBSuccess = false;
					}
				}
			} catch {
				createExcelSuccess = false;
			}
			return Convert.ToByte(!createExcelSuccess ? 1 : (!createDBSuccess ? 2 : 0));
		}
		#endregion
		#region UI events
		void BtnSaveClick(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(this.txbAddress.Text) || string.IsNullOrEmpty(this.txbFileName.Text)) {
				this.Hide();
				using (var form = new Confirm("Tên và đường dẫn không được trống!")) {
					form.ShowDialog();
				}
				this.Show();
				return;
			}
			
			this.asyncSaveData(taskSaveData(this.cbxSaveDB.Checked));
		}
		void BtnDefaultClick(object sender, EventArgs e)
		{
			DateTime date = DateTime.Now;
			string sFileName = date.Hour + "-" + date.Minute + "-" + date.Second + " _ " + date.Day + "-" + date.Month + "-" + date.Year;
			this.excelFileName = sFileName;
			this.txbAddress.Text = this.pathDirectory;
			this.txbFileName.Text = this.excelFileName;
			this.cbxSaveDB.Checked = true;
		}
		void BtnCancelClick(object sender, EventArgs e)
		{
			this.Close();
		}
		void BtnClearFileNameClick(object sender, EventArgs e)
		{
			this.txbFileName.Text = null;
		}
		void BtnClearAddressClick(object sender, EventArgs e)
		{
			this.txbAddress.Text = null;
		}
		#endregion
	}
}
