using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenBootcam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string hora;

            Console.WriteLine("¿que hora es?");
            hora = Console.ReadLine();
            Console.WriteLine($"La hora es: {hora}");
            Console.Read();
        }
    }
}
