using System.Text.Json;
using static modul7_kelompok_4.GlossaryItem1302223134.Glossary.GlossDivClass.GlossListClass;

namespace modul7_kelompok_4
{
    public class GlossaryItem1302223134
    {
        public Glossary glossary {  get; set; }
        public class Glossary
        {
            public String title { get; set; }
            public GlossDivClass GlossDiv {  get; set; }
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
            String filepath = "../../../jurnal7_3_1302223134.json";
            String jsonString = File.ReadAllText(filepath);
            GlossaryItem1302223134 dataJSON = JsonSerializer.Deserialize<GlossaryItem1302223134>(jsonString);

            GlossEntryClass glossEntry = dataJSON.glossary.GlossDiv.GlossList.GlossEntry;
            Console.WriteLine($"ID: { glossEntry.ID }");
            Console.WriteLine($"Sort as: { glossEntry.SortAs }");
            Console.WriteLine($"Gloss term: { glossEntry.GlossTerm }");
            Console.WriteLine($"Acronym: { glossEntry.Acronym}");
            Console.WriteLine($"Abbrev: { glossEntry.Abbrev}");
            Console.WriteLine($"Def para: { glossEntry.GlossDef.para}");
            Console.WriteLine("See also: ");
            foreach (var seeAlso in glossEntry.GlossDef.GlossSeeAlso)
            {
                Console.WriteLine($"   {seeAlso}");
            }
            Console.WriteLine($"Gloss see: { glossEntry.GlossSee}");
        }
    }
}
