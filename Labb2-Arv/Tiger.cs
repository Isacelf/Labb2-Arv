using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Labb2_Arv;

namespace Labb2_Arv
{
    internal class Tiger : Djur
    {
        public bool Hungrig { get; set; }

        public Tiger(string namn = "Okänt", int ålder = 0, double vikt = 0, string färg = "Okänt", bool ärTam = false, bool hungrig = false)
            : base(namn, ålder, vikt, färg, ärTam)
        {
           Hungrig = hungrig;
        }
        public override void MakeSound()
        {
            Console.WriteLine($"{Namn} säger RAWRRRRRRRRR..");
        }

        public void Hunt()
        {
            Console.WriteLine($"{Namn} går ut och jagar efter mat..");
        }
    }
}
