namespace Demo_Tuple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personne p1 = new Personne("Bouharat","Najoua");

            var tupleP1 = (Nom : "Rottin", Prenom : "Elena");

            (string Nom, string Prenom) tupleP2 = ("Chyabri", "Hanane");

            (string Nom, string Prenom) = ("Mucowintore", "Dorine");

            Console.WriteLine($"{tupleP1.Nom} {tupleP1.Prenom}");
            Console.WriteLine($"{tupleP2.Nom} {tupleP2.Prenom}");

            Console.WriteLine($"{Nom} {Prenom}");

            (string nomDeFamille, string prenomP1) = p1;

            Console.WriteLine($"{nomDeFamille} {prenomP1}");
        }
    }
}
