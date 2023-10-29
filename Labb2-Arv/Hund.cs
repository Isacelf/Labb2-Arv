using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Labb2_Arv;

namespace Labb2_Arv
{
    internal class Hund : Djur
    {
        public string Ras {  get; set; }

        public Hund(string namn = "Okänt", int ålder = 0, double vikt = 0, string färg = "Okänt", bool ärTam = false, string ras = "Okänd")

             : base (namn, ålder, vikt, färg, ärTam)
        {
            Ras = ras;
        }
        public override void MakeSound()
        {
            Console.WriteLine($"{Namn} säger VOFF VOFF VOFF..");
        }

        public void Catch()
        {
            Console.WriteLine($"{Namn} springer och hämtar föremålet och lämnar tillbaka det..");
        }
    }
    class Bulldog : Hund
    {
        public bool Stark { get; set; }

        public Bulldog(string namn = "Okänt", int ålder = 0, double vikt = 0, string färg = "Okänt", bool ärTam = false, string ras = "Okänt", bool stark = false)
            : base(namn, ålder, vikt, färg, ärTam)
        {
            Stark = stark;
        }
        public void Drooling()
        {
            Console.WriteLine($"{Namn} är en bulldog som börjar dregla..");
        }
    }

    class Chihuahua : Hund
    {
        public bool Liten { get; set; }

        public Chihuahua(string namn = "Okänt", int ålder = 0, double vikt = 0, string färg = "Okänt", bool ärTam = false, string ras = "Okänt", bool liten = false)
            : base(namn, ålder, vikt, färg, ärTam)
        {
            Liten = liten;
        }
        public void Bark()
        {
            Console.WriteLine($"{Namn} är en chihuahua som börjar skälla..");
        }
    }
}
