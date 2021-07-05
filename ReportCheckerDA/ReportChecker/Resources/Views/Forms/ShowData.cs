/*
 * Author: 
 * Created: 
 * Description: 
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using ReportChecker.Resources.ClassObjects;
using System.Collections.Generic;

namespace ReportChecker.Resources.Views.Forms
{
	/// <summary>
	/// Description of ShowData.
	/// </summary>
	public partial class ShowData : Form
	{
		public bool isOk;
		public bool isCancel {
			get {
				return !this.isOk;
			}
		}
		public List<CItem> Items = new List<CItem>();
		
		private string sourceInput;
		private byte option;
		private List<string> Colors = new List<string>();
		private List<CItem> ItemsReview = new List<CItem>();
		
		public ShowData(string sourceInput, byte option)
		{
			InitializeComponent();
			this.customeComponent();

			var colors =  DBEntity.Method.getAllColors();
			foreach (var item in colors) {
				this.Colors.Add(item.Name.ToLower());
			}
			
			this.sourceInput = sourceInput;
			this.option = option;
			
			this.filterStringData();
			if (this.itemsIsNull()) {
				this.Close();
			}

			this.showDataOnDataGridView();
		}
		#region private methods
		private void customeComponent()
		{
			this.dgvMainView.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(24, 63, 148);
			this.dgvMainView.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
			this.dgvMainView.EnableHeadersVisualStyles = false;
		}
		private int getIndexOfColor(string str)
		{
			str = str.ToLower();

			int minIndex = int.MaxValue;
			foreach (var color in this.Colors) {
				int index = str.IndexOf(color);
				if (index != -1 && index < minIndex) {
					minIndex = index;
				}
			}
			
			return (minIndex == int.MaxValue) ? -1 : minIndex;
		}
		private string getNameColor(string str)
		{
			char[] ch = str.ToCharArray();
			int lastIndex = -1;
			for (int i = 0; i < ch.Length; i++) {
				int codeInt = Convert.ToInt16(ch[i]);
				if (codeInt > 47 && codeInt < 58) {
					lastIndex = i - 1;
					break;
				}
			}
			string nameColor = this.toTitleCase(str.Substring(0, lastIndex).Trim());

			return nameColor;
		}
		private string toTitleCase(string str)
		{
			char[] ch = str.Trim().ToCharArray();
			ch[0] = str[0].ToString().ToUpper()[0];
			for (int i = 0; i < ch.Length; i++) {
				if (ch[i] == ' ') {
					ch[i + 1] = ch[i + 1].ToString().ToUpper()[0];
				}
			}
	
			return new String(ch);
		}
		private void filterStringData()
		{
			try {
				while (true) {
					int indexColor = this.getIndexOfColor(sourceInput);
					if (indexColor == -1) {
						return;
					}
					
					var item = new CItem() {
						Name = this.toTitleCase(sourceInput.Substring(0, indexColor - 1))
					};
					sourceInput = sourceInput.Substring(indexColor);
					
					while (true) {
						string nameColor = this.getNameColor(sourceInput);
						var color = new CColor() {
							Name = nameColor
						};
						
						sourceInput = sourceInput.Substring(nameColor.Length).Trim();
		
						while (true) {
							var size = new CSize();
							
							if (sourceInput[0] < 48 || sourceInput[0] > 57) {
								break;
							}
							
							int count = 0;
							while (true) {
								if (sourceInput[count] == ' ') {
									sourceInput = sourceInput.Substring(count).Trim();
									color.Sizes.Add(size);
									break;
								}
								int codeInt = Convert.ToInt16(sourceInput[count]);
								if (codeInt > 47 && codeInt < 58) {
									size.Quantity += sourceInput[count];
								} else if (codeInt != 0) {
									size.Name += sourceInput[count].ToString().ToUpper();
								}
								
								count++;
								if (count >= sourceInput.Length) {
									item.Colors.Add(color);
									this.ItemsReview.Add(item);
									color.Sizes.Add(size);
									return;
								}
							}
						}
						
						item.Colors.Add(color);
						
						indexColor = this.getIndexOfColor(sourceInput);
						if (indexColor != 0) {
							break;
						}
					}
					
					this.ItemsReview.Add(item);
				}
			} catch {
				using (var alert = new Confirm("Lỗi dữ liệu đầu vào!")) {
					alert.ShowDialog();
				}
				this.Close();
			}
		}
		private bool itemsIsNull()
		{
			return (this.ItemsReview.Count == 0);
		}
		private void showDataOnDataGridView()
		{
			var rawArray = new string[1000, 5];
			
			int rowCounter = 0;
            for (int i = 0; i < this.ItemsReview.Count; i++) {
				var item = this.ItemsReview.ElementAt(i);
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
		private void storeAndCheckDuplicateColor(List<CItem> tmpList)
		{
			foreach (var item in tmpList) {
				bool removeLastColor = false;
				for (int i = item.Colors.Count - 1; i >= 0; i--) {
					if (removeLastColor) {
						CColor color = item.Colors.ElementAt(i + 1);
						item.Colors.Remove(color);
						removeLastColor = false;
					}
					for (int j = 0; j < i; j++) {
						if (item.Colors.ElementAt(i).Name == item.Colors.ElementAt(j).Name) {
							foreach (var size in item.Colors.ElementAt(i).Sizes) {
								var tmpSize = item.Colors.ElementAt(j).Sizes.FirstOrDefault(c => c.Name == size.Name);
								if (tmpSize == null) {
									item.Colors.ElementAt(j).Sizes.Add(new CSize(size.Name, size.Quantity));
								} else {
									int qty1 = int.Parse(tmpSize.Quantity);
									int qty2 = int.Parse(size.Quantity);
									tmpSize.Quantity = (qty1 + qty2).ToString();
								}
							}
							removeLastColor = true;
							break;
						}
					}
				}
			}
			
			this.Items.Clear();
			foreach (var item in tmpList) {
				this.Items.Add(new CItem(item));
			}
		}
		#endregion
		#region UI events
		void BtnAddSubClick(object sender, EventArgs e)
		{
			this.isOk = true;

			var tmpListItems = new List<CItem>();
			for (int row = 0; row < dgvMainView.Rows.Count - 1; row++) {
				for (int col = 1; col < dgvMainView.Rows[row].Cells.Count; col++) {
					string value = Convert.ToString(dgvMainView.Rows[row].Cells[col].Value);
			        if (string.IsNullOrEmpty(value) && string.IsNullOrWhiteSpace(value)) {
						continue;
			        }
					if (col == 1) {
						tmpListItems.Add(new CItem() { Name = this.toTitleCase(value) });
					}
					CItem lastItem = tmpListItems.ElementAt(tmpListItems.Count - 1);
					if (col == 2) {
						lastItem.Colors.Add(new CColor() { Name = this.toTitleCase(value) });
					}
					int lastIndexOfColor = lastItem.Colors.Count - 1;
					if (col == 3) {
						lastItem.Colors.ElementAt(lastIndexOfColor).Sizes.Add(new CSize() { Name = value.ToUpper() });
					}
					if (col == 4) {
						lastItem.Colors.ElementAt(lastIndexOfColor).Sizes.ElementAt(lastItem.Colors.ElementAt(lastIndexOfColor).Sizes.Count - 1).Quantity = value;
					}
				}
			}
			this.storeAndCheckDuplicateColor(tmpListItems);
			
			this.Hide();
		}
		void BtnCancelClick(object sender, EventArgs e)
		{
			this.isOk = false;
			this.Hide();
		}
		#endregion
	}
}
