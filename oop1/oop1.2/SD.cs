using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop1._2
{
    class SuffixDecorator : DateTimeDecorator
    {
        private string suffix;

        public SuffixDecorator(IDateTimePrinter dateTimePrinter, string suffix) : base(dateTimePrinter)
        {
            this.suffix = suffix;
        }

        public override string Print()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(dateTimePrinter.Print());
            sb.Append(" ");
            sb.Append(suffix);
            return sb.ToString();
        }
    }

}
