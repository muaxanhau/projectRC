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
    /// Description of DBUserMap.
    /// </summary>
    public class DBUserMap : EntityTypeConfiguration<DBUser>
    {
        public DBUserMap()
        {
            HasKey(c => c.ID);
            Property(p => p.Username).HasMaxLength(200).IsRequired().IsUnicode(false);
            Property(p => p.Password).HasMaxLength(200).IsRequired().IsUnicode(false);
        }
    }
}
