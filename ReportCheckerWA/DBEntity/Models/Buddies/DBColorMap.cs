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
    /// Description of CColorMap.
    /// </summary>
    public class DBColorMap : EntityTypeConfiguration<DBColor>
    {
        public DBColorMap()
        {
            HasKey(c => c.ID);
            Property(p => p.Name).HasMaxLength(200).IsRequired().IsUnicode(true);
        }
    }
}
