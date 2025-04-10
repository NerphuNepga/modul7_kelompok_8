using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;


namespace modul7_kelompok_8
{
    class DataMahasiswa103022300041
    {
        public String firstName { get; set; }
        public String lastName { get; set; }
        public String gender { get; set; }
        public int age { get; set; }
        public class Address {
            public String streetAddress { get; set; }
            public String city { get; set; }
            public String state { get; set; }
        }
        public Address address { get; set; }
        public class Course
        {
            public String code { get; set; }
            public String name { get; set; }
        }
        public List<Course> courses { get; set; }

        public static void ReadJSON()
        {
            String jsonString = File.ReadAllText("D:\\Dokumen Kuliah\\Semester 4\\Konstruksi Perangkat Lunak Praktikum\\JurnalMod7\\modul7_kelompok_8\\jurnal7_1_103022300041.json");

            var options = new JsonSerializerOptions
            {
                IncludeFields = true
            };

            DataMahasiswa103022300041 data = JsonSerializer.Deserialize<DataMahasiswa103022300041>(jsonString, options);


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
