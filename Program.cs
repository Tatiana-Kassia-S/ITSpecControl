string[] cities = {"Париж", "Рим", "Лондон", "Рио", "Берлин"}; 
Console.Write("Дан список городов: ");
for (int i = 0; i < cities.Length - 1; i++){
    Console.Write($"{cities[i]}, ");
}
Console.WriteLine($"{cities[^1]}.");
Console.Write("Названия городов, где меньше 4 букв:  ");
for (int i = 0; i < cities.Length; i++){
    if (cities[i].Length <= 3){
        Console.Write($"{cities[i]}  ");
    }
}
Console.WriteLine();
