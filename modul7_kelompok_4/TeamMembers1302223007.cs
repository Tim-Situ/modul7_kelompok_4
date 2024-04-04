using System;
using System.Text.Json;

namespace modul7_kelompok_4
{
    public class TeamMembers1302223007
    {
        public class Members
        {
            public String firstName { get; set; }
            public String lastName { get; set; }
            public String gender { get; set; }
            public int age { get; set; }
            public String nim { get; set; }
        }

        public List<Members> members { get; set; }

        public void ReadJSON()
        {
            string filepath = "../../../jurnal7_2_1302223007.json";
            // membaca dari json
            string jsonString = File.ReadAllText(filepath);
            // deserialize dari json menjadi object
            TeamMembers1302223007 team = JsonSerializer.Deserialize<TeamMembers1302223007>(jsonString);

            Console.WriteLine("Team member list: ");
            foreach (var member in team.members)
            {
                Console.WriteLine(member.nim + " " + member.firstName + " " + member.lastName + " " +
                    "(" + member.age + " " + member.gender + ")");
            }
        }
    }
}

