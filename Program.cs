using System;

namespace TPOC_JEU_PLUS_MOINS
{
    class Program
    {
        static void Main(string[] args)
        {
            int nombre = -1;
            bool numberIsValid = false;
            int valeurATrouver = new Random().Next(0, 100);
            int compteur = 0;

            Console.WriteLine("JEU Mystère ! ");
            Console.WriteLine("~~~ Devinez le nombre mystère ~~~");

            do
            {
                compteur++;

                while (!numberIsValid)
                {
                    Console.WriteLine("Saisissez un nombre : ");
                    string nombreSaisie = Console.ReadLine();
                    if (int.TryParse(nombreSaisie, out nombre))
                    {
                        numberIsValid = true;
                    }
                    else
                    {
                        numberIsValid = false;
                        Console.WriteLine("Erreur dans la saisie, Entier requis...");
                    }
                }

                numberIsValid = false;

                if (nombre < valeurATrouver)
                {
                    Console.WriteLine("Trop petit...");
                }
                if (nombre > valeurATrouver)
                {
                    Console.WriteLine("Trop Grand !");
                }
                if (nombre == valeurATrouver)
                {
                    Console.WriteLine("Bravo! Nombre mystère : " + nombre);
                }
            } while (nombre != valeurATrouver);

            Console.WriteLine("Vous avez trouvé en " + compteur + " coups.");

        }
    }
}
