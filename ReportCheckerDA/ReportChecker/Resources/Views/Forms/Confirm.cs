/*
 * Author: 
 * Created: 
 * Description: 
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ReportChecker.Resources.Views.Forms
{
	/// <summary>
	/// Description of Confirm.
	/// </summary>
	public partial class Confirm : Form
	{
		public bool isOk;
		public bool isCancel {
			get {
				return !this.isOk;
			}
		}
		
		public Confirm(string title)
		{
			InitializeComponent();
			this.customeComponents();
			
			this.labTitle.Text = title;
		}
		private void customeComponents()
		{
		}
		void BtnOkClick(object sender, EventArgs e)
		{
			this.isOk = true;
			this.Hide();
		}
		void BtnCancelClick(object sender, EventArgs e)
		{
			this.isOk = false;
			this.Hide();
		}
	}
}
