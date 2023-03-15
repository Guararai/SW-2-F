namespace ExercicioAlunos;

class Alunos
{



    public string nome(){ 
        Console.Write("Digite seu nome: ");
        string? nome = Console.ReadLine();
        Console.WriteLine("Seu nome é: "+ nome);
        return nome;
    }

        public double notas(){
         Console.Write("Digite sua nota: ");
        double nota1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("O número digitado foi: "+ nota1);
        Console.Write("Digite sua nota: ");
        double nota2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("O número digitado foi: "+ nota2);
        return (nota1+nota2)/2;
    }


    public string obterSituacao(double media){
        string situacao="";
        if(media>=6){
            situacao="Aprovado";
        }else{
            situacao="Reprovado";
        }
        return situacao;

    }
        public void mensagem(){
            string nomea = nome();
            double mediaCalculada = notas();
            string resultadoSituacao = obterSituacao(mediaCalculada);
            Console.WriteLine(nomea+" está "+resultadoSituacao+" com média: "+mediaCalculada);
        }


}