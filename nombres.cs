// Valeurs
int a = 7;
int b = 4;
int c = 3;

// Calcul
int d = (a + b) / c;
int e = (a + b) % c;

// Arrondissement au chiffre plus bas
Console.WriteLine($"quotient: {d}");

// Le nombre qu'il reste après l'arrondissement
Console.WriteLine($"remainder: {e}");

// Limites
int max = int.MaxValue;
int min = int.MinValue;
Console.WriteLine($"The range of integers is {min} to {max}");

// Overflow
int what = max + 3;
Console.WriteLine($"An example of overflow: {what}");

// Comparaison de double et décimal (précision)
double f = 1;
double g = 3;
Console.WriteLine(f / g);

decimal h = 1M;
decimal i = 3M;
Console.WriteLine(h / i);
