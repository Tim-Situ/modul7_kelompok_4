using modul7_kelompok_4;

internal class Program
{
    private static void Main(string[] args)
    {
        // dias
        DataMahasiswa1302223134 mahasiswa1302223134 = new DataMahasiswa1302223134();
        mahasiswa1302223134.ReadJSON();

        Console.WriteLine();

        TeamMembers1302223134 team1302223134 = new TeamMembers1302223134();
        team1302223134.ReadJSON();

        Console.WriteLine();

        GlossaryItem1302223134 glossary1302223134 = new GlossaryItem1302223134();
        glossary1302223134.ReadJSON();

        Console.WriteLine();

        // fauzein
        DataMahasiswa1302223127 dataMahasiswa = new DataMahasiswa1302223127();
        dataMahasiswa.ReadJSON();

        Console.WriteLine();

        TeamMembers1302223127 teamMember = new TeamMembers1302223127();
        teamMember.ReadJSON();

        Console.WriteLine();

        GlossaryItem1302223127 glossaryItem = new GlossaryItem1302223127();
        glossaryItem.ReadJSON();

        Console.WriteLine("");

        // haulul
        DataMahasiswa1302223007 mhs1302223007 = new DataMahasiswa1302223007();
        mhs1302223007.ReadJSON();

        Console.WriteLine("");

        TeamMembers1302223007 team1302223007 = new TeamMembers1302223007();
        team1302223007.ReadJSON();

        Console.WriteLine("");

        GlossaryItem1302223007 g1302223007 = new GlossaryItem1302223007();
        g1302223007.ReadJSON();

        Console.WriteLine("");

        // iksan
        DataMahasiswa1302223042 dataMahasiswa1302223042 = new DataMahasiswa1302223042();
        dataMahasiswa1302223042.ReadJSON();

        TeamMembers1302223042 teamMembers1302223042 = new TeamMembers1302223042();
        teamMembers1302223042.ReadJSON();

        GlossaryItem1302223042 glossaryItem1302223042 = new GlossaryItem1302223042();
        glossaryItem1302223042.ReadJSON();
    }
}

