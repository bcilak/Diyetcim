using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BitirmeDeneme.Models
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext>options)
            :base(options)
        {

        }
        public DbSet<Request> Requests { get; set; }
        public DbSet<Doktor> Doktor { get; set; }
        
        

    }
}
