using System;
using System.Text.Json;
using static modul7_kelompok_4.TeamMembers1302223007;

namespace modul7_kelompok_4
{
	public class GlossaryItem1302223007
    {

        public class GlossDef
        {
            public String para { get; set; }
            public List<String> GlossSeeAlso { get; set; }
        }

        public class GlossEntry
        {
            public String ID { get; set; }
            public String SortAs { get; set; }
            public String GlossTerm { get; set; }
            public String Acronym { get; set; }
            public String Abbrev { get; set; }
            public GlossDef GlossDef { get; set; }
            public String GlossSee { get; set; }
        }

        public class GlossList
        {
            public GlossEntry GlossEntry { get; set; }
        }

        public class GlossDiv
        {
            public String title { get; set; }
            public GlossList GlossList { get; set; }
        }

        public class Glossary
        {
            public String title { get; set; }
            public GlossDiv GlossDiv { get; set; }
        }

        public Glossary glossary { get; set; }

        public void ReadJSON()
        {
            string filepath = "../../../jurnal7_3_1302223007.json";
            // membaca dari json
            string jsonString = File.ReadAllText(filepath);
            // deserialize dari json menjadi object
            GlossaryItem1302223007 g = JsonSerializer.Deserialize<GlossaryItem1302223007>(jsonString);

            Console.WriteLine("> " + g.glossary.title);
            Console.WriteLine("\t> " + g.glossary.GlossDiv.title);
            Console.WriteLine("\t\t> " + g.glossary.GlossDiv.GlossList.GlossEntry.ID);
            Console.WriteLine("\t\t> " + g.glossary.GlossDiv.GlossList.GlossEntry.SortAs);
            Console.WriteLine("\t\t> " + g.glossary.GlossDiv.GlossList.GlossEntry.GlossTerm);
            Console.WriteLine("\t\t> " + g.glossary.GlossDiv.GlossList.GlossEntry.Acronym);
            Console.WriteLine("\t\t> " + g.glossary.GlossDiv.GlossList.GlossEntry.Abbrev);
            Console.WriteLine("\t\t\t> " + g.glossary.GlossDiv.GlossList.GlossEntry.GlossDef.para);
            Console.Write("\t\t\t> GrossSeeAlso:");
            int i = 0;
            foreach (var item in g.glossary.GlossDiv.GlossList.GlossEntry.GlossDef.GlossSeeAlso)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine("");
            Console.WriteLine("\t\t> " + g.glossary.GlossDiv.GlossList.GlossEntry.GlossSee);
        }
    }
}

