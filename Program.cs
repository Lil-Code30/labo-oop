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
  else
  {
    Console.WriteLine("Vous n'etes pas etudiant.");
  }
 
}

// Exercise1();