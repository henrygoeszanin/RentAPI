using Microsoft.EntityFrameworkCore;
using Domain.Entities;

namespace Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        // Construtor, injetando as opções do DbContext
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // DbSet para cada entidade
        public DbSet<Locatario> Locatarios { get; set; }
        public DbSet<Imovel> Imoveis { get; set; }
        public DbSet<Locador> Locadores { get; set; }

        // Override opcional do método OnModelCreating para configurações adicionais
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Imovel>()
                .HasOne(i => i.Locador) // Define que um Imovel possui uma relação com um único Locador
                .WithMany(l => l.Imoveis) // Define que um Locador pode ter vários Imoveis
                .HasForeignKey(i => i.LocadorId); // Configura LocadorId como a chave estrangeira na tabela Imovel

            modelBuilder.Entity<Imovel>()
                .HasOne(i => i.Inquilino) // Define que um Imovel possui uma relação com um único Inquilino (Locatário)
                .WithMany() // Como o Inquilino não mantém uma lista de imóveis (propriedade de coleção), deixamos vazio
                .HasForeignKey(i => i.InquilinoId) // Configura InquilinoId como a chave estrangeira na tabela Imovel
                .IsRequired(false); // Define a relação como opcional, permitindo Imoveis sem Inquilino associado
        }
    }
}
