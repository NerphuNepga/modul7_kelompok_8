using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace modul7_kelompok_8
{
    class TeamMembers103022300148
    {
        public class Member
        {
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string gender { get; set; }
            public int age { get; set; }
            public string nim { get; set; }
        }

        public List<Member> members{ get; set; }
        public static void ReadJSON()
        {
            String jsonString = File.ReadAllText("D:\\Kuliah\\KPL\\jurnal\\jurnal7_2_103022300148.json");
            var options = new JsonSerializerOptions
            {
                IncludeFields = true
            };

            TeamMembers103022300148 json = JsonSerializer.Deserialize<TeamMembers103022300148>(jsonString, options);
            Console.WriteLine("Team Member List");
            for (int i = 0; i < json.members.Count; i++)
            {
                Console.WriteLine(json.members[i].nim  + " " + json.members[i].firstName + " " + json.members[i].lastName
                    + " ( " + json.members[i].age + " " + json.members[i].gender + " )");
            }
        }
    }
}
