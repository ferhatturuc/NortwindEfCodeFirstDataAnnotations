using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using NortwindEfCodeFirstDataAnnotations.Entities;

namespace NortwindEfCodeFirstDataAnnotations.Contexts
{
    public class NorthwindContext:DbContext
    {
        public DbSet<Musteri> Müsteriler { get; set; }
        public DbSet<Siparis> Siparisler { get; set; }
    }
}
