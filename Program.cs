string[] cities = {"Париж", "Рим", "Лондон", "Рио", "Берлин"}; 
Console.Write("Дан список городов: ");
for (int i = 0; i < cities.Length - 1; i++){
    Console.Write($"{cities[i]}, ");
}
Console.WriteLine($"{cities[^1]}.");

