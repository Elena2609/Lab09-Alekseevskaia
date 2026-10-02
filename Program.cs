//Шаг 1. От while к for
int totalExercises = 8;

for (int number = totalExercises; number >= 1 ; number--){
    Console.WriteLine($"Упражнение {number}");
}

Console.WriteLine("Домашнее задание готово");

//Шаг 2. Шаг цикла
Console.WriteLine();
for (int room = 5; room <= 50; room += 5)
{
    Console.WriteLine($"Кабинет {room}");
}
