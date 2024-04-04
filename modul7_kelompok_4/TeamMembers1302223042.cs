using System.Runtime.CompilerServices;
using System.Text.Json;

namespace modul7_kelompok_4
{
    public class TeamMembers1302223042
    {
        public class Members
        {
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string gender { get; set; }
            public int age { get; set; }
            public string nim {  get; set; }
        }

        public List<Members> members { get; set; }

        public void ReadJSON()
        {
            string filepath = "../../../json/jurnal7_2_1302223042.json";
            //Baca file Json yang diinginkan
            string jsonString = File.ReadAllText(filepath);
            //Deserialize file json menjadi object
            TeamMembers1302223042 teamMembers = JsonSerializer.Deserialize<TeamMembers1302223042>(jsonString);
            Console.WriteLine("\nTeam member list:");

            foreach (var member in teamMembers.members)
            {
                Console.WriteLine($"{member.nim} {member.firstName} {member.lastName} ({member.age} {member.gender})");
            }
        }
    }
}
