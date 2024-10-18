using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using aplicacao1.Models;

namespace aplicacao1.Data
{
    public class aplicacao1Context : DbContext
    {
        public aplicacao1Context (DbContextOptions<aplicacao1Context> options)
            : base(options)
        {
        }

        public DbSet<aplicacao1.Models.Carro> Carro { get; set; } = default!;

        public DbSet<aplicacao1.Models.Endereco> Endereco { get; set; } = default!;

        public DbSet<aplicacao1.Models.Posto> Posto { get; set; } = default!;

        public DbSet<aplicacao1.Models.Usuario> Usuario { get; set; } = default!;

        public DbSet<aplicacao1.Models.Localizacao> Localizacao { get; set; } = default!;
    }
}
