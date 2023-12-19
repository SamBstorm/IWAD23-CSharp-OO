using System.Text.RegularExpressions;

namespace Demo_Generique_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "42";
            int i = Parse<int>(s);
            double d = Parse<double>(s);
            bool b = Parse<bool>(s);
        }

        static T Parse<T>(string input)
        {
            if (typeof(T) is double) { //Compatible avec les double, float, int, short
                /*Pas implémentable*/
                throw new NotImplementedException();
                /*
                //T result = 0;
                //bool checkComa = false;
                //int i = 1;
                //foreach (char c in input)
                //{
                //    if(!Regex.IsMatch(c.ToString(),"[0-9.]")) throw new FormatException();
                //    if (!checkComa && c != '.')
                //    {
                //        result = result * 10 + ((int)c) - 48;
                //    }
                //    else if (c == '.')
                //    {
                //        checkComa = true;
                //    }
                //    else
                //    {
                //        result += result + (((int)c) - 48) / (10*i);
                //        i++;
                //    }
                //}
                //return result;*/
            }
            else if(typeof(T) is bool) { //Compatible avec booléen
                /*Pas implémentable*/
                throw new NotImplementedException();
            }
            else //Non compatible
            {
                throw new Exception();
            }
        }
    }
}
