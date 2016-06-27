using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NorthWindProject.Models
{
    public class NorthWindDb : DbContext
    {
        public DbSet<Shipper> Shippers { get; set; }
    }
}