using Rest.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Rest.DAL
{
    public class DbInitializer : DropCreateDatabaseIfModelChanges<DataClassContext>
    {
        protected override void Seed(DataClassContext context)
        {
            context.dataClass.Add(new DataClass() { Id = 1, name = "renata" });
            context.SaveChanges();
            base.Seed(context);
        }
    }
}