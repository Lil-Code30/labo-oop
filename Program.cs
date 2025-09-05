/*
 *1. Créer un programme qui demande à un étudiant (âge moins de 20 ans) son nom, puis
   son prénom et après l’année de sa naissance et affiche un écran qui ne contient qu’une
   ligne avec le nom, le prénom et l’âge de l’utilisateur
 *
 * 
 */
 
void Exercise1()
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

// Exercise1();
/*
 *2. Créer un programme qui demande le montant total gagné, le nombre de personne qui
   ont gagné ce montant et affiche le montant gagné par chaque personne (pas plus que 4
   décimales après la virgule).
 * 
 */

void Exercise2()
{
  Console.WriteLine("Exercise 2");
  Console.WriteLine(
    "Un programme qui demande le montant total gagné, le nombre de personne qui ont gagné ce montant et affiche le montant gagné par chaque personne. ");

  Console.WriteLine("Entrez le montant total gagné: ");
  float montant = float.Parse(Console.ReadLine());

  Console.WriteLine("le nombre de personne qui ont gagné ce montant: ");
  int nOfPersons = int.Parse(Console.ReadLine());

  float amountPerPerson = montant / nOfPersons;
  
  Console.WriteLine($"Chaque personne ont gagné : {amountPerPerson.ToString("0.0000)}");
}

Exercise2();

/*
 *3. Créer un programme qui demande la longueur et la largeur d’un rectangle et affiche son périmètre et sa surface.
 * 
 */