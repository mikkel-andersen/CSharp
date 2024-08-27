using Værksted;

class Program
{
    static void Main(string[] args)
    {
        var liste = new MedarbejderListe<CprNr>();
        
        var mikkel = new Mekaniker(new CprNr("281099", "0909"), 2010, 200, "Mikkel", "Aarhus");
        var rasmus = new Synsmand(new CprNr("281099", "0909"), 17, 2018, 170, "Rasmus", "Viby");;
        var tully = new Værkfører(new CprNr("281099", "0909"), 2019, 208, 2810, 600, "Tully", "Brabrand");
        
        liste.AddElement(mikkel.Cpr, mikkel);
        liste.AddElement(rasmus.Cpr, rasmus);
        liste.AddElement(tully.Cpr, tully);

        Console.WriteLine(mikkel + "\n");
        Console.WriteLine(rasmus + "\n" );
        Console.WriteLine(tully + "\n");

        Console.WriteLine();

        Console.WriteLine(liste.Size());
        Console.WriteLine(liste.GetElement(tully.Cpr));
        
        
    }
}