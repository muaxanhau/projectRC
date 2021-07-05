/*
 * Author: 
 * Created: 
 * Description: 
 */
using System;
using System.Data.Entity.Migrations;
using System.Linq;

namespace DBEntity.Migrations
{
    /// <summary>
    /// Description of Configuration.
    /// </summary>
    internal sealed class Configuration : DbMigrationsConfiguration<Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }
        protected override void Seed(Context context)
        {

            base.Seed(context);
        }
    }
}
