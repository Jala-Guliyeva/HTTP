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


            //hhtpclient -sorgu gonderir
            
            
            HttpClient httpClient=new HttpClient();
            //neyise oxumaq istiyende getasync metodunu cagiriiq ve hara atacagimizi qeyd edirik
            var response =httpClient.GetAsync("https://jsonplaceholder.typicode.com/users").Result;
            //content bize geren datadi biz ise onu string tipinden oxuyurq
            //var sadece keyvorddu 
            //object-heryes objectden miras alir
            var responseJsonStr =response.Content.ReadAsStringAsync().Result;

            //Console.WriteLine(responseJsonStr);
            //list olaraq veririk cunki arraydi linkdeki melumat
            List<User> users = JsonConvert.DeserializeObject<List<User>>(responseJsonStr);

            foreach (var u in users)
            {
                Console.WriteLine(u.Name);
                Console.WriteLine(u.Addres);
            }

           
        }
    }
}
