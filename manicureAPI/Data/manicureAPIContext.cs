using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace manicureAPI.Models
{
    public class manicureAPIContext : DbContext
    {
        public manicureAPIContext (DbContextOptions<manicureAPIContext> options)
            : base(options)
        {
        }

        public DbSet<manicureAPI.Models.Usuario> Usuario { get; set; }
    }
}
