using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PageSalesMvcWeb.Models;

namespace PageSalesMvcWeb.Data
{
    public class PageSalesMvcWebContext : DbContext
    {
        public PageSalesMvcWebContext (DbContextOptions<PageSalesMvcWebContext> options)
            : base(options)
        {
        }

        public DbSet<PageSalesMvcWeb.Models.Department> Department { get; set; } = default!;
        public DbSet<PageSalesMvcWeb.Models.Seller> Seller { get; set; }
        public DbSet<PageSalesMvcWeb.Models.SalesRecord> SalesRecord { get; set; }
    }
}
