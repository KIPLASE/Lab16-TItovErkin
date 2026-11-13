// Console.Write("Сколько студентов в группе? ");
// int studentsCount = int.Parse(Console.ReadLine()!);
// int[] grades = new int[studentsCount];

// for (int i = 0; i < grades.Length; i++)
// {
//     Console.Write($"Оценка студента {i + 1}: ");
//     grades[i] = int.Parse(Console.ReadLine()!);
// }

// foreach (int grade in grades)
// {
//     Console.WriteLine(grade);
// }

// int sum = 0;
// for (int i = 0; i < grades.Length; i++)
// {
//     sum += grades[i];
// }
// Console.WriteLine($"Средний балл группы: {(double)sum / grades.Length}");
// int[] points = { 4, 7, 2, 9, 5 };

// for (int i = 0; i < points.Length; i++)
// {
//     if (points[i] < 10)
//     {
//         points[i] = points[i] + 1;
//     }
// }

// foreach (int point in points)
// {
//     Console.WriteLine(point);
// }
// int[] grades = { 4, 5, 3, 5, 4, 2 };

// for (int i = 0; i < grades.Length - 1; i++)
// {
//     for (int j = 0; j < grades.Length - 1 - i; j++)
//     {
//         if (grades[j] < grades[j + 1])   // было > — стало < (убывание)
//         {
//             int temp = grades[j];
//             grades[j] = grades[j + 1];
//             grades[j + 1] = temp;
//         }
//     }
// }

// foreach (int grade in grades)
// {
//     Console.WriteLine(grade);
// }
// int[] GenerateScheduleSlots(int lessonsCount)
// {
//     int[] slots = new int[lessonsCount];
//     for (int i = 0; i < lessonsCount; i++)
//     {
//         slots[i] = i + 1;
//     }
//     return slots;
// }

// int[] GenerateEvenSlots(int lessonsCount)
// {
//     int[] slots = new int[lessonsCount];
//     for (int i = 0; i < lessonsCount; i++)
//     {
//         slots[i] = (i + 1) * 2;   // 2, 4, 6, ...
//     }
//     return slots;
// }

// int[] slots = GenerateScheduleSlots(6);
// foreach (int slot in slots)
// {
//     Console.WriteLine(slot);
// }

// int[] evenSlots = GenerateEvenSlots(6);
// foreach (int slot in evenSlots)
// {
//     Console.WriteLine(slot);
// }
// int[] grades = { 4, 5, 3, 5, 4, 2 };
// Array.Sort(grades);

// foreach (int grade in grades)
// {
//     Console.WriteLine(grade);
// }
// A
// Console.Write("Введите N: ");
// int n = int.Parse(Console.ReadLine()!);

// int[] squares = new int[n];
// for (int i = 0; i < n; i++)
// {
//     squares[i] = (i + 1) * (i + 1);
// }

// foreach (int sq in squares)
// {
//     Console.WriteLine(sq);
// }
// // Б
// int[] numbers = { 3, -7, 0, -2, 5, -1 };

// for (int i = 0; i < numbers.Length; i++)
// {
//     if (numbers[i] < 0)
//     {
//         numbers[i] = 0;
//     }
// }

// foreach (int num in numbers)
// {
//     Console.WriteLine(num);
// }
// В
// int[] numbers = { 9, -2, 5, 5, 0 };

// for (int i = 0; i < numbers.Length; i++)
// {
//     if (numbers[i] < 0)
//     {
//         numbers[i] = 0;
//     }
// }

// foreach (int num in numbers)
// {
//     Console.WriteLine(num);
// }
// // Г
// int[] GenerateEvenNumbers(int n)
// {
//     int count = n / 2;   
//     int[] result = new int[count];
//     for (int i = 0; i < count; i++)
//     {
//         result[i] = (i + 1) * 2;
//     }
//     return result;
// }
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
// Erkin 3 and 6
// string[] names = { "Мария", "Алексей", "Ольга", "Борис" };

// for (int i = 0; i < names.Length - 1; i++)
// {
//     for (int j = 0; j < names.Length - 1 - i; j++)
//     {
//         if (string.Compare(names[j], names[j + 1]) > 0)
//         {
//             string temp = names[j];
//             names[j] = names[j + 1];
//             names[j + 1] = temp;
//         }
//     }
// }

// foreach (string name in names)
// {
//     Console.WriteLine(name);
// }
// // 6
// int[] numbers = { 7, 3, 9, 1, 5 };

// for (int i = 0; i < numbers.Length - 1; i++)
// {
//     for (int j = 0; j < numbers.Length - 1 - i; j++)
//     {
//         if (numbers[j] > numbers[j + 1])
//         {
//             int temp = numbers[j];
//             numbers[j] = numbers[j + 1];
//             numbers[j + 1] = temp;
//         }
//     }
// }

// Console.WriteLine($"Медиана: {numbers[numbers.Length / 2]}");
// Titov 8 and 10
double[] temps = { 5.5, -3.2, 0.0, -10.1, 12.7 };

for (int i = 0; i < temps.Length; i++)
{
    if (temps[i] < 0)
    {
        temps[i] = 0;
    }
}

foreach (double t in temps)
{
    Console.WriteLine(t);
}
// // 10
// int[] numbers = { 8, 15, 4, 15, 2 };

// for (int i = 0; i < numbers.Length - 1; i++)
// {
//     for (int j = 0; j < numbers.Length - 1 - i; j++)
//     {
//         if (numbers[j] > numbers[j + 1])
//         {
//             int temp = numbers[j];
//             numbers[j] = numbers[j + 1];
//             numbers[j + 1] = temp;
//         }
//     }
// }

// int max = numbers[numbers.Length - 1];
// for (int i = numbers.Length - 2; i >= 0; i--)
// {
//     if (numbers[i] != max)
//     {
//         Console.WriteLine($"Второе по величине: {numbers[i]}");
//         break;
//     }
// }
