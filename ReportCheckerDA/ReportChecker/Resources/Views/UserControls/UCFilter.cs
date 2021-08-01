/*
 * Author: 
 * Created: 
 * Description: 
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using ReportChecker.Resources.Classes;
using System.Collections.Generic;
using ReportChecker.Resources.Views.Forms;
using System.Linq;
using Newtonsoft.Json;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace ReportChecker.Resources.Views.UserControls
{
	/// <summary>
	/// Description of UCFilter.
	/// </summary>
	public partial class UCFilter : UserControl
	{
		#region public variable
		public void draftData()
		{
			if (this.ListSubtotal.Count == 0) {
				using (var form = new Confirm("Chưa có dữ liệu")) {
					form.ShowDialog();
				}
				return;
			}
			
			string currentPathDirectory = Application.StartupPath + @"\";

			var serializer = new JsonSerializer();
			serializer.NullValueHandling = NullValueHandling.Ignore;

			string message = "Đã lưu dữ liệu tạm.";
			try {
				using (var sw = new StreamWriter(currentPathDirectory + Resources.Constants.CStatic.jsonFileName))
				using (JsonWriter writer = new JsonTextWriter(sw)) {
				    serializer.Serialize(writer, this.ListSubtotal);
				}
			} catch {
				message = "Lưu không thành công!";
			}
			using (var form = new Confirm(message)) {
				form.ShowDialog();
			}
		}
		public void restoreData()
		{
			string currentPathDirectory = Application.StartupPath + @"\";
			string jsonFilePath = currentPathDirectory + Resources.Constants.CStatic.jsonFileName;
			
			string message = "Đã khôi phục dữ liệu tạm!";
			try {
				string json = File.ReadAllText(jsonFilePath);
				List<CItem> deserializedItems = JsonConvert.DeserializeObject<List<CItem>>(json);
				this.copyListCItem(this.ListSubtotal, this.ListRecovery);
				this.copyListCItem(deserializedItems, this.ListSubtotal);
				this.showListSubtotalData();
			} catch {				
				message = "Lỗi khôi phục!";
			}
			using (var form = new Confirm(message)) {
				form.ShowDialog();
			}
		}
		#endregion
		#region private variable
		private byte option = 0;
		private List<CItem> ListSubtotal = new List<CItem>();
		private List<CItem> ListSingle = new List<CItem>();
		private List<CItem> ListRecovery = new List<CItem>();
		#endregion
		public UCFilter()
		{
			InitializeComponent();
			this.customeComponent();
			
			Resources.Constants.CStatic.action = actionAfterPressingHotkey;
			var threadHookKeyboard = new Thread(Resources.Constants.CStatic.HookKeyboard);
			threadHookKeyboard.IsBackground = true;
            threadHookKeyboard.Start();
		}
		#region private methods
		private void customeComponent()
		{
			this.dgvMainView.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(24, 63, 148);
			this.dgvMainView.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
			this.dgvMainView.EnableHeadersVisualStyles = false;
		}
		private void actionAfterPressingHotkey()
		{
			var frm = new Alert();
			this.Invoke(new Action(()=> {
			                       	if (Clipboard.ContainsText(TextDataFormat.UnicodeText)) {
			                       		this.rtbRawDataInput.Text += Clipboard.GetText() + "\n";
			                       		frm.showAlert("Copy thành công");
			                       	} else {
			                       		frm.showAlert("Lỗi!");
			                       	}
			                       }));
		}
		private void changeBorderInputColor(Color color)
		{
			this.label1.BackColor = color;
			this.label2.BackColor = color;
			this.label3.BackColor = color;
			this.label4.BackColor = color;
		}
		private string reverseString(string str)
        {
            char[] arr = str.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
		private string transformOption2String(string str)
		{
			string originalCharArray = this.reverseString(str);
			var outputCharArray = new List<char>();

			int i = 0;
			bool haveDigitBefore = false;
			bool getDigit = false;
			var tmpDigitCharArr = new List<char>();
			
			while (i < originalCharArray.Length) {
				int codeInt = Convert.ToInt16(originalCharArray[i]);
				
				if (codeInt > 47 && codeInt < 58) {
					if (!haveDigitBefore) {
						haveDigitBefore = true;
						tmpDigitCharArr.Clear();
					}
					tmpDigitCharArr.Add(originalCharArray[i++]);
					continue;
				}
				if (haveDigitBefore) {
					haveDigitBefore = false;
					getDigit = true;
					outputCharArray.Add(originalCharArray[i++]);
					continue;
				}
				int codeIntOfCharBefore = Convert.ToInt16(originalCharArray[i - 1]);
				if (codeInt == 32 && codeIntOfCharBefore > 64 && getDigit) {
					for (int j = 0; j < tmpDigitCharArr.Count; j++) {
						outputCharArray.Add(tmpDigitCharArr[j]);
					}
					getDigit = false;
					outputCharArray.Add(originalCharArray[i++]);
					continue;
				}
				outputCharArray.Add(originalCharArray[i++]);
			}
			
			var outputStringReverse = new string(outputCharArray.ToArray());

			return this.reverseString(outputStringReverse);
		}
		private string formatString(string str)
		{
			var originalCharArray = new char[str.Length + 1];
			var outputCharArray = new char[str.Length + 1];

			originalCharArray = this.option == 0 ? str.Trim().ToLower().ToCharArray() : this.transformOption2String(str.Trim()).ToCharArray();
			
			int count = 0;
			int i = 0;
			bool isSpaceRemoved = false;
			while (i < originalCharArray.Length) {
				int codeInt = Convert.ToInt16(originalCharArray[i]);
				if (codeInt == 10) {
					outputCharArray[count++] = ' ';
					i++;
					continue;
				}
				
				if (isSpaceRemoved && codeInt == 32) {
					i++;
					continue;
				}
				
				if (codeInt > 47 && codeInt < 58) {
					isSpaceRemoved = true;
					outputCharArray[count++] = originalCharArray[i];
					i++;
					continue;
				}
				
				isSpaceRemoved = false;
				outputCharArray[count++] = originalCharArray[i];
				i++;
			}
			
			return new String(outputCharArray).Trim();
		}
		private void addListSingleToListSubtotal()
		{
			foreach (var item in this.ListSingle) {
				var tmpItem = this.ListSubtotal.FirstOrDefault(c => c.Name == item.Name);
				if (tmpItem == null) {
					this.ListSubtotal.Add(item);
				} else {
					foreach (var color in item.Colors) {
						var tmpColor = tmpItem.Colors.FirstOrDefault(c => c.Name == color.Name);
						if (tmpColor == null) {
							tmpItem.Colors.Add(color);
						} else {
							foreach (var size in color.Sizes) {
								var tmpSize = tmpColor.Sizes.FirstOrDefault(c => c.Name == size.Name);
																
								if (tmpSize == null) {
									tmpColor.Sizes.Add(new CSize(size.Name, size.Quantity));
								} else {
									int qty1 = int.Parse(tmpSize.Quantity);
									int qty2 = int.Parse(size.Quantity);
									tmpSize.Quantity = (qty1 + qty2).ToString();
								}
							}
						}
					}
				}
			}
		}
		private void showListSubtotalData()
		{
			var rawArray = new string[10000, 5];
			
			int rowCounter = 0;
            for (int i = 0; i < this.ListSubtotal.Count; i++) {
				var item = this.ListSubtotal.ElementAt(i);
				rawArray[rowCounter, 0] = (i + 1).ToString();
            	rawArray[rowCounter, 1] = item.Name;
            	for (int j = 0; j < item.Colors.Count; j++) {
            		var color = item.Colors.ElementAt(j);
            		rawArray[rowCounter, 2] = color.Name;
            		for (int k = 0; k < color.Sizes.Count; k++) {
            			var size = color.Sizes.ElementAt(k);
            			rawArray[rowCounter, 3] = size.Name;
            			rawArray[rowCounter, 4] = size.Quantity;
            			rowCounter++;
            		}	
            	}
            }
			
			var itemArray = new string[rowCounter, 5];
			for (int row = 0; row < rowCounter; row++) {
				for (int col = 0; col < 5; col++) {
					itemArray[row, col] = rawArray[row, col];
				}
			}
			
			this.dgvMainView.Rows.Clear();
			
			int height = itemArray.GetLength(0);
			int width = itemArray.GetLength(1);
			
			this.dgvMainView.ColumnCount = width;
			
			for (int r = 0; r < height; r++) {
				var row = new DataGridViewRow();
				row.CreateCells(this.dgvMainView);
				
				for (int c = 0; c < width; c++) {
					row.Cells[c].Value = itemArray[r, c];
				}
				
				this.dgvMainView.Rows.Add(row);
			}
		}
		private void displayShowDataForm(string sourceInput)
		{
			using (var form = new ShowData(sourceInput, this.option)) {
				try {
					form.ShowDialog();
					if (form.isCancel) {
						return;
					}
					this.ListSingle.Clear();
					foreach (var item in form.Items) {
						this.ListSingle.Add(item);
					}
				} catch {
					return;
				}
			}
			this.copyListCItem(this.ListSubtotal, this.ListRecovery);
			this.addListSingleToListSubtotal();
			this.showListSubtotalData();
		}
		private void copyListCItem(List<CItem> root, List<CItem> destination)
		{
			destination.Clear();
			
			foreach (var item in root) {
				destination.Add(new CItem (item));
			}
		}
		private void toggleLoading()
		{
			this.Enabled = !this.Enabled;
			this.proLoading.Visible = !this.proLoading.Visible;
			this.proLoading.AutoStart = !this.proLoading.AutoStart;
		}
		private async void asyncFilterData(Task<string> task)
        {
			this.toggleLoading();
			string data = await task;
			this.toggleLoading();
			
			if (string.IsNullOrEmpty(data)) {
				using (var fr = new Confirm("Lỗi dữ liệu!")) {
					fr.ShowDialog();
				}
			} else {
				this.displayShowDataForm(data);	
			}
        }
		private Task<string> taskFilterData(string data)
		{
			return Task.Factory.StartNew(() => filterData(data));
		}
		private string filterData(string data)
		{
			string strFormater;
			try {
				strFormater = this.formatString(data);
			} catch {
				strFormater = null;
			}
			return strFormater;
		}
		#endregion
		
		
		#region UI events
		void RtbRawDataInputEnter(object sender, EventArgs e)
		{
			this.changeBorderInputColor(Color.FromArgb(22, 87, 231));
		}
		void RtbRawDataInputLeave(object sender, EventArgs e)
		{
			this.changeBorderInputColor(Color.FromArgb(197, 202, 241));
		}
		void RtbRawDataInputMouseHover(object sender, EventArgs e)
		{
			if (this.rtbRawDataInput.Focused) {
				return;
			}
			this.changeBorderInputColor(Color.FromArgb(73, 78, 89));
		}
		void RtbRawDataInputMouseLeave(object sender, EventArgs e)
		{
			if (this.rtbRawDataInput.Focused) {
				return;
			}
			this.changeBorderInputColor(Color.FromArgb(197, 202, 241));
		}
		void BtnOption1MouseLeave(object sender, EventArgs e)
		{
			if (this.btnOption1.Checked) {
				return;
			}
		}
		void BtnOption2MouseLeave(object sender, EventArgs e)
		{
			if (this.btnOption2.Checked) {
				return;
			}
		}
		void BtnOption1Click(object sender, EventArgs e)
		{
			this.option = 0;
		}
		void BtnOption2Click(object sender, EventArgs e)
		{
			this.option = 1;
		}
		void BtnFilterClick(object sender, EventArgs e)
		{
			this.asyncFilterData(taskFilterData(rtbRawDataInput.Text));
		}
		void BtnClearRawDataInputClick(object sender, EventArgs e)
		{
			this.rtbRawDataInput.Text = null;
		}
		void BtnClearDataGridViewClick(object sender, EventArgs e)
		{
			if (this.ListSubtotal.Count == 0) {
				return;
			}
			this.copyListCItem(this.ListSubtotal, this.ListRecovery);
			this.ListSubtotal.Clear();
			this.dgvMainView.Rows.Clear();
		}
		void BtnUndoDataGridViewClick(object sender, EventArgs e)
		{
			if (this.ListRecovery.Count == 0) {
				return;
			}
			this.ListSubtotal.Clear();
			foreach (var item in this.ListRecovery) {
				this.ListSubtotal.Add(new CItem(item));
			}
			this.ListRecovery.Clear();
			
			this.showListSubtotalData();
		}
		void BtnSaveClick(object sender, EventArgs e)
		{
			if (this.ListSubtotal.Count == 0) {
				return;
			}
			using (var form = new SaveDialog(this.ListSubtotal)) {
				form.ShowDialog();
			}
		}
		#endregion
	}
}
