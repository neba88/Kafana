using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kafana
{
    class Konobar
    {
        public void shank()
        {
            Console.WriteLine("======================================");
            Console.WriteLine("               DOBRODOSHLI            ");
            Console.WriteLine("                    U                 ");
            Console.WriteLine("                  KAFANU              ");
            Console.WriteLine("======================================");
            Console.WriteLine("\n                  \n");
            Console.WriteLine("Imamo u ponudi: 1)Pivo 2)Vino 3)Rakiju \n");
            Console.Write("       Sta bi ste vi popili?: ");
            string str = Console.ReadLine();
            
            switch (str)
            {
                case "1":
                case "Pivo":
                    Console.WriteLine("\n\t         ~  ~       ");
                    Console.WriteLine("\t       ( o )o)      ");
                    Console.WriteLine("\t      ( o )o )o)    ");
                    Console.WriteLine("\t    (o( ~~~~~~~~o   ");
                    Console.WriteLine("\t    ( )' ~~~~~~~'   ");
                    Console.WriteLine("\t    ( )|)       |-. ");
                    Console.WriteLine("\t      o|        |-. \\ ");
                    Console.WriteLine("\t      o|  L A V |  \\ \\ ");
                    Console.WriteLine("\t       | P I V O|   | |  ");
                    Console.WriteLine("\t      o|        |  / /   ");
                    Console.WriteLine("\t       |        |.\" \"   ");
                    Console.WriteLine("\t       |        |- '      ");
                    Console.WriteLine("\t       .========.          ");
                    Console.WriteLine("\n\t  Izvolte jedno ladno           ");
                    Console.ReadLine();
                    break;
                case "2":
                case "Vino":
                     Console.WriteLine("\n\t       _________         ");
                     Console.WriteLine("\t      |         |        ");
                     Console.WriteLine("\t      %         %        ");
                     Console.WriteLine("\t       \\       /        ");
                     Console.WriteLine("\t        `.   .'          ");
                     Console.WriteLine("\t          \\ /           ");
                     Console.WriteLine("\t          ( )            ");
                     Console.WriteLine("\t           |             ");
                     Console.WriteLine("\t        ===^===          ");
                     Console.WriteLine("\n\t      Vino rumeno ");
                     Console.ReadLine();
                     break;
                case "3":
                case "Rakija":
                     Console.WriteLine("\n\t          .-.              "); 
                     Console.WriteLine("\t          | |              ");                           
                     Console.WriteLine("\t          | |              ");
                     Console.WriteLine("\t         .' '.             ");
                     Console.WriteLine("\t        '  R  '            ");
                     Console.WriteLine("\t        |  A  |            ");                   
                     Console.WriteLine("\t        |  K  |            ");   
                     Console.WriteLine("\t        |  I  |            ");
                     Console.WriteLine("\t        |  J  |   |~~| |~~|");
                     Console.WriteLine("\t        |  A  |   |~~| |~~|");
                     Console.WriteLine("\t        '-----'   '--' '--'");
                     Console.ReadLine();
                     break;
                default:
                    Console.WriteLine("\n\tNista vas ne razumem. Tocim sta imam. \n\tMISLIM DA SI DOSTA POPIO!\n\t     AJD KUCI!");
                    Console.ReadLine();
                    break;
            }
            
        }
    }
}
