/*
 * Author: 
 * Created: 
 * Description: 
 */
using System;
using System.Collections.Generic;

namespace ReportChecker.Resources.ClassObjects
{
	/// <summary>
	/// Description of CSize.
	/// </summary>
	public class CSize
	{
		public string Name { get; set; }
		public string Quantity { get; set; }
		
		public CSize()
		{
			this.Name = "";
			this.Quantity = "";
		}
		public CSize(string name, string qty)
		{
			this.Name = name;
			this.Quantity = qty;
		}
		public CSize(CSize size)
		{
			this.Name = size.Name;
			this.Quantity = size.Quantity;
		}
	}
}
