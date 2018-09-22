public class HabitationIndividuelle : Habitation
{
    public int NbPieces;
    public bool Piscine;

    protected override double Affiche()
    {
        Console.WriteLine("Proprietaire : " + proprietaire + ", adresse : " + adresse +
        ", surface : " + surface + ", nb pièces : " + NbPieces);
        if (Piscine == True) 
        {
            Console.WriteLine("Piscine : Oui")
        }
        else
        {
            Console.WriteLine("Piscine : Non")
        }
    }


}