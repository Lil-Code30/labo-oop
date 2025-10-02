
class Program
{
  /* 1. Créer un programme qui demande à un étudiant (âge moins de 20 ans) son nom, puis
   son prénom et après l’année de sa naissance et affiche un écran qui ne contient qu’une
   ligne avec le nom, le prénom et l’âge de l’utilisateur
 */
 
  public static void Exercise1()
  {
    Console.WriteLine("Exercise 1");
    Console.WriteLine("Entrez votre nom : ");
    string firstName = Console.ReadLine();
  
    Console.WriteLine("Entrez votre prenom : ");
    string lastName = Console.ReadLine();
  
    Console.WriteLine("Entrez votre anne de naissance : ");
    int dateOfBirth = int.Parse(Console.ReadLine());
    int currentYear = DateTime.Now.Year;
  
    int userAge = currentYear - dateOfBirth;

    if (userAge < 20)
    {
      Console.WriteLine($"{firstName} {lastName} a {userAge} years old");
    }
  }

  /*
 *2. Créer un programme qui demande le montant total gagné, le nombre de personnes qui
   ont gagné ce montant et affiche le montant gagné par chaque personne (pas plus que QUATRE
   décimales après la virgule).
 * 
 */

public static void Exercise2()
{
  Console.WriteLine("Exercise 2");
  Console.WriteLine(
    "Un programme qui demande le montant total gagné, le nombre de personne qui ont gagné ce montant et affiche le montant gagné par chaque personne. ");

  Console.WriteLine("Entrez le montant total gagné: ");
  float montant = float.Parse(Console.ReadLine());

  Console.WriteLine("le nombre de personne qui ont gagné ce montant: ");
  int nOfPersons = int.Parse(Console.ReadLine());

  float amountPerPerson = montant / nOfPersons;

  Console.WriteLine($"Chaque personne ont gagné : {amountPerPerson:0.00}");
}



/*
 * 3. Créer un programme qui demande la longueur et la largeur d’un rectangle et affiche son périmètre et sa surface.
 * 
 */
public static void Exercise3()
{

  Console.WriteLine("Entrez la longeur du rectangle : ");
  float longueur = Convert.ToSingle(Console.ReadLine());
  Console.WriteLine("Entrez la largeur du rectangle : ");
  float largeur = Convert.ToSingle(Console.ReadLine());

  float perimeter = 2 * (largeur + longueur);
  float surface = largeur * longueur;
  
  Console.WriteLine($"Le perimeter du rectangle avec comme largeur {largeur} et longeur {longueur}  : {perimeter}, Surface : {surface}");
}



/*
 * 4.
Créer un programme qui demande le montant gagné par mois et affiche le montant gagné par année sachant que la taxe annuelle est de 35%.
 */

public static void Exercise4()
{
  /*
   * montant par mois Brut = 3000
   * montant total (Net) =  3000 * 12 
   * 
   * nombre de mois = 12
   * % taxe = 35%
   * taxe annuelle = 35% * montant total
   * Salaire annuelle = montant total - taxe annuelle 
   */
  const double tax = 0.35;
  const int moisTotal = 12;
  
  Console.WriteLine("Entrez le montant gagné par mois : ");
  float montant = Convert.ToSingle(Console.ReadLine());
  
  double taxAnnuelle = montant * tax;

  double salaireBrut = montant * moisTotal;
  
  double salaireNet = salaireBrut - taxAnnuelle;

  Console.WriteLine($"Votre salaire Net gagné par année est de : {salaireNet:C2}");
  // Console.WriteLine("Votre salaire Net gagné par année est de : " + salaireNet.ToString("C2") );
}



/*
 *5. Créer un programme qui demande deux nombres x et y et affiche : x+y, x-y, x*y, x/y, x%y (modulo) et x^y
 */

public static void Exercise5()
{
  Console.WriteLine("Entrez un nombre : ");
  int num1 = Convert.ToInt32(Console.ReadLine());
  
  Console.WriteLine("Entrez un autre nombre : ");
  int num2 = Convert.ToInt32(Console.ReadLine());
  
 // Operations
 
 int sum = num1 + num2;
 int diff = num1 - num2;
 int product = num1 * num2;
 int division = num1 / num2;  
 int modulo  = num1 % num2;
 double power = Math.Pow(num1, num2);
 
 Console.WriteLine("Operation.");
 Console.WriteLine($"{num1} + {num2} = {sum}");
 Console.WriteLine($"{num1} - {num2} = {diff}");
 Console.WriteLine($"{num1} * {num2} = {product}");
 Console.WriteLine($"{num1} / {num2} = {division}");
 Console.WriteLine($"{num1} modulo {num2} = {modulo}");
 Console.WriteLine($"{num1} ^ {num2} = {power}");
}



/*
 *6. Créer un programme qui prend la moyenne d’un étudiant (/20) et affiche ‘réussite’ si la note est supérieure ou égale à 10
 * 
 */

public static void Exercise6()
{
  Console.WriteLine("Entrez votre moyenne (moyenne/20) : ");
  int moyenne = Convert.ToInt32(Console.ReadLine());

  if (moyenne >= 10)
  {
    Console.WriteLine("Réussite :)");
  }
}


/*
 * 7. Modifier le programme précédent pour qu’il affiche ‘Échec’ dans le cas où la moyenne est inférieure à 10.
 */
public static void Exercise7()
{
  Console.WriteLine("Entrez votre moyenne (moyenne/20) : ");
  int moyenne = Convert.ToInt32(Console.ReadLine());

  if (moyenne >= 10)
  {
    Console.WriteLine("Réussite :)");
  }
  else
  {
    Console.WriteLine("Échec :(");
  }
}



/*
 * 8. Créer un programme qui demande un chiffre(0 à 9) et affiche le chiffre en lettre. Si la valeur entrée n’est pas entre 0 et 9, afficher ‘pas entre 0 et 9’.
 */
public static void Exercise8()
{
  Console.WriteLine("Entrez un chiffre entre 0 et 9.");
  int chiffre = Convert.ToInt32(Console.ReadLine());

  switch (chiffre )
  {
    case 0:
      Console.WriteLine("Zero");
      break;
    case 1:
      Console.WriteLine("Un");
      break;
    case 2:
      Console.WriteLine("Deux");
      break;
    case 3:
      Console.WriteLine("Trois");
      break;
    case 4:
      Console.WriteLine("Quatre");
      break;
    case 5:
      Console.WriteLine("Cinq");
      break;
    case 6:
      Console.WriteLine("Six");
      break;
    case 7:
      Console.WriteLine("Sept");
      break;
    case 8:
      Console.WriteLine("Huit");
      break;
    case 9:
      Console.WriteLine("Neuf");
      break;
    default:
      Console.WriteLine("pas entre 0 et 9");
      break;
  }
}



/*
 * 9. Afficher : -12 | -9 | -6 | -3 | 0 | 3 | 6 | … | 300
 */
public static void Exercise9()
{
  for (int i = -12; i <= 300; i++)
  {
    string output = i ==  300 ? $"{i}" : $"{i} | ";
    Console.Write(output);
  }
  
}


/*
 * 10. Créer un programme qui prend un caractère, l’affiche 100 fois et demande à l’utilisateur s’il veut le même affichage à nouveau jusqu’à ce que l’utilisateur rentre ‘N’
 */

public static void Exercise10()
{
  
  Console.WriteLine("Entrez un caractère : ");
  string caractere = Console.ReadLine();
  char reponse ;
  
  do
  {
    for (int i = 1; i <= 100; i++)
    {
      Console.WriteLine($"{i}. {caractere}");
    }
  
    Console.Write("Continue le même affichage ? Oui (O) ou Non (N) : ");
    reponse = Convert.ToChar(Console.ReadLine());
  } while (Char.ToUpper(reponse) != 'N');
  
}


/*
 * 11. Soit une histoire composée de 10 lignes. Créer un programme qui permet à l’utilisateur de lire l’histoire ligne par ligne en tapant ‘espace’
 * et de ne pas la lire ou quitter avant de la terminer si la touche enfoncée est différente de ‘espace’.
 */

public static void Exercise11()
{

  string[] ligne = ["Chaque matin, il courait dans les champs pour chasser les papillons.","Un jour, il aperçutt de la co une étrange lumière au sommelline.", "Curieux, il grimpa et découvrit une vieille boîte en bois.", "La boîte était fermée par un cadenas rouillé, mais Minou réussit à l’ouvrir.", "À l’intérieur, il trouva une pierre brillante qui semblait magique.", "Dès qu’il la toucha, Minou se sentit léger comme une plume.", "Il pouvait maintenant sauter très haut et courir plus vite que le vent.", "Heureux, il retourna au village pour partager sa découverte avec ses amis.", "Depuis ce jour, Minou devint le chat le plus courageux et aventurier du village."];
  ConsoleKeyInfo space;
  for (int i = 0; i < ligne.Length; i++)
  {
    Console.WriteLine(ligne[i]);

    do
    {
       space = Console.ReadKey(true);
      
    }while(space.Key != ConsoleKey.Spacebar);
  }
}



public static void printTriangle()
{
  for (int j = 20; j < 0; j--)
  {
    for (int i = 0; i < j; i++)
    {
      Console.Write("*");
    }
    Console.WriteLine();
  }
  
  for (int j = 0; j < 20; j++)
  {
    for (int i = 20; i < j; i++)
    {
      Console.Write("*");
    }
    Console.WriteLine();
  }
}


/*
 * Créer un programme qui permet de saisir 5 pays et de les
  afficher dans l’ordre inverse de celui de la saisie.
 */
public static void InverseCountry()
{
  string[] lesPays = new string[5];
  {
    for (int i = 0; i <= 4; i++)
    {
      Console.Write($"Saisir le pays {i + 1}");
      lesPays[i] = Console.ReadLine();
    }

    Console.WriteLine("Les pays son les pays");
    for (int i = 4; i >= 0; i--)
    {
      Console.WriteLine(lesPays[i]);
    }
  }
}

/*5. Write a C# Sharp program in to count duplicate elements in an array.
   Test Data :
   Input the number of elements to be stored in the array :3
   Input 3 elements in the array :
   element - 0 : 5
   element - 1 : 1
   element - 2 : 1
   Expected Output :
   Total number of duplicate elements found in the array is : 1*/

public static void countDuplicates()
{
  
  Console.Write("Input the number of elements to be stored in the array");
  
  int[] numArray = [3,4,4,3,2,4,6,0,2];
  
  Console.Write("Enter a number: ");
  int num = int.Parse(Console.ReadLine());
  
  int count = 0;

  for (int i = 0; i < numArray.Length; i++)
  {
    if (numArray[i] == num)
    {
      count++;
    }
    
  }
  
  Console.WriteLine("Number of elements duplicated: " + count);
}


public static void InsertACharater()
{
  string chaine = "Bonjour";
  
  // insert '123' before n

  Console.Write("Input the chaine: ");
  string chaine1 = Console.ReadLine();

  int index;
  do
  {
    Console.Write("Input an index: ");
    index = int.Parse(Console.ReadLine());
  }while(index < 0 || index >= chaine.Length);
  

  string chaine2 = "";
  
  for (int i = 0; i < chaine.Length; i++)
  {
    if (i == index)
    {
      chaine2 += chaine1;
    } 
    chaine2 += chaine[i];
  }
  Console.Write("Input an index: " + chaine2);
  
  
}

// InsertACharater();


///1. Prendre 2 nombres, l’opération : -, +, *, /, % ou p (ab)
/// (pour les autres caractères afficher: pas une opération valide) et afficher le résultat.
public static void Ex0Serie0201()
{
  Console.Write("Enter the first number: ");
  int num1 = Int32.Parse(Console.ReadLine());
  
  Console.Write("Enter the second number: ");
  int num2 = Int32.Parse(Console.ReadLine());
  
  Console.Write("Choose an operation from this list [-, +, *, /, % or p]: ");
  char operation = Convert.ToChar(Console.ReadLine());
  
    switch (operation)
    {
      case '-':
        Console.WriteLine($"{num1} -  {num2} = {num1 - num2}");
        break;
      case '+':
        Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
        break;
      case '*':
        Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
        break;
      case '/':
        if (num2 == 0)
        {
          Console.WriteLine("Division by zero is not allowed");
          return;
        }
        Console.WriteLine($"{num1} /  {num2} = {num1 / num2}");
        break;
      case '%':
        Console.WriteLine($"{num1} modulo  {num2} = {num1 % num2}");
        break;
      case 'p':
        Console.WriteLine($"{num1}^{num2} = {Math.Pow(num1, num2)}");
        break;
      default:
        Console.WriteLine($"{operation} is not an operation from the list mention above.");
        break;
    }
  
}


// 2. Prendre des prix d’achats et afficher le "min" et son ordre de saisi.
public static void ExoSerie0202()
{
  Console.Write("Enter the number of price to input: " );
  int n =  Int32.Parse(Console.ReadLine());
  int[] priceArr = new int[n];

  for (int i = 0; i < n; i++)
  {
    Console.Write("Enter price: "); 
    priceArr[i] = Int32.Parse(Console.ReadLine());
  }

  int smallPrice = priceArr[0];
  for (int i = 0; i < n; i++)
  {
    if (priceArr[i] < smallPrice)
    {
      smallPrice = priceArr[i];
    }
  }
  
  Console.WriteLine($" The Smallest price is {smallPrice} and it was entered at position {Array.IndexOf(priceArr, smallPrice) + 1}.");
}


// ExoSerie0202();
  public static void Main(string[] args)
  {
    
  }
}






