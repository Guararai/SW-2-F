public class Contrato_Pessoa_Juridica:Contrato
{

    private string inscricaoEstadual;
    private string cnpj;

    public Contrato_Pessoa_Juridica(string detalhes, double valor, string cnpj, string inscricao_estadual)
        : base(detalhes, valor)
    {
        this.cnpj = cnpj;
        this.inscricaoEstadual = inscricaoEstadual;
    }

    public override void ExibirDetalhes()
    {
        base.ExibirDetalhes();
        Console.WriteLine("CNPJ: " + cnpj);
        Console.WriteLine("Inscrição Estadual: " + inscricaoEstadual);
    }
}