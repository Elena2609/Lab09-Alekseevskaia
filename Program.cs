// //Шаг 1. От while к for
// using System.Diagnostics.Contracts;

// int totalExercises = 8;

// for (int number = totalExercises; number >= 1; number--)
// {
//     Console.WriteLine($"Упражнение {number}");
// }

// Console.WriteLine("Домашнее задание готово");

// //Шаг 2. Шаг цикла
// Console.WriteLine();
// for (int room = 5; room <= 50; room += 5)
// {
//     Console.WriteLine($"Кабинет {room}");
// }

// //Шаг 3. Вложенные циклы
// Console.WriteLine();
// int totalWeeks = 3;

// for (int week = 1; week <= totalWeeks; week++)
// {
//     for (int day = 1; day <= 5; day++)
//     {
//         Console.WriteLine($"Неделя {week}, день {day}");
//     }
//     Console.WriteLine("^_^");
// }

// //Шаг 4. break и continue
// Console.WriteLine();
// int sum = 0;
// for (int ticket = 1; ticket <= 30; ticket++)
// {
//     sum++;
//     if (ticket == 4 || ticket == 12 || ticket == 19)
//     {
//         continue;
//     }
//     Console.WriteLine($"Первый доступный билет: {ticket}, пропущено билетов: {sum - 1}");
//     break;
// }

// //Шаг 5. Знакомство с бесконечным for
// Console.WriteLine();
// for (; ; )
// {
//     Console.Write("Введите код группы (для выхода - 'exit'): ");
//     string groupCode = Console.ReadLine()!;

//     if (groupCode == "exit")
//     {
//         break;
//     }

//     Console.WriteLine($"Записан код группы: {groupCode}");
// }
// Console.WriteLine("Работа с журналом завершена");

//Самостоятельные задания
// Console.WriteLine();
// Console.WriteLine("Задача A");
// int totalExercises1 = 10;
// for (int num = 1; num <= totalExercises1; num += 2)
// {
//     Console.WriteLine(num);
// }

// Console.WriteLine();
// Console.WriteLine("Задача Б");
// for (int num1 = 100; num1 >= 0; num1 -= 10)
// {
//     Console.WriteLine(num1);
// }

// //Индивидуальный вариант
// Console.Write("Введите свою фамилию: ");
// string surname = Console.ReadLine()!.Trim();
// if (string.IsNullOrEmpty(surname)) {
// Console.WriteLine("Фамилия не введена. Завершение работы.");
// return;
// }
// Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);
// var assigned = Enumerable.Range(1, 10)
// .OrderBy(_ => rnd.Next())
// .Take(2)
// .OrderBy(x => x)
// .ToList();
// Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");

Console.WriteLine();
Console.WriteLine("Вариант 4");
int N = 5;

for (int i = 1; i <= N; i++)
{
    for (int m = 1; m <= i; m++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

Console.WriteLine();
Console.WriteLine("Вариант 5");
for (int num = 1; num <= 100; num++){
    if (num % 3 == 0 && num % 5 == 0){
        Console.WriteLine(num);
        break;
    }
}