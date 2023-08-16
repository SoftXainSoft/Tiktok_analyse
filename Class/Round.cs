using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiktok_analyse.Class
{
    internal class Round
    {
        public void Kaufmaennisch()
        {
            // Decimal Round - Decimal.Round - Math.Floor
            DecimalRound y = new DecimalRound();
            DecimalRound p = new DecimalRound();
            decimal checkRound = (decimal)999.50;
            Console.WriteLine(y.Round0(checkRound));
            decimal dr = p.Methematik(checkRound);
            Console.WriteLine(dr);
        }
    }
}
