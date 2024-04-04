using System.Text.Json;

namespace modul7_kelompok_4
{
	public class DataMahasiswa1302223127
	{
		public class Address
		{
			public string streetAddress { get; set; }
			public string city { set; get; }
			public string state { set; get; }

        }

		public class Course
		{
			public string code { get; set; }
			public string name { get; set; }
		}

		public string firstName { set; get; }
        public string lastName { set; get; }
        public string gender { set; get; }
        public int age { set; get; }
        public Address address { set; get; }
        public List<Course> courses { set; get; }

		public void ReadJSON()
		{
			string fileJson = File.ReadAllText("../../../jurnal7_1_1302223127.json");
			DataMahasiswa1302223127 dataMahasiswa = JsonSerializer.Deserialize<DataMahasiswa1302223127>(fileJson);

			Console.WriteLine("=== Data Mahasiswa ===");
			Console.WriteLine($"Nama : {dataMahasiswa.firstName} {dataMahasiswa.lastName}");
			Console.WriteLine($"Jenis Kelamin : {dataMahasiswa.gender}");
			Console.WriteLine($"Umur : {dataMahasiswa.age}");
			Console.WriteLine($"Alamat : Jln. {dataMahasiswa.address.streetAddress}, {dataMahasiswa.address.city}, {dataMahasiswa.address.state}");
			Console.WriteLine("Mata Kuliah : ");

			foreach(var course in dataMahasiswa.courses)
			{
				Console.WriteLine($"- ({course.code}) {course.name}");
			}
		}
	}
}

