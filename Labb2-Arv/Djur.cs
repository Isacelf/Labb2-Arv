using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2_Arv
{
    internal class Djur
    {
        public string Namn { get; set; } // Egenskaper för djur
        public int Ålder { get; set; }
        public string Färg { get; set; }
        public double Vikt { get; set; }
        public bool ÄrTam { get; set; }

        // Konstruktor med "defualt värde"
        public Djur(string namn = "Okänt", int ålder = 0, double vikt = 0, string färg = "Okänt", bool ärTam = false)
        {
            Namn = namn;
            Ålder = ålder;
            Vikt = vikt;
            Färg = färg;
            ÄrTam = ärTam;
        }
        public virtual void MakeSound() // Metod för att göra ett ljud, kan överskridas av subklasser.
        {
            Console.WriteLine($"{Namn} gör ett ljud..");
        }

        public void Eat() // Metod för att äta
        {
            Console.WriteLine($"{Namn} äter..");
        }

        public void Sleep() // Metod för att sova
        {
            Console.WriteLine($"{Namn} sover..");
        }
    }
}
