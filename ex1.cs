namespace LABO_OOP;

public class ex1
{
    public static void ExVariable()
    {
        /*
         * Créer un programme qui prend un montant, la devise, le taux de change de cette devise vers le CAD et affiche
           le montant en CAD
         */
        
        Console.Write("Entrez un montant: ");
        float montant = Convert.ToSingle(Console.ReadLine());
        
        Console.Write("Entrez la devise ( Ex: USD, EURO,...): ");
        string devise = Console.ReadLine();

        Console.Write("Entrez le taux de change : ");
        float taux = Convert.ToSingle(Console.ReadLine());
        
        float montantChange = montant * taux;
        
        Console.WriteLine($"{montant} {devise} en CAD est : {montantChange} CAD");
    }

    public static void ExFunction()
    {
        /*
         * *
         * Créer un programme qui prend la catégorie du produit(1 pour
           nourriture ou 2 pour le reste), son prix unitaire, la quantité
           achetée et affiche le montant à payer sachant qu’il n’y a pas de
           taxe sur la nourriture et que le taux de la taxe, pour les autres
           produits, est de 15%.
         */
         
    }

    public static void test()
    {
        for (int row = 0; row <= 20; row++)
        {
            if (row % 5 == 0)
            {
                Console.WriteLine("//");
            }
            else
            {
                Console.WriteLine("*");
            }
        } 
    }

    public static void test2()
    {
        for (int row = 0; row <= 20; row++)
        {
            for (int col = 20; col >=0; col--)
            {
                if (col > col - 1)
                {
                    Console.Write("*");
                }
                // Console.Write("*");
                
            }
            Console.WriteLine();
        }
    }

    
}