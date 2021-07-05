/*
 * Author: 
 * Created: 
 * Description: 
 */
using System;
using System.Collections.Generic;

namespace ReportCheckerWebApi.Features.Commons.Classes
{
    /// <summary>
    /// Description of CItem.
    /// </summary>
    public class CItem
    {
        public string Name { get; set; }
        public ICollection<CColor> Colors { get; set; }

        public CItem()
        {
            this.Colors = new List<CColor>();
        }
        public CItem(CItem item)
        {
            this.Colors = new List<CColor>();

            this.Name = item.Name;
            foreach (var color in item.Colors)
            {
                this.Colors.Add(new CColor(color));
            }
        }
    }
}
