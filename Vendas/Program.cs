using Vendas.Services;
using Vendas.Contexts;
using Vendas.Models;

string connectionString = "Host=localhost;Port=5432;Database=vendinha;Username=postgres;Password=root123";

using (var context = new VendinhaDbContext(connectionString))
{
    context.Database.CanConnect();

    Console.WriteLine("Funfou!!");
}