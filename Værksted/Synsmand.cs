namespace Værksted;

public class Synsmand : Mekaniker
{
    private int antalSyn;

    public Synsmand(CprNr cpr, int antalSyn, int dato, double loen, string navn, string adresse) : base(cpr, dato, loen, navn, adresse)
    {
        this.antalSyn = antalSyn;
    }

    public override double beregnUgeLøn()
    {
        return antalSyn * 290;
    }
}