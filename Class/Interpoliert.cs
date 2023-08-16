using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiktok_analyse.Class
{
    internal class Interpoliert
    {
        public void Interpol()
        {
            // Struktur einer interpolierten Zeichenfolge
            string name = "Pascal";
            var date = DateTime.Now;

            // Composite formatting:
            Console.WriteLine("Hello, {0}! Today is {1}, it's {2:HH:mm} now.", name, date.DayOfWeek, date);

            // String interpolation:
            Console.WriteLine($"Hello, {name}! Today is {date.DayOfWeek}, it's {date:HH:mm} now.");
            Console.WriteLine("----------------------------------------------------------");
        }
    }
}
