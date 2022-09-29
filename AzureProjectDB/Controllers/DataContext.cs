using AzureProjectDB.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AzureProjectDB.Controllers
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<ErrorViewModel> tableFir { get; set; }
        public  DbSet<TableTest2> TableSecond { get; set; }

    }
}
