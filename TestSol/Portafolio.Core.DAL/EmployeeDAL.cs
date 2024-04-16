using Microsoft.EntityFrameworkCore;
using Portafolio.Core.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portafolio.Core.DAL
{
    public class EmployeeDAL : DbContext
    {

        public EmployeeDAL(DbContextOptions<EmployeeDAL> opt) : base(opt)
        {
            
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
