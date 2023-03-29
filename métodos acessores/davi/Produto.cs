namespace davi;

class Produto
{

    private string? Nome {get;set;}
    public double Preco {get;set;}


    public void MostraDados(){
        Console.WriteLine("Produto: " + this.Nome);
        Console.WriteLine("Preço: " + this.Preco);
    }

    public void AlteraNome(string nome){
        this.Nome = nome;
    }
    public void AlteraPreco(double preco){
        if(preco == 400){this.Preco = preco;}else{Console.WriteLine("Parado ai cidadão");}
        
    }

}