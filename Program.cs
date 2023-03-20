//Sous-programme CalculeCarre : calcule le carre de l'entier
// passe en parametre
// Parametre :
// - val : entier dont on souhaite le carre (en entree)
// Valeur de retour : le carre de val
int CalculeCarre(int val)
{
    return val * val;
}

int i;

Console.WriteLine("Saisir un entier");
i = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(CalculeCarre(i));