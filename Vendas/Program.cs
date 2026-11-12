using Vendas.Services;
using Vendas.Contexts;
using Vendas.Models;

string connectionString = "Host=localhost;Port=5432;Database=vendinha;Username=postgres;Password=root123";

using (var context = new VendinhaDbContext(connectionString))
{ 
    var clienteService = new ClienteService(context);

    Cliente cliente = new Cliente("Lucas", "12345678900", new DateTime(2003, 7, 6), "Lucas@gmail.com");

    bool cadastrado = clienteService.AdicionarCliente(cliente);

    if (cadastrado)
    {
        Console.WriteLine("Cliente ID: " + cliente.Id + " cadastrado com sucesso!");
        cliente.PrintDados();
    }
    else
    {
        Console.WriteLine("Não foi possivel cadastrar o cliente.");
    }

    Cliente? clienteExistente = clienteService.ConsultarPorId(3);

    if (clienteExistente != null)
    {
        Cliente clienteAtualizado = new Cliente("Lucas Silva", "12345678900", new DateTime(2003, 7, 6), "LucasBatman@gmail.com");


        clienteAtualizado.Id = cliente.Id;

        bool atualizado = clienteService.AtualizarCliente(clienteAtualizado);

        clienteService.AtualizarCliente(clienteAtualizado);

        Console.WriteLine("Cliente atualizado!");
    }



    
}

    Console.ReadLine();

