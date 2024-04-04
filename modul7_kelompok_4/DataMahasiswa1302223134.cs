using System.Text.Json;

namespace modul7_kelompok_4
{
    public class DataMahasiswa1302223134
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public String gender { get; set; }
        public int age { get; set; }
        public Address address { get; set; }

        public class Course
        {
            public String code { get; set; }
            public String name { get; set; }
        }
        public class Address
        {
            public String streetAddress { get; set; }
            public String city { get; set; }
            public String state { get; set; }

        }

        public List<Course> courses { get; set; }


        public void ReadJSON()
        {
            String filepath = "../../../jurnal7_1_1302223134.json";
            String jsonString = File.ReadAllText(filepath);
            DataMahasiswa1302223134 dataJSON = JsonSerializer.Deserialize<DataMahasiswa1302223134>(jsonString);

            Console.WriteLine($"Nama   : {dataJSON.firstName} {dataJSON.lastName}");
            Console.WriteLine($"Gender : {dataJSON.gender}");
            Console.WriteLine($"Usia   : {dataJSON.age}");
            Console.WriteLine($"Alamat : Jalan {dataJSON.address.streetAddress}, " +
                                       $"Kota {dataJSON.address.city}, " +
                                       $"Provinsi {dataJSON.address.state}");
            int i = 1;
            foreach (var course in dataJSON.courses)
            {
                Console.WriteLine($"MK {i} {course.code} - {course.name}");
                i++;
            }
        }

    }
}
