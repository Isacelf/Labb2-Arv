using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Labb2_Arv
{
    internal class Katt : Djur // Katt klass som ärver från Djur
    {
        public double Längd { get; set; } // Separat egenskap för just katt

        // Konstruktor med "defualt värde"
        public Katt(string namn = "Okänt", int ålder = 0, double vikt = 0, string färg = "Okänt", bool ärTam = false, double längd = 0)
            : base(namn, ålder, vikt, färg, ärTam)
        {
            Längd = längd;
        }
        public override void MakeSound() // Överskriden metod för att göra ljud
        {
            Console.WriteLine($"{Namn} säger Mjauuu..");
        }

        public void Play() // Specifik metod för klassen som ska leka
        {
            Console.WriteLine($"{Namn} leker med sina leksaker..");
        }
    }
}
