using EFCoreConsole.DbContexts;
using EFCoreConsole.Entities;
using Microsoft.EntityFrameworkCore;

// Apenas cria o banco de dados se não estiver criado
using (var context = new Context())
{ 
    context.Database.EnsureCreated();
}

using var db = new Context();

var filme = db.Filmes.Find(1);
if (filme != null)
{
    db.Remove(filme);
    db.SaveChanges();
}

// Lista todos os filmes
var filmes = db.Filmes.ToList();
foreach (var item in filmes)
{
    Console.WriteLine($"{item.Id} {item.Titulo}");
}