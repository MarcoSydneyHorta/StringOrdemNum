using System;

namespace StringOrdemNum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter names with concatenated number, separated by space");
            Console.Write("For example: manoel4 renata6 paulo5 ari1 claudia3 beatriz2 : ");
            // output: "ari beatriz claudia manoel paulo renata"
            string[] ent = Console.ReadLine().Split(" ");
            Console.Write("Output: " + Uncoordinated(ent));
        }

        static string Uncoordinated(string[] unordered)
        {
            string outputed = "";
            int lastchar = 0;
            int tams = 0;
            string rasc = "";

            int tam = unordered.Length;

            string[] ord = new string[tam];

            for (int i = 0; i < tam; i++)
            {
                tams = unordered[i].Length;
                rasc = string.Concat(unordered[i]);  // Convert string[] to string
                lastchar = Convert.ToInt32(rasc[rasc.Length-1]) - 48;  // Last character position of i substring
                ord[lastchar - 1] = unordered[i].Substring(0, tams - 1);  // Put string without sorted number in sorted position           
            }

            for (int i = 0; i < tam; i++)
            {
                if ( i == 0)
                {
                    outputed = ord[i] + " ";
                }
                else
                {
                    outputed +=  " " + ord[i];
                }
            }

            return outputed;
        }
    }
}
