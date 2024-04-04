using System;
using System.Text.Json;

namespace modul7_kelompok_4
{
	public class GlossaryItem1302223127
	{
		public class Glossary
		{
			public string title { set; get; }
			public GlossDiv GlossDiv { set; get; }
		}

		public class GlossDiv
		{
			public string title { set; get; }
			public GlossList GlossList { set; get; }
		}

		public class GlossList
		{
			public GlossEntry GlossEntry { set; get; }
		}

		public class GlossEntry
		{
			public string ID { set; get; }
			public string SortAs { set; get; }
			public string GlossTerm { set; get; }
			public string Acronym { set; get; }
			public string Abbrev { set; get; }
			public GlossDef GlossDef { set; get; }
			public string GlossSee { set; get; }
        }

		public class GlossDef
		{
			public string para { set; get; }
			public List<String> GlossSeeAlso { set; get; }

        }

        public Glossary glossary { set; get; }

        public void ReadJSON()
		{
            string fileJson = File.ReadAllText("../../../jurnal7_3_1302223127.json");
            GlossaryItem1302223127 dataGlossary = JsonSerializer.Deserialize<GlossaryItem1302223127>(fileJson);

			var dataGlossEntry = dataGlossary.glossary.GlossDiv.GlossList.GlossEntry;

			Console.WriteLine("Glossary Item : ");
			Console.WriteLine($"Judul : {dataGlossary.glossary.title}");
			Console.WriteLine($"Gloss Div : ");
			Console.WriteLine($"Title : {dataGlossary.glossary.GlossDiv.title}");
			Console.WriteLine("Gloss List : ");
			Console.WriteLine("Gloss Entry : ");
			Console.WriteLine($"- ID : {dataGlossEntry.ID}");
			Console.WriteLine($"- SortAs : {dataGlossEntry.SortAs}");
			Console.WriteLine($"- GlossTerm : {dataGlossEntry.GlossTerm}");
			Console.WriteLine($"- Acronym : {dataGlossEntry.Acronym}");
			Console.WriteLine($"- Abbrev : {dataGlossEntry.Abbrev}");
			Console.WriteLine($"- GlossDef :");
			Console.WriteLine($"* Para : {dataGlossEntry.GlossDef.para}");
            Console.Write("* GlossSeeAlso : ");

            foreach (var dataGlossSeeAlso in dataGlossEntry.GlossDef.GlossSeeAlso)
			{
				Console.Write($"{dataGlossSeeAlso} ");
			}

			Console.WriteLine($"\n- GlossSee : {dataGlossEntry.GlossSee}");
        }
	}
}

