using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_await
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Tecle algo para iniciar...\n");
            Console.ReadKey();

            await Aguardar(5);

            Console.WriteLine("Já passou 5 segundos ...\n");
            Console.WriteLine("fim");
            Console.ReadLine();
        }

        static async Task Aguardar(int tempo)
        {
            Console.WriteLine("Iniciando espera...");
            await Task.Delay(TimeSpan.FromSeconds(tempo));
            Console.WriteLine("Fim da espera...");
        }
    }
}
