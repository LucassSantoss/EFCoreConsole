using EFCoreConsole.DbContexts;
using EFCoreConsole.Entities;
using Microsoft.EntityFrameworkCore;

// Apenas cria o banco de dados se não estiver criado
using (var context = new Context())
{ 
    context.Database.EnsureCreated();
}

using var db = new Context();

// Edita um dado do banco de dados
var filme = db.Filmes.Find(1);
if (filme != null)
{
    filme.Titulo = "Home de ferro 1";
    filme.Diretor = new Diretor() { Nome = "Lucas" };
}
db.SaveChanges();

// Lista todos os filmes
var filmes = db.Filmes.ToList();
foreach (var item in filmes)
{
    if (item != null)
        Console.WriteLine($"{item.Id} {item.Titulo}");
}