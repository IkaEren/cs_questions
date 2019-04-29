using System;

namespace cs_questions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string: ");
            string doodoo = Console.ReadLine();

            Array newArray = new Array();
            Console.Write(newArray.FirstNonRepeatingCharacter(doodoo));
        }
    }
}
