//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading;
//using System.Threading.Tasks;

//namespace oop2
//{

//    internal class Program
//    {

//        async static Task Main(string[] args)
//        {
//            await PrintAsync();   // вызов асинхронного метода
//            void Print()
//            {
//                Thread.Sleep(3000);     // имитация продолжительной работы
//                Console.WriteLine("Hello METANIT.COM");
//            }

//            // определение асинхронного метода
//            async Task PrintAsync()
//            {
//                Console.WriteLine("Начало метода PrintAsync"); // выполняется синхронно
//                await Task.Run(() => Print());                // выполняется асинхронно
//                Console.WriteLine("Конец метода PrintAsync");
//            }
//            Console.ReadKey();
//        }
//    }
//}
using System;
using System.Net.Http;

namespace oop2
{
    class Request
    {
        static void Main(string[] args)
        {
            var client = new HttpClient();
            var urls = new[] { "https://edu.stankin.ru/", "https://www.kinopoisk.ru/", "https://github.com/" };

            var startTime = DateTime.Now;
            for (int i = 0; i < urls.Length; i++)
            {
                var response = client.GetAsync(urls[i]).Result;
                if (!response.IsSuccessStatusCode)
                {
                    Console.WriteLine($"URL{i + 1}: Error: {response.StatusCode}");
                }
                else
                {
                    var JSON = response.Content.ReadAsStringAsync().Result;
                    Console.WriteLine($"URL{i + 1}: {JSON}");
                }
            }
            var endTime = DateTime.Now;
            Console.WriteLine($"Total time: {endTime - startTime}");
            Console.ReadKey();
        }
    }
}