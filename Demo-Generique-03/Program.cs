namespace Demo_Generique_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DemandeurEmploi p1 = new DemandeurEmploi("Cardu", "Emanuela");
            DemandeurEmploi p2 = new DemandeurEmploi("Delforge", "Laurence");

            Formation<DemandeurEmploi> WAD23 = new Formation<DemandeurEmploi>();

            WAD23.Inscrire(p1);
            WAD23.Inscrire(p2);

            MembreEntreprise p3 = new MembreEntreprise("Morre", "Thierry", "BStorm");
            MembreEntreprise p4 = new MembreEntreprise("Person", "Michael", "BStorm");

            BootCamp<MembreEntreprise> formation_interne = new BootCamp<MembreEntreprise>();

            formation_interne.Inscrire(p3);
            formation_interne.Inscrire(p4);

            /* Suite à la contrainte where T : IPersonneFinale -> Pas possible
            Formation<Personne> formation_libre = new Formation<Personne>();

            formation_libre.Inscrire(p1);
            formation_libre.Inscrire(p2);
            formation_libre.Inscrire(p3);
            formation_libre.Inscrire(p4);

            */
        }
    }
}
