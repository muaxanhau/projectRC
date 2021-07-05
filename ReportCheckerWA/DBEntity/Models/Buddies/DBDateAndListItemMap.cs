/*
 * Author: 
 * Created: 
 * Description: 
 */
using System;
using System.Data.Entity.ModelConfiguration;

namespace DBEntity.Models.Buddies
{
    /// <summary>
    /// Description of CDateAndListItemMap.
    /// </summary>
    public class DBDateAndListItemMap : EntityTypeConfiguration<DBDateAndListItem>
    {
        public DBDateAndListItemMap()
        {
            HasKey(c => c.ID);
            Property(p => p.Day).IsRequired();
            Property(p => p.Month).IsRequired();
            Property(p => p.Year).IsRequired();
            Property(p => p.Quantity).IsRequired();
        }
    }
}
