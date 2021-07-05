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
    /// Description of CItemMap.
    /// </summary>
    public class DBItemMap : EntityTypeConfiguration<DBItem>
    {
        public DBItemMap()
        {
            HasKey(c => c.ID);
            Property(p => p.Name).HasMaxLength(200).IsRequired().IsUnicode(true);
        }
    }
}
