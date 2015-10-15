using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC_test_task.Models
{
    public class DataContext : DbContext
    {
        public DbSet<ListModel> Lists { get; set; }
    }
}