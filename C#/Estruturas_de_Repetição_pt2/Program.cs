using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estruturas_de_Repetição_pt2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Avalie o meu atendimento em uma nota de 0 à 5.");
            Console.Write("Digite: ");
            string notaDigitada = Console.ReadLine();
            int.TryParse(notaDigitada, out int nota);

            Console.WriteLine();

            //Switch --> usado sempre que a informação é certa e fixa

            switch (nota)
            {
                case 0:
                    Console.WriteLine("Atendimento péssimo.");
                    Console.WriteLine("Sua puta.");
                    break; // --> faz o switch parar
                case 1:
                case 2:
                    Console.WriteLine("Atendimento ruim.");
                    Console.WriteLine("Obrigado por me avaliar.");
                    break;
                case 3:
                    Console.WriteLine("Atendimento regular.");
                    Console.WriteLine("Obrigado por me avaliar.");
                    break;
                case 4:
                    Console.WriteLine("Atendimento bom.");
                    Console.WriteLine("Obrigado por me avaliar.");
                    break;
                case 5:
                    Console.WriteLine("Atendimento ótimo.");
                    Console.WriteLine("Obrigado por me avaliar.");
                    break;
                default: // --> fora das informações no case
                    Console.WriteLine("Nota informada fora do padão de análise.");
                    break;

            }

            //FOR == PARA --> quando achar o valor final para

            Console.WriteLine("Deve ser impresso até o número 5 \n");

            for(int valor = 1; valor <= 5; valor++)
            {
                Console.WriteLine(valor);
            }*/

            Console.WriteLine("-------------------------");
            Console.WriteLine("Teste de Mesa \n");
            int x1 = 4; 
            int y1 = x1 + 2;

            for(int i1 =0; i1 < x1; i1++)
            {
                Console.WriteLine("X = "+x1+" | y = "+y1);
                y1 = y1 + i1;
            }
            Console.WriteLine("\n -------------------------");

        }
    }
}
