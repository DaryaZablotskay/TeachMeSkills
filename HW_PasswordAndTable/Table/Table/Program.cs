using homework11;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace Table
{
    class Program
    {
        static void Main(string[] args)
        {
            var table = new Table<string, int, Information>();
           
            Console.WriteLine("Enput path to file");
            var path = Console.ReadLine();
            //"D:\\TeachMeSkills\\TeachMeSkillls\\TeachMeSkills\\homework11\\homework11\\homework11\\bin\\Debug\\netcoreapp3.1\\caffe.json"
        
            List<Caffe> caffes = new List<Caffe>();

            using (StreamReader streamReader = new StreamReader(path))
            {
                var json = streamReader.ReadToEnd();
                caffes = JsonConvert.DeserializeObject<List<Caffe>>(json);
            }

            using (StreamWriter streamWriter = new StreamWriter(path))
            {
                Console.WriteLine("Do you want to add new row?");
                var answer = Console.ReadLine();
                while (answer == "yes")
                {
                    Console.WriteLine("name:");
                    var name = Console.ReadLine();
                    Console.WriteLine("number of employee:");
                    var empl = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("city, street, phone:");
                    var city = Console.ReadLine();
                    var street = Console.ReadLine();
                    var number = Convert.ToInt32(Console.ReadLine());
                    var info = new Information() { City = city, Street = street, PhoneNumber = number };

                    caffes.Add(new Caffe() { Name = name, Emploee = empl, Information = info });

                    Console.WriteLine("Do you want to add new row?");
                    answer = Console.ReadLine();
                }
                var json = JsonConvert.SerializeObject(caffes, Formatting.Indented);
                streamWriter.WriteLine(json);
            }
            List<Caffe> caffes1 = new List<Caffe>();
            using (StreamReader streamReader = new StreamReader(path))
            {
                var json = streamReader.ReadToEnd();
                caffes1 = JsonConvert.DeserializeObject<List<Caffe>>(json);
            }

            foreach (var item in caffes1)
            {
                table.AddRow(item.Name, item.Emploee, item.Information);
            }
            Heading();
            Console.WriteLine();
            table.Print();
        }
        public static void Heading()
        {
            Console.WriteLine("Input heading");
            var first = Console.ReadLine();
            var second = Console.ReadLine();
            var third = Console.ReadLine();
            Console.WriteLine("{0,-20} | \t {1,-8} | \t {2, -8}", first, second, third);
        }
    }
}
