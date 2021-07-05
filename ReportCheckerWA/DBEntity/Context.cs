/*
 * Author: 
 * Created: 
 * Description: 
 */
using System;
using System.Data.Entity;
using DBEntity.Migrations;
using DBEntity.Models;
using DBEntity.Models.Buddies;

namespace DBEntity
{
    /// <summary>
    /// Description of Context.
    /// </summary>
    internal class Context : DbContext
    {
        public DbSet<DBUser> Users { get; set; }
        public DbSet<DBDateAndListItem> DateAndListItems { get; set; }
        public DbSet<DBItem> Items { get; set; }
        public DbSet<DBColor> Colors { get; set; }
        public DbSet<DBSize> Sizes { get; set; }

        public Context() : base(@"Data source=.\ELESSA; Initial Catalog=ReportChecker; Integrated security=SSPI; MultipleActiveResultSets=true")
        {
            if (!this.Database.Exists())
            {
                setupForFirstTime();
            }
            var initializer = new MigrateDatabaseToLatestVersion<Context, Configuration>();
            Database.SetInitializer(initializer);
            Database.Initialize(false);
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new DBUserMap());
            modelBuilder.Configurations.Add(new DBDateAndListItemMap());
            modelBuilder.Configurations.Add(new DBItemMap());
            modelBuilder.Configurations.Add(new DBColorMap());
            modelBuilder.Configurations.Add(new DBSizeMap());
        }

        private void setupForFirstTime()
        {
            var colors = new[] { "Trắng", "Đen", "Đỏ", "Cam", "Nâu", "Be", "Vàng", "Hồng", "Xanh", "Tím", "Kem" };
            foreach (var color in colors)
            {
                this.Colors.Add(new DBColor() { Name = color });
            }
            this.Users.Add(new DBUser() { Username = "admin", Password = "123" });
            this.SaveChanges();
        }
    }
}
