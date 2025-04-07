using EFCoreConsole.Entities;
using Microsoft.EntityFrameworkCore;

namespace EFCoreConsole.DbContexts;

public class Context : DbContext
{
    // Gera a tabela Filmes com base na classe filme
    public DbSet<Filme> Filmes { get; set; }
    // Gera a tabela Diretores com base na classe Diretor
    public DbSet<Diretor> Diretores { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite("Data Source=EFCoreConsole");
}