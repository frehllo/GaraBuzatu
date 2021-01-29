using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace GaraBuzatu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Numero partecipanti : ");
            int p = int.Parse(Console.ReadLine());
            List<string> partecipanti = new List<string>();
            for (int i = 1; i <= p; i++)
            {
                Console.WriteLine("Nome partecipante : ");
                string nome = Console.ReadLine();
                partecipanti.Add(nome);
                Thread t = new Thread(() => Corri(nome));
                t.Start();
            }
            Console.ReadLine();
        }

        private static void Corri(string nome)
        {
            for (int i = 0; i < 99; i++)
            {
                Console.WriteLine($"{nome} è al km {i + 1}.");
            }
            Console.WriteLine($"{nome} è arrivato al km 100 e ha terminato la gara.");
        }
    }
}
