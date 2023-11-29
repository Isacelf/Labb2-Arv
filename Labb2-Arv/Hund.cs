using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Labb2_Arv;

namespace Labb2_Arv
{
    internal class Hund : Djur // Hund klass som ärver från Djur
    {
        public string Ras {  get; set; } // Separat egenskap för just hund

        // Konstruktor med "defualt värde"
        public Hund(string namn = "Okänt", int ålder = 0, double vikt = 0, string färg = "Okänt", bool ärTam = false, string ras = "Okänd")

             : base (namn, ålder, vikt, färg, ärTam)
        {
            Ras = ras;
        }
        public override void MakeSound() // Överskriden metod för att göra ljud
        {
            Console.WriteLine($"{Namn} säger VOFF VOFF VOFF..");
        }

        public void Catch() // Specifik metod för klassen som ska hämta
        {
            Console.WriteLine($"{Namn} springer och hämtar föremålet och lämnar tillbaka det..");
        }
    }
    class Bulldog : Hund // Underklass som ärver från hundklassen
    {
        public bool Stark { get; set; } // Separat egenskap för just Bulldog klassen

        // Konstruktor med "defualt värde"
        public Bulldog(string namn = "Okänt", int ålder = 0, double vikt = 0, string färg = "Okänt", bool ärTam = false, string ras = "Okänt", bool stark = false)
            : base(namn, ålder, vikt, färg, ärTam)
        {
            Stark = stark;
        }
        public void Drooling() // Extra metod för enbart bulldog
        {
            Console.WriteLine($"{Namn} är en bulldog som börjar dregla..");
        }
    }

    class Chihuahua : Hund // Underklass som ärver från hundklassen
    {
        public bool Liten { get; set; } // Separat egenskap för just Chihuahua klassen

        // Konstruktor med "defualt värde"
        public Chihuahua(string namn = "Okänt", int ålder = 0, double vikt = 0, string färg = "Okänt", bool ärTam = false, string ras = "Okänt", bool liten = false)
            : base(namn, ålder, vikt, färg, ärTam)
        {
            Liten = liten;
        }
        public void Bark() // Extra metod för enbart bulldog
        {
            Console.WriteLine($"{Namn} är en chihuahua som börjar skälla..");
        }
    }
}
