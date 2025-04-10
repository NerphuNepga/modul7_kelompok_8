using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace modul7_kelompok_8
{
    public class TeamMembers103022300050
    {
        public class Members
        {
            public string firstName { get;set;}
            public string lastName { get;set;}
            public string gender { get;set;}
            public int age { get;set;}
            public string nim { get;set;}
        }

        public List<Members> members { get; set;}

        public static void ReadJSON()
        {
            string jsonString = File.ReadAllText("C:\\benkyou, study me\\C#\\Konstruksi Perangkat Lunak\\jurnal modul 7\\modul7_kelompok_8\\jurnal7_2_103022300050.json");
            var options = new JsonSerializerOptions
            {
                IncludeFields = true
            };

            TeamMembers103022300050 data = JsonSerializer.Deserialize<TeamMembers103022300050>(jsonString, options);

            Console.WriteLine("Team Members: ");
            for (int i = 0; i < data.members.Count; i++)
            {
                Console.Write(data.members[i].nim);
                Console.Write(" ");
                Console.Write(data.members[i].firstName);
                Console.Write(" ");
                Console.Write(data.members[i].lastName);
                Console.Write(" (");
                Console.Write(data.members[i].gender);
                Console.Write(" ");
                Console.Write(data.members[i].age);
                Console.Write(")");
                Console.WriteLine();
            }
        }
    }
}
