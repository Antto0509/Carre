int CalculeCarre(int val)
{
    return val * val;
}

int i;

Console.WriteLine("Saisir un entier");
i = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(CalculeCarre(i));