using Interface.Service.Model.SysModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Interface.Service.Services
{
  [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    public class ApplicationDb : SysApplicationDb
    {
      public ApplicationDb()
          : base("DefaultConnection")
        {
            //this.Database.Initialize(false);
        }

       protected override void OnModelCreating(DbModelBuilder modelBuilder)
       {
           base.OnModelCreating(modelBuilder);
       }


       public virtual int Commit()
       {
           return base.SaveChanges();
       }

       public virtual Task<int> CommitAsync()
       {
           return base.SaveChangesAsync();
       }

    }
}
