namespace exercicio_2;
class Program
{
    static void Main(string[] args)
    {

        Contrato_Pessoa_Juridica contrato_Pessoa_Juridica = new Contrato_Pessoa_Juridica("contrato de pessoa jurídica :", 5000.0, "12.345.678/0001-00", "123456789");
        contrato_Pessoa_Juridica.Exibir();

        Contrato_Pessoa_Fisica contrato_Pessoa_Fisica = new Contrato_Pessoa_Fisica("contrato de pessoa física :", 1000.0, "123.456.789-00", 30);
        contratoPessoaFisica.Exibir();
        Console.WriteLine();


    }
        
    
}

