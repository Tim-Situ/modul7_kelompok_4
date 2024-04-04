using modul7_kelompok_4;

internal class Program
{
    private static void Main(string[] args)
    {
        DataMahasiswa1302223134 mahasiswa1302223134 = new DataMahasiswa1302223134();
        mahasiswa1302223134.ReadJSON();

        Console.WriteLine();

        TeamMembers1302223134 team1302223134 = new TeamMembers1302223134();
        team1302223134.ReadJSON();
    }
}