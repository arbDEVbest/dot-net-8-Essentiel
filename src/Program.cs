namespace Tableaux;

class Program
{
    static void Afficher(string[] liste, Range r)
    {
        foreach (var c in liste[r])
        {
            Console.WriteLine(c);
        }
    }

    static void Main(string[] args)
    {
        string[] couleurs = "rouge, orange, jaune, vert, bleu, violet".Split(", ");
        

        Afficher(couleurs, ..);
        Console.WriteLine();

        #region Boucle d'initialisation
        var couleursMaj = new string[couleurs.Length];

        for (int i = 0; i < couleurs.Length; i++)
        {
            couleursMaj[i] = couleurs[i].ToUpper();
        }
        #endregion

        Afficher(couleursMaj, ..);
        Console.WriteLine();
        //La première case à partir de la fin (la dernière case)
        couleurs[^1] = "Violet";
        //Afficher une partie du tableau utilisant un slicing
        Afficher(couleurs, ..2);
        Console.WriteLine("...");
        //Afficher une partie du tableau à partir de l'avant dernière case
        Afficher(couleurs, ^2..);

    }
}
