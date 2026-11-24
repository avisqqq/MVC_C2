using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MojeCV.Models;

namespace MojeCV.Data
{
    public class CvContext : DbContext
    {
        public CvContext (DbContextOptions<CvContext> options)
            : base(options)
        {
        }

        public DbSet<MojeCV.Models.Osoba> Osoba { get; set; } = default!;
        public DbSet<MojeCV.Models.Doswiadczenie> Doswiadczenie { get; set; } = default!;
        public DbSet<MojeCV.Models.Umiejetnosc> Umiejetnosc { get; set; } = default!;
        public DbSet<MojeCV.Models.Wyksztalcenie> Wyksztalcenie { get; set; } = default!;
        public DbSet<MojeCV.Models.Projekt> Projekt { get; set; } = default!;
    }
}
