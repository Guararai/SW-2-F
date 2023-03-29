namespace davi;
class Program
{
    static void Main(string[] args)
    {
     Produto p1 = new Produto();

     p1.AlteraNome("Redragon Kumara PRO");
     p1.AlteraPreco(7.00);

     p1.MostraDados();
    }
}
