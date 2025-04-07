using EFCoreConsole.DbContexts;
using Microsoft.EntityFrameworkCore;

using (var context = new Context())
{ 
    context.Database.EnsureCreated();
}