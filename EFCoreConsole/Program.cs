using EFCoreConsole.DbContexts;
using EFCoreConsole.Entities;
using Microsoft.EntityFrameworkCore;

using var db = new Context();

// Apenas cria o banco de dados se não estiver criado
db.Database.EnsureCreated();

var filme = db.Filmes.Find(1);
if (filme != null)
{
    // Edita o filme
    // Diretor diretor = new Diretor() { Nome = "Lucas " };
    // filme.Diretor = diretor;
    
    // Remove o filme
    // db.Remove(filme);

    // Salva as mudanças
    db.SaveChanges();
}

// Lista todos os filmes
var filmes = db.Filmes.ToList();
foreach (var item in filmes)
{
    Console.WriteLine($"{item.Id} {item.Titulo}");
}