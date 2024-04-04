using modul7_kelompok_4;

internal class Program
{
    private static void Main(string[] args)
    {
        DataMahasiswa1302223127 dataMahasiswa = new DataMahasiswa1302223127();
        dataMahasiswa.ReadJSON();

        Console.WriteLine();

        TeamMembers1302223127 teamMember = new TeamMembers1302223127();
        teamMember.ReadJSON();

        Console.WriteLine();

        GlossaryItem1302223127 glossaryItem = new GlossaryItem1302223127();
        glossaryItem.ReadJSON();
    }
}