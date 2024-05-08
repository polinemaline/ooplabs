using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop1
{
    public class Number
    {
        public readonly int numerator;
        public readonly int denominator;

        public Number(int numerator, int denominator)
        {
            int flag = 0;
            if (denominator == 0)
            {
                throw new ArgumentException("Denominator cannot be zero.", nameof(denominator));
            }
            int n = Math.Min(Math.Abs(numerator), Math.Abs(denominator));
            for (int i = 2; i <= n; i++)
            {
                if ((numerator % i == 0) && (denominator % i == 0))
                {
                    if (numerator < 0 && denominator < 0)
                    {
                        this.numerator = -1 * (numerator / i);
                        this.denominator = -1 * (denominator / i);
                        flag = 1;
                    }
                    else
                    {
                        this.numerator = numerator;
                        this.denominator = denominator;
                        flag = 1;
                    }
                }
            }

            if (flag == 0)
            {
                this.numerator = numerator;
                this.denominator = denominator;
            }

        }

        public static Number operator -(Number firstNumber) => new Number(-firstNumber.numerator, firstNumber.denominator);
        public static Number operator +(Number firstNumber, Number secondNumber)
        {
            int numerator = firstNumber.numerator * secondNumber.denominator + secondNumber.numerator * firstNumber.denominator;
            int denominator = firstNumber.denominator * secondNumber.denominator;
            int n = Math.Min(Math.Abs(numerator), Math.Abs(denominator));
            for (int i = 2; i <= n; i++)
            {
                if ((numerator % i == 0) && (denominator % i == 0))
                {
                    numerator = numerator / i;
                    denominator = denominator / i;
                }
            }
            return new Number(numerator, denominator);
        }
        public static Number operator -(Number firstNumber, Number secondNumber)
        {
            int numerator = firstNumber.numerator * secondNumber.denominator - secondNumber.numerator * firstNumber.denominator;
            int denominator = firstNumber.denominator * secondNumber.denominator;
            int n = Math.Min(Math.Abs(numerator), Math.Abs(denominator));
            for (int i = 2; i <= n; i++)
            {
                if ((numerator % i == 0) && (denominator % i == 0))
                {
                    numerator = numerator / i;
                    denominator = denominator / i;
                }
            }
            return new Number(numerator, denominator);
        }
        public static Number operator *(Number firstNumber, Number secondNumber)
        {
            int numerator = firstNumber.numerator * secondNumber.numerator;
            int denominator = firstNumber.denominator * secondNumber.denominator;
            int n = Math.Min(Math.Abs(numerator), Math.Abs(denominator));
            for (int i = 2; i <= n; i++)
            {
                if ((numerator % i == 0) && (denominator % i == 0))
                {
                    numerator = numerator / i;
                    denominator = denominator / i;
                }
            }
            return new Number(numerator, denominator);
        }

        public static Number operator /(Number firstNumber, Number secondNumber)
        {
            if (secondNumber.numerator == 0)
            {
                throw new DivideByZeroException();
            }
            int numerator = firstNumber.numerator * secondNumber.denominator;
            int denominator = firstNumber.denominator * secondNumber.numerator;
            int n = Math.Min(Math.Abs(numerator), Math.Abs(denominator));
            for (int i = 2; i <= n; i++)
            {
                if ((numerator % i == 0) && (denominator % i == 0))
                {
                    numerator = numerator / i;
                    denominator = denominator / i;
                }
            }
            return new Number(numerator, denominator);
        }
        public static bool operator !=(Number firstNumber, Number secondNumber)
        {

            return firstNumber.numerator != secondNumber.numerator || firstNumber.denominator != secondNumber.denominator;
        }
        public static bool operator ==(Number firstNumber, Number secondNumber)
        {
            return firstNumber.numerator == secondNumber.numerator && firstNumber.denominator == secondNumber.denominator;
        }
        //public static bool operator <(Numbers firstNumber, Numbers secondNumber)
        //{
        //    return firstNumber.numerator<secondNumber.numerator
        //}
        public override string ToString()
        {
            if (denominator == 1)
            {
                return $"{numerator}";
            }
            else
            {
                return $"{numerator} / {denominator}";
            }
        }
    }
}
