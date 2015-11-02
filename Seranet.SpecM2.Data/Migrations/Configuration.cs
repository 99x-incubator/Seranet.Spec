namespace Seranet.SpecM2.Data.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<Seranet.SpecM2.Data.SpecDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "Seranet.SpecM2.Data.SpecDbContext";
        }

        protected override void Seed(SpecDbContext context)
        {

        }
    }
}
