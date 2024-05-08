using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace oop1._2
{
  
    internal class program
    {
        static void Main(string[] args)
        {
            IDateTimePrinter europeanDateTimePrinter = new EuropeanDateTimePrinter();
            IDateTimePrinter americanDateTimePrinter = new AmericanDateTimePrinter();

            IDateTimePrinter decoratedEuropeanDateTime = new SuffixDecorator(new PrefixDecorator(europeanDateTimePrinter, "POL "), "GOS");
            IDateTimePrinter decoratedAmericanDateTime = new SuffixDecorator(new PrefixDecorator(americanDateTimePrinter, "POL "), "GOS");
            //IDateTimePrinter x = new PrefixDecorator(new SuffixDecorator(new PrefixDecorator(americanDateTimePrinter, "POL "), "GOS"), "111");


            Console.WriteLine("Decorated European DateTime: " + decoratedEuropeanDateTime.Print());
            Console.WriteLine("Decorated American DateTime: " + decoratedAmericanDateTime.Print());
           
            Console.ReadKey();
        }
    }
}
