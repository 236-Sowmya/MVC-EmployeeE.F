using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVC_EmployeeE.F.Models;

namespace MVC_EmployeeE.F.Data
{
    public class MVC_EmployeeEFContext : DbContext
    {
        public MVC_EmployeeEFContext (DbContextOptions<MVC_EmployeeEFContext> options)
            : base(options)
        {
        }

        public DbSet<MVC_EmployeeE.F.Models.Employee> Employee { get; set; }
    }
}
