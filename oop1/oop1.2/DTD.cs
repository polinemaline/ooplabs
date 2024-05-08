﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop1._2
{
    abstract class DateTimeDecorator : IDateTimePrinter
    {
        protected IDateTimePrinter dateTimePrinter;

        public DateTimeDecorator(IDateTimePrinter dateTimePrinter)
        {
            this.dateTimePrinter = dateTimePrinter;
        }

        public abstract string Print();
    }

}
