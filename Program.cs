namespace NotaAlunoEstruturado;

class Program
{
    static void Main(string[] args)
    {
        double notaF=0;
        double[] nota = new double[3];
        Console.WriteLine("Calcular nota aluno");
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Informe a " + (i + 1) + "ª nota: ");
            nota[i] = double.Parse(Console.ReadLine());
            notaF = notaF + nota[i];
        }
        notaF = nota[0] + nota[1] + nota[2];
        Console.WriteLine("nota final do aluno: " + notaF);
        if(notaF >= 60 )
        Console.WriteLine("APROVADO!");
        else
        Console.WriteLine("REPROVADO!\n" +"Faltam "+(60-notaF)+" pontos para o aluno ser aprovado.");
    }
}
