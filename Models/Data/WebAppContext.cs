using Microsoft.EntityFrameworkCore;
using WebApp.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models.Data
{
    public class WebAppContext:DbContext
    {
        public WebAppContext(DbContextOptions<WebAppContext> options) : base(options)
        {

        }

        public DbSet<People> People { get; set; }
        public DbSet<Movie> Movies { get; set; }

    }
}
