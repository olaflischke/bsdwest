using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableConsole
{
    internal class PatternMatching
    {
        void SwitchPatterns()
        {
            Huhn huhn = new Huhn() { Name = "Hilde", Gewicht = 1234 };

            // Old school
            if (huhn.Name == "Hilde")
            {
                Console.WriteLine("Das Huhn heißt Hilde");
            }
            else
            {
                Console.WriteLine("Das Huhn heißt anders");
            }

            switch (huhn.Name)
            {
                case "Hilde":
                    Console.WriteLine("Das Huhn heißt Hilde");
                    break;
                case "Herta":
                    Console.WriteLine("Das Huhn heißt Herta");
                    break;
                default:
                    Console.WriteLine("Das Huhn heißt anders");
                    break;
            }

            object tier = new Ente();

            // Geht nicht:
            //switch (tier)
            //{
            //    case typeof(Huhn):

            //        case typeof(Ente):
            //}

            // Pattern Matching in switch
            switch (tier)
            {
                case Ente ente1:
                    Console.WriteLine($"Das Tier ist {ente1.GetType().Name} und heißt {ente1.Name}");
                    break;
                case Huhn huhn2 when huhn2.Gewicht > 2000:
                    // Tier ist ein Huhn und wiegt mehr als 2000g
                    break;
                case Huhn huhn1:
                    // Tier ist ein Huhn
                    break;
                default:
                    break;
            }

            string stall1 = huhn.Name switch
            {
                "Hilde" => "Gryffindor",
                "Herta" => "Hufflepuff",
                _ => "Unknown"
            };

            string stall2 = tier switch
            {
                Huhn huhn3 when huhn3.Gewicht > 2000 => "Gryffindor",
                Huhn huhn4 => "Ravenclaw",
                Ente ente5 => "Hufflepuff",
                _ => "Unknown"
            };
        }
    }
}
