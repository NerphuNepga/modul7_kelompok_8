using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace modul7_kelompok_8
{
    class GlossaryItem103022300148
    {
        public class Glossary
        {
            public string title { get; set; }
            public GloDiv GlossDiv { get; set; }
        }
        public class GloDiv
        {
            public string title { get; set; }
            public GloLis GlossList { get; set; }
        }
        public class GloLis
        {
            public GloEnt GlossEntry { get; set; }
        }
        public class GloEnt
        {
            public string ID { get; set; }
            public string SortAs { get; set; }
            public string GlossTerm { get; set; }
            public string Acronym { get; set; }
            public string Abbrev { get; set; }
            public GloDef GlossDef { get; set; }
            public string GlossSee { get; set; }
        }
        public class GloDef
        {
            public string para { get; set; }
            public List<string> GlossSeeAlso { get; set; }
        }
        public Glossary glossary { get; set; }
        public static void ReadJSON()
        {
            String jsonString = File.ReadAllText("D:\\Kuliah\\KPL\\jurnal\\jurnal7_3_103022300148.json");
            var options = new JsonSerializerOptions
            {
                IncludeFields = true
            };
            GlossaryItem103022300148 json = JsonSerializer.Deserialize<GlossaryItem103022300148>(jsonString, options);
            Console.WriteLine("ID : " + json.glossary.GlossDiv.GlossList.GlossEntry.ID);
            Console.WriteLine("SortAs : " + json.glossary.GlossDiv.GlossList.GlossEntry.SortAs);
            Console.WriteLine("GlossTerm : " + json.glossary.GlossDiv.GlossList.GlossEntry.GlossTerm);
            Console.WriteLine("Acronym : " + json.glossary.GlossDiv.GlossList.GlossEntry.Acronym);
            Console.WriteLine("Abbrev : " + json.glossary.GlossDiv.GlossList.GlossEntry.Abbrev);
            Console.WriteLine("GlossDef : ");
            Console.WriteLine("             GD Para : " + json.glossary.GlossDiv.GlossList.GlossEntry.GlossDef.para);
            Console.WriteLine("             GD GlossSeeAlso : " + json.glossary.GlossDiv.GlossList.GlossEntry.GlossDef.GlossSeeAlso[0] + ", " 
                + json.glossary.GlossDiv.GlossList.GlossEntry.GlossDef.GlossSeeAlso[1]);
            Console.WriteLine("GlossSee : " + json.glossary.GlossDiv.GlossList.GlossEntry.GlossSee);
        }
    }
}
