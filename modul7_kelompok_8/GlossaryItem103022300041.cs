using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace modul7_kelompok_8
{
    class GlossaryItem103022300041
    {
        public class GlossDef
        {
            public string para { get; set; }
            public List<string> GlossSeeAlso { get; set; }
        }

        public class GlossEntry
        {
            public string ID { get; set; }
            public string SortAs { get; set; }
            public string GlossTerm { get; set; }
            public string Acronym { get; set; }
            public string Abbrev { get; set; }
            public GlossDef GlossDef { get; set; }
            public string GlossSee { get; set; }
        }

        public class GlossList
        {
            public GlossEntry GlossEntry { get; set; }
        }

        public class GlossDiv
        {
            public string title { get; set; }
            public GlossList GlossList { get; set; }
        }

        public class Glossary
        {
            public string title { get; set; }
            public GlossDiv GlossDiv { get; set; }
        }

        public Glossary glossary { get; set; }

        public static void ReadJSON()
        {
            string jsonString = File.ReadAllText("D:\\Dokumen Kuliah\\Semester 4\\Konstruksi Perangkat Lunak Praktikum\\JurnalMod7\\modul7_kelompok_8\\jurnal7_3_103022300041.json");
            var options = new JsonSerializerOptions
            {
                IncludeFields = true
            };
            GlossaryItem103022300041 data = JsonSerializer.Deserialize<GlossaryItem103022300041>(jsonString, options);
            
            Console.WriteLine("ID : " + data.glossary.GlossDiv.GlossList.GlossEntry.ID);
            Console.WriteLine("SortAs : " + data.glossary.GlossDiv.GlossList.GlossEntry.SortAs);
            Console.WriteLine("GlossTerm : " + data.glossary.GlossDiv.GlossList.GlossEntry.GlossTerm);
            Console.WriteLine("Acronym : " + data.glossary.GlossDiv.GlossList.GlossEntry.Acronym);
            Console.WriteLine("Abbrev : " + data.glossary.GlossDiv.GlossList.GlossEntry.Abbrev);
            Console.WriteLine("GlossDef (para) : " + data.glossary.GlossDiv.GlossList.GlossEntry.GlossDef.para);
            Console.WriteLine("GlossDef (GlossSeeAlso) : [" + data.glossary.GlossDiv.GlossList.GlossEntry.GlossDef.GlossSeeAlso[0] + ", "
                + data.glossary.GlossDiv.GlossList.GlossEntry.GlossDef.GlossSeeAlso[1] + "]");
            Console.WriteLine("GlossSee : " + data.glossary.GlossDiv.GlossList.GlossEntry.GlossSee);

        }
    }
}
