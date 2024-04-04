using modul7_kelompok_4;

internal class Program
{
    private static void Main(string[] args)
    {
        DataMahasiswa1302223007 mhs1302223007 = new DataMahasiswa1302223007();
        mhs1302223007.ReadJSON();

        Console.WriteLine("");

        TeamMembers1302223007 team1302223007 = new TeamMembers1302223007();
        team1302223007.ReadJSON();
    }
}