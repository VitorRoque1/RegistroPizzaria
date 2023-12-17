using ConsoleApp1.Esfihas;
using ConsoleApp1.Mdelos;
using ConsoleApp1.Menus;

internal class RegistrarEsfihas : Menu
{
    public override void Executar(Dictionary<string, Pizza> pizzasRegistradas)
    {
        MenuEsfiha esfiha1 = new MenuEsfiha();
        esfiha1.Menu3();
        EnderecoEsfiha endereco = new EnderecoEsfiha();
        endereco.Endereco();
        Console.Clear();
        PagamentoEsfiha pagamentoEsfiha = new PagamentoEsfiha();
        pagamentoEsfiha.PagamentoEsfihas();
        

    }
}
