using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiktok_analyse.Class
{
    internal class DecimalRound
    {
        private decimal? _x;
        private decimal _y;
        public decimal? x
        {
            get { return _x; }
            set
            {
                if (_x != value)
                {
                    _x = _x.Value;
                }
            }
        }
        public decimal y
        {
            get { return _y; }
            set
            {
                if (_y != value)
                    _y = value;
            }
        }
        public decimal? Round0(decimal a)
        {
            return _x = Decimal.Round(a);
        }
        public decimal Methematik(decimal b)
        {
            return _y = Math.Floor(b);
        }
    }
}
