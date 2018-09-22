public class HabitationIndividuelle : Habitation
{
    public int NbPieces;
    public bool Piscine;


    public HabitationIndividuelle(string proprietaire, string adresse, double surface, int NbPieces, bool Piscine)
    {
        this.proprietaire = proprietaire;
        this.adresse = adresse;
        this.surface = surface;
        this.NbPieces = NbPieces;
        this.Piscine = Piscine;
    }

    protected override void Affiche()
    {
        base.Affiche();
        Console.WriteLine("Proprietaire : " + this.proprietaire + ", adresse : " + this.adresse +
        ", surface : " + this.surface + ", nb pièces : " + this.NbPieces);
        if (this.Piscine == True) 
        {
            Console.WriteLine("Piscine : Oui")
        }
        else
        {
            Console.WriteLine("Piscine : Non")
        }
    }

    protected override Impot()
    {
        int impot = this.surface * 2 + this.NbPieces * 100
        if (this.Piscine == True)
        {
            impot = impot + 500
        }
        return impot;
    }


}