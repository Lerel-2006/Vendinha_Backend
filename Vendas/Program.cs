using Vendas.Services;

Conexao conexao = new Conexao();

using (var banco = conexao.Conectar())
{
    banco.Open();
    Console.WriteLine("Funfou!!");
}