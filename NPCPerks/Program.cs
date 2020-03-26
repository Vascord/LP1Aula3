using System;

namespace NPCPerks
{
    class Program
    {
        static void Main(string[] args)
        {
            Perks[] perks;

            Console.Write("Give me the number of NPCs :");
            string number = Console.ReadLine();
            int npc_number = int.Parse(number);
            perks = new Perks[npc_number];

            for(int i = 0; i < npc_number; i++)
            {
                Console.WriteLine($"NPC {i} tem Stealth (s/n)? ");
                number = Console.ReadLine();
                if ( number.ToLower() == "s")
                {
                    perks[i] |= Perks.Stealth;
                }

                Console.WriteLine($"NPC {i} tem Combat (s/n)? ");
                number = Console.ReadLine();
                if ( number.ToLower() == "s")
                {
                    perks[i] |= Perks.Combat;
                }

                Console.WriteLine($"NPC {i} tem Lockpick (s/n)? ");
                number = Console.ReadLine();
                if ( number.ToLower() == "s")
                {
                    perks[i] |= Perks.Lockpick;
                }

                Console.WriteLine($"NPC {i} tem Luck (s/n)? ");
                number = Console.ReadLine();
                if ( number.ToLower() == "s")
                {
                    perks[i] |= Perks.Luck;
                }
            }
            Console.WriteLine();

            for (int i = 0; i < npc_number; i++)
            {
                Perks p = Perks.Combat | Perks.Luck;
                Console.Write($"Perks do NPC {i}: {perks[i]}");

                if ((perks[i] & p) == p)
                {
                    Console.WriteLine("\tYou shall win all fights !");
                }
            }
        }
    }
}
