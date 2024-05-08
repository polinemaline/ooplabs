﻿using System.Net.Http;
using System.Threading.Tasks;
using System;

namespace oop2._2
{
    class Request
    {
        static async Task Main(string[] args)
        {
            var client = new HttpClient();
            var urls = new[] { "https://edu.stankin.ru/", "https://www.kinopoisk.ru/", "https://github.com/" };

            var startTime = DateTime.Now;

            var tasks = new Task[urls.Length];
            for (int i = 0; i < urls.Length; i++)
            {
                tasks[i] = GetJSONAsync(client, urls[i], i);
            }

            await Task.WhenAll(tasks);

            var endTime = DateTime.Now;
            Console.WriteLine($"Total time: {endTime - startTime}");
            Console.ReadKey();
        }
        static async Task GetJSONAsync(HttpClient client, string url, int i)
        {
            var response = await client.GetAsync(url);

            if (!response.IsSuccessStatusCode)
            {
                Console.WriteLine($"URL{i + 1}: Error: {response.StatusCode}");
            }
            else
            {
                var JSON = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"URL{i + 1}: {JSON}");
            }
           
        }
    }
}
