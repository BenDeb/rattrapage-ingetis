class Main {

    static void Main(string[] args) {

        Habitation appartement1 = new Habitation("Benjamin", "1, rue Ingetis", 29);
        int impotBenjamin = appartement1.Impot();
        Console.WriteLine("L'impôt de Benjamin s'élève à : " + impotBenjamin);

        appartement1.Affiche();


        HabitationIndividuelle maison1 = new HabitationIndividuelle("Max", "10, rue de Paris", 73, 3, true);
        maison1.Affiche();
        int impotMax = maison1.Impot();
        Console.WriteLine("L'impôt de Max s'élève à : " + impotMax);


        HabitationProfessionnelle locaux1 = new HabitationProfessionnelle("Ingetis", "1, rue Ici", 350, 48);
        impotIngetis = locaux1.Impot();
        Console.WriteLine("L'impôt d'Ingetis s'élève à : " + impotIngetis);
    }

