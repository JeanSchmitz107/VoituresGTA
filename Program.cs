using System.Security.Cryptography;

namespace VoituresGTA;
/*
    CONSIGNES
    1. Déclarer un tableau contenant cinq véhicules :
        - Banshee
        - Zentorno
        - Sultan
        - Sanchez
        - Buzzard
    2. Afficher tous les véhicules du garage avec une boucle for.
    3. Demander au joueur de saisir le numéro du véhicule qu'il souhaite remplacer (de 1 à 5).
    4. Demander le nom du nouveau véhicule.
    5. Remplacer l'ancien véhicule par le nouveau dans le tableau.
    6. Afficher le contenu actualisé du garage.
*/
class Program
{
    static void Main(string[] args)
    {
        string[] car = ["Banshee", "Zentorno", "Sultan", "Sanchez", "Buzzard"];


        remplaced(car);

    }






    static void remplaced(string[] car)
    {
        garage(car);

        int i_remplace = car_i_remplace();

        string name_remplace = car_name_remplace(car, i_remplace);

        car[i_remplace - 1] = name_remplace;

        garage(car);
    }



    static void garage(string[] car)
    {
        for (int i = 0; i < car.Length; i++)
        {
            Console.WriteLine((i + 1) + ". " + car[i]);
        }
    }

    static int car_i_remplace()
    {
        int i_remplace = 0;
        //while (0 < i_remplace && i_remplace < car.Length)
        //{
        Console.WriteLine("Quelles véhicule veux tu remplacer ? (de 1 à 5)");
        i_remplace = Convert.ToInt32(Console.ReadLine());
        //}
        return i_remplace;
    }

    static string car_name_remplace(string[] car, int i_remplace)
    {
        Console.WriteLine("Quelle nom veux tu pour remplacer : " + car[i_remplace - 1] + " ?");
        string name_remplace = Console.ReadLine();
        return name_remplace;
    }
}