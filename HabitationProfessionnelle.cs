public class HabitationProfessionnelle : Habitation 
{
    public int NbEmployes;

       public HabitationProfessionnelle(string proprietaire, string adresse, double surface, int NbEmployes)
    {
        this.proprietaire = proprietaire;
        this.adresse = adresse;
        this.surface = surface;
        this.NbEmployes = NbEmployes;
    }

        protected override double Impot()
    {
        int impot = this.surface * 2 + 1000;
        TrancheEmployes = 0;
        for (int TrancheEmployes = 0; i < NbEmployes; TrancheEmployes++)
        {
            if (TrancheEmployes % 10 == 0)
            {
                impot = impot + 1000;
            }
        }
        return impot;
    }


}