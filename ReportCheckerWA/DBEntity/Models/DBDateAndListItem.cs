/*
 * Author: 
 * Created: 
 * Description: 
 */
using System;
using System.Collections.Generic;

namespace DBEntity.Models
{
    /// <summary>
    /// Description of CDateAndListItem.
    /// </summary>
    public class DBDateAndListItem
    {
        public int ID { get; set; }
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public virtual DBItem Item { get; set; }
        public virtual DBColor Color { get; set; }
        public virtual DBSize Size { get; set; }
        public int Quantity { get; set; }
    }
}
