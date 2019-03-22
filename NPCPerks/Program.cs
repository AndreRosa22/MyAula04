using System;

namespace NPCPerks
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração variaveis
            string numeroNPC;
            int nNPC;
            caracteristcsNPC[] caract;
            string a;
            string b;
            string c;
            string d;

            //Pedir numero de NPC
            Console.WriteLine("Insira o número de NPCs");
            numeroNPC = Console.ReadLine();
            nNPC = Convert.ToInt32(numeroNPC);
            caract = new caracteristcsNPC[nNPC];

            //Para cada NPC, pedir caracteristicas
            for (int i = 0; i < nNPC; i++)
            {
                //Pergunta se é Stealth
                Console.WriteLine("Tem Stealth? S/N");
                a = Console.ReadLine();
                if (a == "S")
                {
                    caract[i] |= caracteristcsNPC.Stealth;
                }
                //Pergunta se é Combat
                Console.WriteLine("Tem Combat? S/N");
                b = Console.ReadLine();
                if (b == "S")
                {
                    caract[i] |= caracteristcsNPC.Combat;
                }
                //Pergunta se é Lockpick
                Console.WriteLine("Tem Lockpick? S/N");
                c = Console.ReadLine();
                if (c == "S")
                {
                    caract[i] |= caracteristcsNPC.Lockpick;
                }
                //Pergunta se é Luck
                Console.WriteLine("Tem Luck? S/N");
                d = Console.ReadLine();
                if (d == "S")
                {
                    caract[i] |= caracteristcsNPC.Luck;
                }

            }
            //Mostrar caracteristicas
            for (int i = 0; i < nNPC; i++)
            {
                //Mostrar caracteristicas do NPC atual
                Console.WriteLine("NPC  " + (i + 1));
                Console.WriteLine(caract[i]);

                if (b == "S" && d == "S")
                {
                    Console.WriteLine("You shall win all fights!");
                }
            }

        }
    }
}
