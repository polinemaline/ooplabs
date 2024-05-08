using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace oop1
{
    
   public class laba1oop
        {
            static void Main(string[] args)
            {
                Console.InputEncoding = Encoding.Unicode;
                Console.OutputEncoding = Encoding.Unicode;
                Number firstNumber = new Number(6, 3);
                Number secondNumber = new Number(-10, 1);
                Console.WriteLine(firstNumber + secondNumber);
                //Console.WriteLine(firstNumber / secondNumber);
                Console.WriteLine("Нажмите любую клавишу для закрытия");
                Console.ReadKey();
            }
   }
 }

