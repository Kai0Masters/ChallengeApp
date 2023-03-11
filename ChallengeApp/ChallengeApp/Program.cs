// Zadanie domowe dzień 4

// name przykłady = Anna, Ewa, Iza, Wioleta, Adam, Piotr, Maciej, Wiktor

string name = "Ewa";
string name2 = "Piotr";

// wiek osób (0-100)

var age = 24;
var age2 = 33;
var age3 = 15;

// pierwsza część zadania

if (name.EndsWith("a"))
{
    Console.WriteLine("Kobieta");
}
else
{
    Console.WriteLine("Mężczyzna");
}

if (age < 30)
{
    Console.WriteLine("poniżej 30 lat");
}

// druga część zadania

Console.WriteLine(name + ", lat " + age2);

// trzecia część zadania

if (age3 < 18)
{
    Console.WriteLine("Niepełnoletni");
}

if (name2.EndsWith("a"))
{
    Console.WriteLine("Kobieta");
}
else
{
    Console.WriteLine("Mężczyzna");
}

// nie umiem stworzyć wyniku w jednej linijce w zadaniu 1 i 3