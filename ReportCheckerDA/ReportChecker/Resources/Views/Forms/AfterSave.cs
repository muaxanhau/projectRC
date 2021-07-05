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
	/// Description of AfterSave.
	/// </summary>
	public partial class AfterSave : Form
	{
		private string addressDirectory;
		
		public AfterSave(string addressDirectory)
		{
			InitializeComponent();
			this.customeComponents();

			this.addressDirectory = addressDirectory;
		}
		private void customeComponents()
		{
		}
		void BtnOpenClick(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start(this.addressDirectory);
			this.Close();
		}
		void BtnCancelClick(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
