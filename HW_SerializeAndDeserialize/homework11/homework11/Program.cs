using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace homework11
{
    class Program
    {
        static void Main(string[] args)
        {
            var caffe1 = new Caffe()
            { 
                Name="Napoleon",
                Emploee=10,
                Information =new Information
                {
                    Street="Pushkina",
                    City="Minsk",
                    PhoneNumber=1234566
                }
            };
            var caffe2 = new Caffe()
            {
                Name = "Corgi",
                Emploee = 12,
                Information = new Information
                {
                    Street = "MinskMir",
                    City = "Minsk",
                    PhoneNumber = 9864389
                }
            };
            var caffe3 = new Caffe()
            {
                Name = "Sweety",
                Emploee = 7,
                Information = new Information
                {
                    Street = "Malinovka",
                    City = "Minsk",
                    PhoneNumber = 3820790
                }
            };
            List<Caffe> caffe = new List<Caffe>() { caffe1, caffe2, caffe3 };

            List<Caffe> obj = new List<Caffe>();

            using (StreamWriter streamWriter = new StreamWriter("caffe.json"))
            {
                var json = JsonConvert.SerializeObject(caffe, Formatting.Indented);
                streamWriter.WriteLine(json);
            }

            using(StreamReader streamReader = new StreamReader("caffe.json"))
            {
                var json = streamReader.ReadToEnd();
                obj = JsonConvert.DeserializeObject<List<Caffe>>(json);
            }

            foreach (var item in obj)
            {
                Console.WriteLine(item);
            }
        }
    }
    public class Caffe
    {
        public string Name { get; set; }
        public int Emploee { get; set; }
        public Information Information { get; set; }
        public Caffe()
        {
        }

        public override string ToString()
        {
            return $"{Name} {Emploee} {Information}";
        }
    }
    public class Information
    { 
        public string Street { get; set; }
        public string City { get; set; }
        public int PhoneNumber { get; set; }
        public override string ToString()
        {
            return $"{City} {Street} {PhoneNumber}";
        }
    }

}
