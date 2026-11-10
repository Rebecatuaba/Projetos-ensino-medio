using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.Write("Digite a sua idade: ");
            string IdadeDigitada = Console.ReadLine();
            int.TryParse(IdadeDigitada, out int idadeConvertida);

            if (idadeConvertida<18)
            {
                Console.Write("Voce é menor de idade e sua idade é: " + idadeConvertida);
                Console.Write("\n\n");

            }
            else
            {
                Console.Write("Parabens voceé maior de idade e sua idade é: " + idadeConvertida);
                Console.Write("\n\n");
            }
            Console.Write("\n\n");*/

            /*Console.Write("Digite a sua idade: ");
            string IdadeDigitada = Console.ReadLine();
            int.TryParse(IdadeDigitada, out int convIdade);

            if (convIdade >= 10 && convIdade <= 17)
            {
                Console.WriteLine("Voce é adolecente");

            }
            else if (convIdade >= 18 && convIdade <= 35)
            {

                Console.WriteLine("Voce é Jovem");

            }
            else if (convIdade >= 36 && convIdade <= 60)
            {

                Console.WriteLine("Voce já é meia idade");

            }
            else if (convIdade >= 61)
            {

                Console.WriteLine("Voce já é idoso");

            }
            else
            {
                Console.Write("Voce é menor de idade");
            }*/

            Console.Write("Digite sua idade: ");
            string idade = Console.ReadLine();
            int idadeInteiro = int.Parse(idade);
            Console.WriteLine("A idade digitada foi: {0}\n", idadeInteiro);

            Console.Write("Digite um Numero: ");
            string palavra = Console.ReadLine();
            int numero;
            int.TryParse(palavra, out numero);
            Console.WriteLine("Numero passado foi: {0}", numero);
        }
    }
}
