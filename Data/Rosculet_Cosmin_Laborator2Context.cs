using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Rosculet_Cosmin_Laborator2.Models;

namespace Rosculet_Cosmin_Laborator2.Data
{
    public class Rosculet_Cosmin_Laborator2Context : DbContext
    {
        public Rosculet_Cosmin_Laborator2Context (DbContextOptions<Rosculet_Cosmin_Laborator2Context> options)
            : base(options)
        {
        }

        public DbSet<Rosculet_Cosmin_Laborator2.Models.Book> Book { get; set; } = default!;
        public DbSet<Rosculet_Cosmin_Laborator2.Models.Publisher> Publisher { get; set; } = default!;
        public DbSet<Rosculet_Cosmin_Laborator2.Models.Author> Author { get; set; } = default!;
        public DbSet<Rosculet_Cosmin_Laborator2.Models.Category> Category { get; set; } = default!;
        public DbSet<Rosculet_Cosmin_Laborator2.Models.Member> Member { get; set; } = default!;
        public DbSet<Rosculet_Cosmin_Laborator2.Models.Borrowing> Borrowing { get; set; } = default!;
    }
}
