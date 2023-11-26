using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Gabor_Daniel_Lab2.Models;

namespace Gabor_Daniel_Lab2.Data
{
    public class Gabor_Daniel_Lab2Context : DbContext
    {
        public Gabor_Daniel_Lab2Context (DbContextOptions<Gabor_Daniel_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Gabor_Daniel_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Gabor_Daniel_Lab2.Models.Publisher>? Publisher { get; set; }
    }
}
