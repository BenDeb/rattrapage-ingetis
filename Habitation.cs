public class Habitation
{
    public string proprietaire;
    public string adresse;
    public double surface;


    public Habitation(string proprietaire, string adresse, double surface)
    {
        this.proprietaire = proprietaire;
        this.adresse = adresse;
        this.surface = surface;
    }

    public double Impot()
    {
        return surface * 2;
    }

    protected virtual void Affiche()
    {
        Console.WriteLine("Proprietaire : " + proprietaire + ", adresse : " + adresse +
        ", surface : " + surface);
    }
}