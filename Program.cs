//Шаг 1. От while к for
using System.Diagnostics.Contracts;

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

//Шаг 3. Вложенные циклы
Console.WriteLine();
int totalWeeks = 3;

for (int week = 1; week <= totalWeeks; week++) {
    for (int day = 1; day <= 5; day++)
    {
        Console.WriteLine($"Неделя {week}, день {day}");
    }
    Console.WriteLine("^_^");
}

//Шаг 4. break и continue
Console.WriteLine();
int sum = 0;
for (int ticket = 1; ticket <= 30; ticket++){
    sum++;
    if (ticket == 4 || ticket == 12 || ticket == 19){
        continue;
    }
    Console.WriteLine($"Первый доступный билет: {ticket}, пропущено билетов: {sum-1}");
    break;
}
