using EFCoreConsole.DbContexts;
using EFCoreConsole.Entities;
using Microsoft.EntityFrameworkCore;

// Apenas cria o banco de dados se não estiver criado
using (var context = new Context())
{ 
    context.Database.EnsureCreated();
}

using var db = new Context();
// db.Add(new Filme {Titulo="Homem de ferro", Ano=2010});
// db.SaveChanges();

var filmes = db.Filmes.ToList();
foreach (var filme in filmes)
{
    Console.WriteLine(filme.Titulo);
}