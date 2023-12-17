using ConsoleApp1.Mdelos;
using ConsoleApp1.Menus;



namespace ConsoleApp1.Mdelos;

internal class RegistrarPizza : Menu
{
    public string Nome;
    public string Troco;
    
    public override void Executar(Dictionary<string, Pizza> pizzasRegistradas)
    {


        MenuPizza pizza1 = new MenuPizza();
        pizza1.Menu2();
        EnderecoPizza endereco = new EnderecoPizza();
        endereco.Endereco();
        Console.Clear();
        PagamentoPizza pagamento = new PagamentoPizza();
        pagamento.PagamentaPizza();

        


    }




}