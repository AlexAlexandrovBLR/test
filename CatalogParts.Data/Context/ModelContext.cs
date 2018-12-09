using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.DomainEntity;


namespace Model.DbContext
{
    public class ModelContext:System.Data.Entity.DbContext
    {
        static ModelContext()
        {
            Database.SetInitializer<ModelContext>(new ModelContentInitializer());
        }
        public ModelContext(string connectionString) : base(connectionString)
        {
          
        }

        public DbSet<AutoPart> AutoParts { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<DomainEntity.AutoModel> Models { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }

    }
}
