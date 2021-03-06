﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condition05
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Tableau comportant les différents degrés de puissance d'une tornade
            La deuxieme colonne indique les conséquences en fonction du degrés de puissance */
            string[,] fujita = new string[,] {
                {"F0","Dégâts légers: certains dommages sont subis par les cheminées, les antennes de télévision, les bardeaux, les arbres, les enseignes et les fenêtres."},
                {"F1","Dégâts modérés : les automobiles sont renversées, les abris pour automobiles détruits et les arbres déracinés."},
                {"F2","Dégâts importants : les toits sont arrachés par le vent, les hangars et les dépendances sont démolies et les maisons mobiles sont renversées."},
                {"F3","Dégâts considérables : les murs extérieurs et les toits sont projetés dans les airs, les maisons et les bâtiments de métal s'effondrent ou subissent des dégâts"},
                {"F4","Dégâts dévastateurs : même dans les habitations solides, l'essentiel des murs, sinon tous, s'effondrent ; tels des missiles, de gros objets en acier ou en béton sont projetés à grandes distances."},
                {"F5","Dégâts incroyables : les maisons sont rasées ou projetées sur de grandes distances. Les tornades F5 peuvent causer des dommages très importants à de grosses structures telles que les écoles et les motels et peuvent arracher les murs extérieurs et les toits (parfois surnommé « le doigt de Dieu »."}
            };

            Console.WriteLine("Veuillez indiquer le type d'un tornade (compris entre F0 et F5) :");
            string userAnswer = Console.ReadLine();

            // ligne de code TEST tableau multidimensionnel : Console.WriteLine(fujita[0,1]);

            switch (userAnswer)
            {
                case "F0":
                    Console.WriteLine(fujita[0,1]);
                    break;
                case "F1":
                    Console.WriteLine(fujita[1,1]);
                    break;
                case "F2":
                    Console.WriteLine(fujita[2,1]);
                    break;
                case "F3":
                    Console.WriteLine(fujita[3,1]);
                    break;
                case "F4":
                    Console.WriteLine(fujita[4,1]);
                    break;
                case "F5":
                    Console.WriteLine(fujita[5,1]);
                    break;
                default:
                    Console.WriteLine("Erreur");
                    break;
            }
                    
        }
    }
}
