using Vendas.Services;
using Vendas.Contexts;
using Vendas.Models;

string connectionString = "Host=localhost;Port=5432;Database=vendinha;Username=postgres;Password=root123";

using (var context = new VendinhaDbContext(connectionString))
{
    var clienteService = new ClienteService(context);
    var dividaService = new DividaService(context);

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


    //Cliente cliente4 = new Cliente("Jonas", "22222222222", new DateTime(2015, 7, 5), "Jonas@hotmail.com");

    //bool Cadastrado4 = clienteService.AdicionarCliente(cliente4);

    //if (Cadastrado4)
    //{
    //    Console.WriteLine("Cadastrado");
    //}
    //else
    //{
    //    Console.WriteLine("Não foi possível cadastrar o cliente.");
    //}

    //Cliente? clienteExistente = clienteService.ConsultarPorId(7);

    //if (clienteExistente != null)
    //{
    //    Cliente clienteAtualizado = new Cliente( "Jet Black", "11111111111", new DateTime(1999, 7, 5));


    //       clienteAtualizado.Id = clienteExistente.Id;

    //        bool atualizado = clienteService.AtualizarCliente(clienteAtualizado);

    //        Console.WriteLine(atualizado ? "Cliente atualizado!" : "Não foi possível atualizar o cliente.");
    //    }




    Cliente? cliente = clienteService.ConsultarPorId(5);

    if (cliente != null)
    {
        Dividas divida2 = new Dividas("Compra de roupas", 100.00m, false, DateTime.Now);

        divida2.IdCliente = cliente.Id;

        bool criada2 = dividaService.AdicionarDivida(divida2);

        Console.WriteLine(criada2 ? "Divida cadastrada"
            : "Cadastro recusado");
    }
    else
    {
        Console.WriteLine("Cliente não encontrado");
    }

    //List <Dividas> dividas = dividaService.Consultar();

    //foreach(var d in dividas)
    //{
    //    d.PrintDados();
    //}

    //List<Dividas> dividasCliente = dividaService.ConsultarPorCliente(cliente.Id);

    //foreach(var d in dividasCliente)
    //{
    //    d.PrintDados();
    //}

    //Dividas? dividaEncontrada = dividaService.ConsultarPorId(3);

    //if (dividaEncontrada != null)
    //{
    //    dividaEncontrada.PrintDados();
    //}
    //else
    //{
    //    Console.WriteLine("Divida não encontrada");
    //}

    bool pagamentoRegistrado = dividaService.RegistrarPagamento(3);

    if (pagamentoRegistrado)
    {
        Console.WriteLine("Pagamento registrado com sucesso!");
    }
    else
    {
        Console.WriteLine("HELL NAH CUH!");
    }

    Cliente clienteExistente = clienteService.ConsultarPorId(8);

    if (clienteExistente != null)
    {
        Cliente clienteAtualizado = new Cliente("Binho", "15615615615", new DateTime(2019, 6, 7));


        clienteAtualizado.Id = clienteExistente.Id;

        bool atualizado = clienteService.AtualizarCliente(clienteAtualizado);

        Console.WriteLine(atualizado ? "Cliente atualizado!" : "Não foi possível atualizar o cliente.");
    }


}
Console.ReadLine();

