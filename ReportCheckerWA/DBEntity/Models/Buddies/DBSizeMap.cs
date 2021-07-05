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
    /// Description of CSizeMap.
    /// </summary>
    public class DBSizeMap : EntityTypeConfiguration<DBSize>
    {
        public DBSizeMap()
        {
            HasKey(c => c.ID);
            Property(p => p.Name).HasMaxLength(200).IsRequired().IsUnicode(true);
        }
    }
}
