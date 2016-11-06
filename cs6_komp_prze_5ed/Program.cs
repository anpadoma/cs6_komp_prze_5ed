using System;

namespace cs6_komp_prze_5ed
{
    class CommentSamples
    {
        private static void Main()
        {
            Console.WriteLine("Hej, ty!");

            Console.Write("Wprowadż imię: ");
            var firstName = Console.ReadLine();
            Console.Write("Wprowadż nazwisko: ");
            var lastName = Console.ReadLine();

            Console.WriteLine("Twoje imię i nazwisko to {0} {1}.", firstName, lastName);
        }
    }
}
