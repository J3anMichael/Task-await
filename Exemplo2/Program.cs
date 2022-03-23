using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo2
{
    class Program
    {
        static async Task Main(string[] args)
        {
            List<string> list = new List<string>();
            Console.WriteLine("Quantos números?");
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                list.Add(name);
            }


            Console.WriteLine("Aguarde...");


            await Aguardar(5);

            foreach (string name in list)
            {
                Console.WriteLine("Nome: " + name);
            }

            Console.ReadKey();
        }

        static async Task Aguardar(int tempo)
        {
            Console.WriteLine("Registrando...\n");
            await Task.Delay(TimeSpan.FromSeconds(tempo));
            Console.WriteLine("Conclúido!");
        }


    }
}
