using System;
using System.Text.Json;

namespace modul7_kelompok_4
{
	public class DataMahasiswa1302223007
	{
        public class Address
        {
            public String streetAddress { get; set; }
            public String city { get; set; }
            public String state { get; set; }
        }

        public class Courses
        {
            public String code { get; set; }
            public String name { get; set; }
        }

        public String firstName { get; set; }
        public String lastName { get; set; }
        public String gender { get; set; }
        public int age { get; set; }
        public Address address { get; set; }
        public List<Courses> courses { get; set; }

        public void ReadJSON()
        {
            string filepath = "../../../jurnal7_1_1302223007.json";
            // membaca dari json
            string jsonString = File.ReadAllText(filepath);
            // deserialize dari json menjadi object
            DataMahasiswa1302223007 mhs = JsonSerializer.Deserialize<DataMahasiswa1302223007>(jsonString);

            Console.WriteLine("Fullname\t: " + mhs.firstName + " " + mhs.lastName);
            Console.WriteLine("Gender\t\t: " + mhs.gender);
            Console.WriteLine("Age\t\t: " + mhs.age);
            Console.WriteLine("Address\t\t: " + mhs.address.streetAddress + ", " + mhs.address.city + ", " + mhs.address.state);
            Console.WriteLine("Courses enrolled: ");
            int i = 0;
            foreach (var course in mhs.courses)
            {
                Console.WriteLine((i + 1) + ". " + course.code + " - " + course.name);
                i++;
            }
        }
    }
}

