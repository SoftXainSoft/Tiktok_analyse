using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiktok_analyse.Class
{
    internal class ClassOneMethode
    {
        // Die Methode erwattet einen string
        public void Run(string abc)
        {
            // $"interpolierte {Parameter} Zeichenfolge"
            Console.WriteLine($"Der string {abc} ist ein Parameter");
        }
    }
}
