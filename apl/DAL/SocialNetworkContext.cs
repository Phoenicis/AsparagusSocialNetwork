using SocialNetwork.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace SocialNetwork.DAL
{
    public class SocialNetworkContext : DbContext
    {

        public SocialNetworkContext()
        {
            this.Configuration.AutoDetectChangesEnabled = true;
            this.Database.Connection.ConnectionString = @"Data Source=127.0.0.1,1433;Initial Catalog=SocialNetwork1;Integrated Security=true;";
            if(!this.Database.Exists()){
                this.Database.Create();
            }           
        }
           

        public DbSet<User> Users { get; set; }
        public DbSet<Asparagus> Asparaguses { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        //}
    
    }
}