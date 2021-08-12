/*
 * Author: 
 * Created: 
 * Description: 
 */
using System;
using System.Collections.Generic;

namespace ReportChecker.Resources.Classes
{
	/// <summary>
	/// Description of CColor.
	/// </summary>
	public class CColor
	{
		public string Name { get; set; }
		public ICollection<CSize> Sizes { get; set; }
		
		public CColor()
		{
			this.Sizes = new List<CSize>();
		}
		public CColor(CColor color)
		{
			this.Sizes = new List<CSize>();
			
			this.Name = color.Name;
			foreach (var size in color.Sizes) {
				this.Sizes.Add(new CSize(size));
			}
		}
	}
}
