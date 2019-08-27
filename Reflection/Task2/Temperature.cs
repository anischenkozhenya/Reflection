using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Temperature : ITemperature
    {
        public double ToForengat(int celsius)
        {
            return (celsius* 9 / 5) + 32;
        }
    }
}
