using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo3
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            List<string> dados = new List<string>();
            Console.WriteLine("Cadastre seus dados: ");
            Console.WriteLine();
            
            for (int i = 0; i < 1; i++)
            {
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                dados.Add(nome);
                Console.Write("Idade: ");
                string idade = Console.ReadLine();
                dados.Add(idade);
                Console.Write("Cidade: ");
                string cidade = Console.ReadLine();
                dados.Add(cidade);
                Console.Write("Cor Favorita: ");
                string cor = Console.ReadLine();
                dados.Add(cor);

            }
            dados.Sort();

          await Timer(5);

            foreach (string dado in dados)
            {
                Console.WriteLine(dados);
            }

            Console.ReadKey();

             async Task Timer(int interval)
            {
                Console.WriteLine("Registrando...\n");
                await Task.Delay(TimeSpan.FromSeconds(interval));
                Console.WriteLine("Conclúido!");
            }

        }
    }
}
