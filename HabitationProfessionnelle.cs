public class HabitationProfessionnelle : Habitation 
{
    public int NbEmployes;

       public HabitationProfessionnelle(string proprietaire, string adresse, double surface, int NbPieces, bool Piscine)
    {
        this.proprietaire = proprietaire;
        this.adresse = adresse;
        this.surface = surface;
        this.NbPieces = NbPieces;
        this.Piscine = Piscine;
    }

}