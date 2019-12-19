using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace MiniHackathon.Models
{
    public class DBcontext:DbContext
    {
        public DBcontext(DbContextOptions<DBcontext> options): base(options)
        {
            Database.EnsureCreated();
        }

       
        public DbSet<Doctor> Doctor { get; set; }

        
    }

}
