// string[] fruit = {"õun", "banaan, "alelsiin"];

string[] fruit = new string[3];

fruit[0] = "õunad";
fruit[1] = "banaanid";
fruit[2] = "apelsiinid";

Console.WriteLine(fruit[0]);
Console.WriteLine(fruit[1]);

int fruitLenght = fruit.Length;

Console.WriteLine($"{fruitLenght}");

for (int i = 0; i < fruitLenght; i++)
{
    fruit[i] = fruit[i].Replace(fruit[i][0], char.ToUpper(fruit[i][0]));
    Console.WriteLine(fruit[i]);
}

foreach (string x in fruit)
{
    Console.WriteLine(x);
}
