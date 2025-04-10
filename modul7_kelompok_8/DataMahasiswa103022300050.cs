using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace modul7_kelompok_8
{
    public class DataMahasiswa103022300050
    {
        public string firstName { get; set; } 
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }

        public class Address
        {
            public string streetAddress { get; set; }
            public string city { get; set; }
            public string state { get; set; }
        }

        public class Courses
        {
            public string code { get; set; }
            public string name { get; set; }
        }

        public Address address { get; set; }
        public List<Courses> courses { get; set; }

        public static void ReadJSON()
        {
            string jsonString = File.ReadAllText("C:\\benkyou, study me\\C#\\Konstruksi Perangkat Lunak\\jurnal modul 7\\modul7_kelompok_8\\jurnal7_1_103022300050.json");
            var options = new JsonSerializerOptions
            {
                IncludeFields = true
            };

            DataMahasiswa103022300050 data = JsonSerializer.Deserialize<DataMahasiswa103022300050>(jsonString, options);


            Console.WriteLine(data.firstName);
            Console.WriteLine(data.lastName);
            Console.WriteLine(data.gender);
            Console.WriteLine(data.age);
            Console.WriteLine(data.address.streetAddress);
            Console.WriteLine(data.address.city);
            Console.WriteLine(data.address.state);
            for (int i = 0; i < data.courses.Count; i++)
            {
                Console.WriteLine(data.courses[i].code);
                Console.WriteLine(data.courses[i].name);
            }
        }

    }
}
