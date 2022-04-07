using Http.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;

namespace Http
{
    internal class Program
    {
        static void Main(string[] args)
            //user list oldugu ucun list yaradiriq
            //addresde obyektdi class kimi yaradib proplarini veririk
        {
            Directory.CreateDirectory(@"C:\Users\tu7knjupn\Desktop\Http\Http\Files");
            if (!File.Exists(@"C:\Users\tu7knjupn\Desktop\Http\Http\Files\database.json"))
            {
                File.Create(@"C:\Users\tu7knjupn\Desktop\Http\Http\Files\database.json");
            }

            HttpClient httpClient=new HttpClient();
            var response=httpClient.GetAsync("https://jsonplaceholder.typicode.com/users").Result;
            var responseJsonStr=response.Content.ReadAsStringAsync().Result;

            //Console.WriteLine(responseJsonStr);
            List<User> users = JsonConvert.DeserializeObject<List<User>>(responseJsonStr);

            foreach (var u in users)
            {
                Console.WriteLine(u.Phone);
            }


        }
    }
}
