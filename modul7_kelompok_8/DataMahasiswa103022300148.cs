using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace modul7_kelompok_8
{
    class DataMahasiswa103022300148
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public class Address { 
            public string streetAddress { get; set; }
            public string city { get; set; }
            public string state { get; set; }
        }
        public Address address { get; set; }
        public class Course
        {
            public string code { get; set; }
            public string name { get; set; }
        }

        public List<Course> courses { get; set; }
        public static void ReadJSON()
        {
            String jsonString = File.ReadAllText("D:\\Kuliah\\KPL\\jurnal\\jurnal7_1_103022300148.json");
            var options = new JsonSerializerOptions
            {
                IncludeFields = true
            };

            DataMahasiswa103022300148 json = JsonSerializer.Deserialize<DataMahasiswa103022300148>(jsonString, options);
            Console.WriteLine("Nama : " + json.firstName + " " + json.lastName);
            Console.WriteLine("Jenis Kelamin : " + json.gender);
            Console.WriteLine("Usia : " + json.age);
            Console.WriteLine("Alamat : Jalan " + json.address.streetAddress + ", Kota " + json.address.city +", Provinsi " + json.address.state);
            for (int i = 0; i < json.courses.Count; i++)
            {
                Console.WriteLine("MK " + (i + 1) + " " + json.courses[i].code + " - " + json.courses[i].name);
            }
        }
    }
}
