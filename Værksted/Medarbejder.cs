namespace Værksted;

public abstract class Medarbejder
{
    private string _navn;
    private string _adresse;
    private const int _timerPrUge = 37;
    private CprNr cpr;

    public Medarbejder(CprNr cpr,string navn, string adresse)
    {
        this.cpr = cpr;
        this._navn = navn;
        this._adresse = adresse;
    }

    public string Navn
    {
        get { return _navn; }
        set { _navn = value; }
    }

    public string Adresse
    {
        get => _adresse;
        set => _adresse = value;
    }

    public abstract double beregnUgeLøn();

    public int TimerprUge
    {
        get { return _timerPrUge; }
    }

    public CprNr Cpr => cpr;

    public override string ToString()
    {
        return $"Navn: {Navn} \n Cpr: {cpr} \n Adresse: {Adresse}" ;
    }
}