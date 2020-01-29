using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_swap
{
    class Program
    {
        static void Main(string[] args)
        {
            string Normal = "This is string";
            string[] words = Normal.Split(new char[] { ' ' });
            string Mirrored = null;
            foreach (string s in words)
            {
                for (int i = s.Length - 1; i >= 0; i--)
                {
                    Mirrored = Mirrored + s[i];

                }
                Mirrored = Mirrored + " ";
            }
            Console.WriteLine(Mirrored);
            Console.ReadKey();
        }
    }
}
