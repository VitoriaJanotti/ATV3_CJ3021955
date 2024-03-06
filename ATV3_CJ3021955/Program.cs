namespace ATV3_CJ3021955
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite as 5 notas do aluno (em linhas diferentes), para calcularmos a média. ");
            float nota1 = float.Parse(Console.ReadLine());
            float nota2 = float.Parse(Console.ReadLine());
            float nota3 = float.Parse(Console.ReadLine());
            float nota4 = float.Parse(Console.ReadLine());
            float nota5 = float.Parse(Console.ReadLine());

            float media = (nota1 + nota2 + nota3 + nota4) / 5;

            if (media > 5.9)
            {
                Console.WriteLine("O aluno está aprovado, com a média {0}", media);
            }
            else Console.WriteLine("O aluno será reprovado com média {0}", media);


        }
    }
}
