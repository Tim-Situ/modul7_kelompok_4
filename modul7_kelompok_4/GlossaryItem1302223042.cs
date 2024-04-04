using System.Runtime.CompilerServices;
using System.Text.Json;
using static modul7_kelompok_4.GlossaryItem1302223042.Glossary.GlossDivClass.GlossListClass;

namespace modul7_kelompok_4
{
    public class GlossaryItem1302223042
    {
        public Glossary glossary { get; set; }
        public class Glossary
        {
            public String title { get; set; }
            public GlossDivClass GlossDiv { get; set; }
            public class GlossDivClass
            {
                public String title { get; set; }
                public GlossListClass GlossList { get; set; }
                public class GlossListClass
                {
                    public GlossEntryClass GlossEntry { get; set; }
                    public class GlossEntryClass
                    {
                        public String ID { get; set; }
                        public String SortAs { get; set; }
                        public String GlossTerm { get; set; }
                        public String Acronym { get; set; }
                        public String Abbrev { get; set; }
                        public class GlossDefClass
                        {
                            public String para { get; set; }
                            public List<String> GlossSeeAlso { get; set; }
                        }
                        public GlossDefClass GlossDef { get; set; }
                        public String GlossSee { get; set; }
                    }
                }
            }
        }

        public void ReadJSON()
        {
            string filepath = "../../../json/jurnal7_3_1302223042.json";
            //Baca file Json yang diinginkan
            string jsonString = File.ReadAllText(filepath);
            //Deserialize file json menjadi object
            GlossaryItem1302223042 glossaryItem = JsonSerializer.Deserialize<GlossaryItem1302223042>(jsonString);
            Console.WriteLine("\n\nGloss Entry:");
            GlossEntryClass glossEntry = glossaryItem.glossary.GlossDiv.GlossList.GlossEntry;
            Console.WriteLine($"ID: {glossEntry.ID}");
            Console.WriteLine($"Sort as: {glossEntry.SortAs}");
            Console.WriteLine($"Gloss term: {glossEntry.GlossTerm}");
            Console.WriteLine($"Acronym: {glossEntry.Acronym}");
            Console.WriteLine($"Abbrev: {glossEntry.Abbrev}");
            Console.WriteLine($"GlossDef para : {glossEntry.GlossDef.para}");
            foreach ( var item in glossEntry.GlossDef.GlossSeeAlso)
            {
                Console.WriteLine($"GlossDef GlossSeeAlso : {item}");
            }
            Console.WriteLine($"GlossSee : {glossEntry.GlossSee}");

        }
    }
}
