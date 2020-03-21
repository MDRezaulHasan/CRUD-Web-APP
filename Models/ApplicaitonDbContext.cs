using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CRUD_Web_app.Models
{
    public class ApplicaitonDbContext:DbContext
    {
        public ApplicaitonDbContext(DbContextOptions<ApplicaitonDbContext> options):base(options)
        {

        }
        public DbSet<NewEmpClass>EmployeeTable { get; set; }
    }
}
