using System.Collections;

namespace Démo_Generique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exemple avec ListInt
            //ListInt list = new ListInt();

            //list.Add(5);
            //list.Add(35);
            //list.Add(45);

            //for (int i = 0; i < list.Count; i++)
            //{
            //    int nb = list[i];
            //    Console.WriteLine($"La valeur est {nb} et le type est {nb.GetType()}.");
            //}
            #endregion
            #region Exemple avec ListString
            //ListString list_str = new ListString();
            ListGeneric<string> list_str = new ListGeneric<string>();
            list_str.Add("cinq");
            list_str.Add("trente-cinq");
            list_str.Add("Quarante-cinq");

            for (int i = 0; i < list_str.Count; i++)
            {
                string text = list_str[i];
                Console.WriteLine($"La valeur est {text} et le type est {text.GetType()}.");
            }
            #endregion
            #region Exemple avec ListBool
            //ListBool list_bool = new ListBool();
            ListGeneric<bool> list_bool = new ListGeneric<bool>();
            list_bool.Add(true);
            list_bool.Add(false);
            list_bool.Add(true);

            for (int i = 0; i < list_bool.Count; i++)
            {
                bool value = list_bool[i];
                Console.WriteLine($"La valeur est {value} et le type est {value.GetType()}.");
            }
            #endregion
            #region Exemple avec ListGeneric<T>
            //ListGeneric<double> list = new ListGeneric<double>();

            //list.Add(3.14);
            //list.Add(1.141414);
            //list.Add(42.0);

            //for (int i = 0; i < list.Count; i++)
            //{
            //    double nb = list[i];
            //    Console.WriteLine($"La valeur est {nb} et le type est {nb.GetType()}.");
            //}
            #endregion
        }
    }
}
