using Microsoft.EntityFrameworkCore;
using Ogani_WebUI.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ogani_WebUI.Models.DataContext
{
    public class OganiDbContext: DbContext
    {
        public  OganiDbContext(DbContextOptions options )
            :base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
    }
}
