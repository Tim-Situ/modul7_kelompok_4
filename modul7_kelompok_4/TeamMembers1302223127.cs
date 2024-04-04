using System;
using System.Text.Json;

namespace modul7_kelompok_4
{
	public class TeamMembers1302223127
	{
		public class Member
        {
			public String firstName { set; get; }
			public String lastName { set; get; }
            public String gender { set; get; }
            public int age { set; get; }
            public String nim { set; get; }
        }

		public List<Member> members { set; get; }

		public void ReadJSON()
		{
            string fileJson = File.ReadAllText("../../../jurnal7_2_1302223127.json");
            TeamMembers1302223127 dataTeamMember = JsonSerializer.Deserialize<TeamMembers1302223127>(fileJson);

			Console.WriteLine("Team member list : ");

			foreach(var member in dataTeamMember.members)
			{
				Console.WriteLine($"{member.nim} - {member.firstName} {member.lastName} ({member.age} - {member.gender})");
			}
        }
	}
}

