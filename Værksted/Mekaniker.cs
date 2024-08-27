namespace Værksted;

public class Mekaniker : Medarbejder
{
    private int aarsTal;
    private double loen;

    public Mekaniker(CprNr cpr,int dato, double loen, string navn, string adresse) : base(cpr, navn, adresse)
    {
        aarsTal = dato;
        this.loen = loen;
    }

    public int Dato
    {
        get { return aarsTal; }
        set { aarsTal = value; }
    }

    public double Loen
    {
        get { return loen; }
        set { loen = value; }
    }

    public override double beregnUgeLøn()
    {
        return loen * TimerprUge;
    }

    public override string ToString()
    {
        return base.ToString() + $"\n Svendeår: {Dato}\n Ugeløn: {beregnUgeLøn()} dkk.";
    }
}