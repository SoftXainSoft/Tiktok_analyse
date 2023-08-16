using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiktok_analyse.Class;

namespace Tiktok_analyse
{
    class Program
    {
        // static void Main(string[] args) Hier beginnt der Code
        static void Main(string[] args)
        {
            // Das ist ein Kommentar!

            // Objekt m
            ClassOneMethode m = new ClassOneMethode();
            m.Run("Start");

            // Struktur einer interpolierten Zeichenfolge
            Interpoliert zeichen = new Interpoliert();
            zeichen.Interpol();

            Console.ReadKey();
        }
    }
}
