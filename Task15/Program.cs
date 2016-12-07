using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task15
{
    class Program
    {
        // I used ASCII Alphabet Characters for this one
        //they are [A - Z] in decimal [65 - 90]

        private static char Ceasar(char chr)
        {
            if (chr == ' ') 
                return ' ';
            if (chr == ' ')
                return ' ';
            
            int shift = chr;
            shift += 3;
            if (shift > 90) shift -= 26;
            return (char)shift;

        }

        public static string Ceasar(string str)
        {
            string RetStr = "";
            foreach (char c in str.ToCharArray())
                RetStr += Ceasar(c).ToString();
            return RetStr;
        }

        static void Main(string[] args)
        {
            string g = "QEB NRFZH YOLTK CLU GRJMP LSBO QEB IXWV ALD";
            Console.WriteLine("Ceasar cipher coded: " + g);
            Console.WriteLine();
            string ceaserDeshifted = Ceasar(g);
            Console.WriteLine("Decoded: " + ceaserDeshifted);

            Console.ReadKey();
        }
    }
}
