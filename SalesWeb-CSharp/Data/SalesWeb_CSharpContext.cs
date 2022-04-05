#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWeb_CSharp.Models;

namespace SalesWeb_CSharp.Data
{
    public class SalesWeb_CSharpContext : DbContext
    {
        public SalesWeb_CSharpContext (DbContextOptions<SalesWeb_CSharpContext> options)
            : base(options)
        {
        }

        public DbSet<SalesWeb_CSharp.Models.Department> Department { get; set; }
    }
}
