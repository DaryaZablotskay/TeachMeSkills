using Newtonsoft.Json;
using System;
using System.IO;

namespace homework11
{
    class Program
    {
        static void Main(string[] args)
        {
            var caffe1 = new Caffe()
            { 
                Name="Cat",
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
                Name = "Dog",
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
                Name = "Pet",
                Emploee = 7,
                Information = new Information
                {
                    Street = "",
                    City = "Minsk",
                    PhoneNumber = 3820790
                }
            };
            FileStream stream = File.Open("caffe.json", FileMode.OpenOrCreate);
            JsonSerializer js = new JsonSerializer();
            var sw = new StreamWriter(stream);
            js.Serialize(sw, caffe1);
            sw.Flush();

            stream.Seek(0, SeekOrigin.Begin);

            //var streamReader = new StreamReader(stream);
            //var deserializedObj = (Caffe)js.Deserialize(streamReader, typeof(Caffe));
            //Console.WriteLine(deserializedObj);

            stream.Close();
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
