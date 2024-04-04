using modul7_kelompok_4;

internal class Program
{
    private static void Main(string[] args)
    {
        DataMahasiswa1302223042 dataMahasiswa = new DataMahasiswa1302223042();
        dataMahasiswa.ReadJSON();

        TeamMembers1302223042 teamMembers1302223042 = new TeamMembers1302223042();
        teamMembers1302223042.ReadJSON();
    }
}

