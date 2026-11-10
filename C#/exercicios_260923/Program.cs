using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicios_260923
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite uma nota: ");
            int nota = int.Parse(Console.ReadLine());
            if (nota>100)
            {
                Console.WriteLine("A nota é maior que a esperada");
            }
            else if (nota == 100)
            {
                Console.WriteLine("O valor é igual a 100");
            }
            else if (nota<100)
            {
                Console.WriteLine("A nota é menor que 100");
            }
            for(int loop = 26; loop < 35; loop++)
            {
                Console.WriteLine(loop);
            }
        }
    }
}
