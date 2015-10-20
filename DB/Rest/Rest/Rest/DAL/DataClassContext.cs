using Rest.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Rest.DAL
{
    public class DataClassContext : DbContext
    {
        public DataClassContext()
            : base("DataClassDB")
        {

        }

        public DbSet<DataClass> dataClass { get; set; }
    }
}