using Demo_Evenements.Handlers;
using Demo_Evenements.Models;

namespace Demo_Evenements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal tamagotchi = null;
            
            switch(new Random().Next(2))
            {
                case 0:
                    tamagotchi = new Chien();
                    break;
                case 1:
                    tamagotchi = new Chat();
                    break;
            }


            tamagotchi.AvoirFaim += NotifierFaim;
            tamagotchi.AvoirFaim += BeepFaim;

            tamagotchi.Faim--;
            tamagotchi.Faim--;
            tamagotchi.Faim--;
            tamagotchi.Faim--;
            tamagotchi.Faim--;
            tamagotchi.Faim--;
            tamagotchi.Faim--;
            tamagotchi.Faim--;
            tamagotchi.Faim--;

        }

        private static void NotifierFaim(object sender, EventArgs args)
        {
            AnimalEventArgs a_args = null;
            if (args != EventArgs.Empty)
            {
                a_args = (AnimalEventArgs)args;
                Console.WriteLine($"{a_args.AnimalName} a faim ({a_args.AnimalFaimLevel} / 10)");
            }
            else
            {
                Console.WriteLine("A faim...");
            }
        }

        private static void BeepFaim(object sender, EventArgs args)
        {
            Console.Beep(244,200);
        }
    }
}
