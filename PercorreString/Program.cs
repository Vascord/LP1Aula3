using System;

namespace PercorreString
{
    class Program
    {
        static void Main(string[] args)
        {
            string newstr = "";

            Console.WriteLine("Give me a string, then a character : ");
            string phrase = Console.ReadLine();
            string character = Console.ReadLine();
            char c = char.Parse(character);
            for(int i = 0; i < phrase.Length; i++)
            {
                if(c == phrase[i])
                {
                    continue;
                }
                else
                {
                    newstr += phrase[i];
                }
            }
            Console.Write(newstr);
        }
    }
}
