using System.Runtime.CompilerServices;
using System.Text.Json;

namespace modul7_kelompok_4
{
    public class DataMahasiswa1302223042
    {
        public class Address
        {
            public string streetAdress { get; set; }
            public string city { get; set; }
            public string state { get; set; }
        }

        public class Courses
        {
            public string code { get; set; }
            public string name { get; set; }
        }

        public string firstName { get; set; }
        public string lastName { get; set; }
        public String gender { get; set; }
        public int age { get; set; } 
        public Address address { get; set; } 
        public List<Courses> courses { get; set; }

        public void ReadJSON()
        {
            string filepath = "../../../json/jurnal7_1_1302223042.json";
            //Baca file Json yang diinginkan
            string jsonString = File.ReadAllText(filepath);
            //Deserialize file json menjadi object
            DataMahasiswa1302223042 mahasiswa = JsonSerializer.Deserialize<DataMahasiswa1302223042>(jsonString);
            Console.WriteLine("===== DATA MAHASISWA ======");
            Console.WriteLine($"Nama : {mahasiswa.firstName} {mahasiswa.lastName}");
            Console.WriteLine($"Kelamin : {mahasiswa.gender}");
            Console.WriteLine($"Umur : {mahasiswa.age}");
            Console.WriteLine($"Alamat : {mahasiswa.address.state}, {mahasiswa.address.city}, {mahasiswa.address.streetAdress}");

            int i = 1;
            foreach (var course in mahasiswa.courses)
            {
                Console.WriteLine($"MK {i} {course.code} - {course.name}");
                i++;
            }
        }
    }
}
