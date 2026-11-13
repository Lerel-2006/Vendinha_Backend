using Vendas.Services;
using Vendas.Contexts;
using Vendas.Models;

string connectionString = "Host=localhost;Port=5432;Database=vendinha;Username=postgres;Password=root123";

using (var context = new VendinhaDbContext(connectionString))
{
    var clienteService = new ClienteService(context);

    //int idCliente = 50;

    //bool deletado = clienteService.DeletarCliente(idCliente);

    //if (deletado)
    //{
    //    Console.WriteLine("Cliente excluído");
    //}
    //else
    //{
    //    Console.WriteLine("Não foi possível excluir o cliente.");
    //}

    //Cliente? clienteExistente = clienteService.ConsultarPorId(3);

    //if (clienteExistente != null)
    //{
    //    Cliente clienteAtualizado = new Cliente("Lucas Silva", "12345678900", new DateTime(2003, 7, 6), "LucasBatman@gmail.com");


    //    clienteAtualizado.Id = clienteExistente.Id;

    //    bool atualizado = clienteService.AtualizarCliente(clienteAtualizado);

    //    Console.WriteLine(atualizado ? "Cliente atualizado!" : "Não foi possível atualizar o cliente.");
    //}

    //Cliente cliente1 = new Cliente("Faye Valentine", "55555555555", new DateTime(1999, 3, 15), null);


    //bool cadastrado = clienteService.AdicionarCliente(cliente1);

    //if (cadastrado)
    //{
    //    Console.WriteLine("Cliente cadastrado com sucesso!");

    //}
    //else
    //{
    //    Console.WriteLine("Não foi possível cadastrar o cliente.");

    //}

    //Cliente cliente2 = new Cliente("Spike Spiegel", "00000000000", new DateTime(1999, 11, 21), "bebop@gmail.com");

    //bool cadastrado2 = clienteService.AdicionarCliente(cliente2);

    //if (cadastrado2)
    //{
    //    Console.WriteLine("Bem vindo a marte Spike");
    //}
    //else
    //{
    //    Console.WriteLine("Não foi possível cadastrar o cliente.");

    //}

    //Cliente cliente3 = new Cliente("Jet Black", "111", new DateTime(1999, 07, 5));

    //bool cadastrado3 = clienteService.AdicionarCliente(cliente3);

    //if (cadastrado3)
    //{
    //    Console.WriteLine("Cadastrado");
    //}
    //else
    //{
    //    Console.WriteLine("Não foi possível cadastrar o cliente.");
    //}

    //bool Deletado = clienteService.DeletarCliente(3);

    //if (Deletado)
    //{
    //    Console.WriteLine("Cliente excluído.");
    //}
    //else
    //{
    //    Console.WriteLine("Não foi possível excluir o cliente.");
    //}


    Cliente cliente4 = new Cliente("Jonas", "22222222222", new DateTime(2015, 7, 5), "Jonas@hotmail.com");

    bool Cadastrado4 = clienteService.AdicionarCliente(cliente4);

    if (Cadastrado4)
    {
        Console.WriteLine("Cadastrado");
    }
    else
    {
        Console.WriteLine("Não foi possível cadastrar o cliente.");
    }

    Cliente? clienteExistente = clienteService.ConsultarPorId(7);

    if (clienteExistente != null)
    {
        Cliente clienteAtualizado = new Cliente( "Jet Black", "11111111111", new DateTime(1999, 7, 5));


           clienteAtualizado.Id = clienteExistente.Id;

            bool atualizado = clienteService.AtualizarCliente(clienteAtualizado);

            Console.WriteLine(atualizado ? "Cliente atualizado!" : "Não foi possível atualizar o cliente.");
        }

}
Console.ReadLine();

