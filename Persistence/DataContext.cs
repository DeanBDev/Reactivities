using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    {
        // Constructor
        public DataContext(DbContextOptions options) : base(options){

        }

        // Classes => Tables
        public DbSet<Activity> Activities {get;set;}
    }
}