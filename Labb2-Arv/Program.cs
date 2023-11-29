// Isac Elfstrand SUT23
namespace Labb2_Arv
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Skapar instanser av alla olika klasser och ger dom specifika egenskaper
            Hund hund = new Hund("Dumle", 4, 8, "Svart", true, "Pitbull");
            Katt katt = new Katt("Misse", 2, 3, "Grå", true, 30);
            Tiger tiger = new Tiger("Saber", 12, 350, "Orange", false, true);
            Bulldog bulldog = new Bulldog("Mimi", 6, 9, "Svart", true, "Bulldog", true);
            Chihuahua chihuahua = new Chihuahua("Bulle", 1, 1, "Vit", true, "Chihuahua", true); 

            // Anropar tigerns metoder
            tiger.MakeSound();
            tiger.Eat();
            tiger.Sleep();
            tiger.Hunt();
            Console.WriteLine("");

            // Anropar hundens metoder
            hund.MakeSound();
            hund.Eat();
            hund.Sleep();
            hund.Catch();
            Console.WriteLine("");

            // Anropar kattens metoder
            katt.MakeSound();
            katt.Eat();
            katt.Sleep();
            katt.Play();
            Console.WriteLine("");

            // Anropar bulldogens metod
            bulldog.Drooling();
            Console.WriteLine("");

            // Anropar chihuahuans metod
            chihuahua.Bark();
        }
    }
}