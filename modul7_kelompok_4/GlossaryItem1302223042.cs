using System.Runtime.CompilerServices;
using System.Text.Json;

namespace modul7_kelompok_4
{
    public class GlossaryItem1302223042
    {
        public class GlossDEF
        {
            public string para { get; set;}
            public List<string> GlossSeeAlso { get; set;}
        }

        public class GlossENTRY
        {
            public string ID { get; set; }
            public string SortAs { get; set; }
            public string glossTerm { get; set; }
            public string Acronym { get; set; }
            public string Abbrev { get; set; }
            public GlossDEF GlossDef { get; set; }  
            public string GlossSee { get; set; }
        }

        public class GlossLIST
        {
            public GlossENTRY GlossEntry { get; set;}
        }

        public class GlossDIV
        {
            public string title { get; set; }
            public GlossLIST GlossList { get; set; }
        }

        public class Glossary
        {
            public string title { get; set; }
            public GlossDIV GlossDIV { get; set; }
        }

        public Glossary glossary { get; set; }

        public void ReadJSON()
        {
            string filepath = "../../../json/jurnal7_3_1302223042.json";
            //Baca file Json yang diinginkan
            string jsonString = File.ReadAllText(filepath);
            //Deserialize file json menjadi object
            GlossaryItem1302223042 glossaryItem = JsonSerializer.Deserialize<GlossaryItem1302223042>(jsonString);
            Console.WriteLine("\n\nGloss Entry:");
            var gEntry = glossaryItem.glossary.GlossDIV.GlossList.GlossEntry;
            Console.WriteLine($"ID : {gEntry.ID}");
            Console.WriteLine($"SortAs : {gEntry.SortAs}");
            Console.WriteLine($"GlossTerm : {gEntry.GlossTerm}");
            Console.WriteLine($"Acronym : {gEntry.Acronym}");
            Console.WriteLine($"Abbrev : {gEntry.Abbrec}");
            Console.WriteLine($"GlossDef para : {gEntry.GlossDef.para}");
            Console.WriteLine($"GlossDef GlossSeeAlso : {gEntry.GlossDef.GlossSeeAlso}");
            Console.WriteLine($"GlossSee : {gEntry.GlossSee}");
     
        }
    }
}
