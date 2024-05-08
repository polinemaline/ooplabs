using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop1._2
{
    class AmericanDateTimePrinter : IDateTimePrinter
    {
        public string Print()
        {
            return DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
        }
    }
}
