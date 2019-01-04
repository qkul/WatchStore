using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WatchStore.Models
{
    public class WatchStoreContext : DbContext
    {
        public WatchStoreContext (DbContextOptions<WatchStoreContext> options)
            : base(options)
        {
        }

        public DbSet<WatchStore.Models.Watch> Watch { get; set; }
    }
}
