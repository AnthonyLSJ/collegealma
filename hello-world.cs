// Nom de "mon ami"
string monAmi = "John Doe";

// Phrase de bonjour
Console.WriteLine($"Bonjour, {monAmi}!");

// Séparation
Console.WriteLine("");

// Détection
Console.WriteLine("Commence avec John : " + monAmi.StartsWith("John"));
Console.WriteLine("Termine avec John : " + monAmi.EndsWith("John"));
Console.WriteLine("Commence avec Doe : " + monAmi.StartsWith("Doe"));
Console.WriteLine("Termine avec Doe : " + monAmi.EndsWith("Doe"));
