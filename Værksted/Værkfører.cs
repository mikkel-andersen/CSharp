namespace Værksted;

public class Værkfører : Mekaniker
{
    private int udnævnelsesDato;
    private double tillæg;

    public Værkfører(CprNr cpr, int udnævnelsesDato, double tillæg, int dato, double loen, string navn, string adresse) 
        : base(cpr, dato, loen, navn, adresse)
    {
        this.udnævnelsesDato = udnævnelsesDato;
        this.tillæg = tillæg;
    }

    public int UdnævnelsesDato
    {
        get => udnævnelsesDato;
        set => udnævnelsesDato = value;
    }

    public double Tillæg
    {
        get { return tillæg; }
        set { tillæg = value; }
    }

    public override double beregnUgeLøn()
    {
        return base.beregnUgeLøn() + tillæg;
    }
}