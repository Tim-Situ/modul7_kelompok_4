
using System.Text.Json;

namespace modul7_kelompok_4
{
    public class TeamMembers1302223134
    {
        public class Member
        {
            public String firstName { get; set; }
            public String lastName { get; set; }
            public String gender { get; set; }
            public int age { get; set; }
            public String nim { get; set; }
        }

        public List<Member> members { get; set; }

        public void ReadJSON()
        {
            String filepath = "../../../jurnal7_2_1302223134.json";
            String jsonString = File.ReadAllText(filepath);
            TeamMembers1302223134 dataJSON = JsonSerializer.Deserialize<TeamMembers1302223134>(jsonString);

            Console.WriteLine("Team member list:");
            foreach (var member in dataJSON.members)
            {
                Console.WriteLine($"{member.nim} {member.firstName} {member.lastName} ({member.age} {member.gender})");
            }
        }
    }
}
