
class Fonction
{
    public static double CalculerPerimetreCarre(double cote)
    {
        return cote * 4;
    }

    public static double CalculerPerimetreCercle(double rayon)
    {
        return 2 * rayon * Math.PI;
    }

    public static void AfficherLesPerimetres()
    {
        Console.WriteLine($"Périmètre d'un carré de coté {10} : {CalculerPerimetreCarre(10)} ");
        Console.WriteLine($"Périmètre d'un cercle de rayon {10} : {CalculerPerimetreCercle(10)} ");
    }
}




