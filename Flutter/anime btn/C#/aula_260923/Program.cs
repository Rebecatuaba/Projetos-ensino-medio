using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_260923
{
    class Program
    {
        static void Main(string[] args)
        {
            /*var saudacao = "ola mundo!".ToUpper();
            Console.WriteLine(saudacao);
            Console.WriteLine("\n");

            var escola = "anchieta".ToUpper().Insert(8, " é uma boa escola");
            Console.WriteLine(escola);
            Console.WriteLine("\n");

            var curso = "CURSO TENNICO".ToLower().Insert(13, " DE INFORMATICA").Replace("tennico", "TECNICO");
            Console.WriteLine(curso);*/

            Console.Write("Digite a nota do aluno: ");
            int nota = int.Parse(Console.ReadLine());

            if (nota >= 5)
            {
                Console.WriteLine("Aluno esta aprovado");
            }
            Console.Write("\n\n");
            Console.WriteLine("Deve ser impresso ate o numero 5");
            for(int i = 1; i<=5; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}