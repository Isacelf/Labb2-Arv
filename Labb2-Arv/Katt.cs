using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Labb2_Arv
{
    internal class Katt : Djur
    {
        public double Längd { get; set; }

        public Katt(string namn = "Okänt", int ålder = 0, double vikt = 0, string färg = "Okänt", bool ärTam = false, double längd = 0)
            : base(namn, ålder, vikt, färg, ärTam)
        {
            Längd = längd;
        }
        public override void MakeSound()
        {
            Console.WriteLine($"{Namn} säger Mjauuu..");
        }

        public void Play()
        {
            Console.WriteLine($"{Namn} leker med sina leksaker..");
        }
    }
}
