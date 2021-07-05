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
	/// Description of Note.
	/// </summary>
	public partial class Tooltip : Form
	{
		public Tooltip(string message, Point point)
		{
			InitializeComponent();
			this.customeComponent(message, point);
		}
		private void customeComponent(string message, Point point)
		{
			this.labMessage.Text = message;
			Graphics g = this.labMessage.CreateGraphics();
			int width = (int)g.MeasureString(this.labMessage.Text, this.labMessage.Font).Width + 6;
			g.Dispose();
			
			int tmp = (int)(width / 130);
			this.Height = 24 * ((tmp < (width / 130)) ? tmp + 1 : tmp) + 6;
			this.Width = 130;
			
			this.StartPosition = FormStartPosition.Manual;
			this.Location = point;
		}
	}
}
