// Задача 9. Напишите программу, которая выводит случайное число
// из отрезка [10, 99] и показывает наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

Random rand = new Random();
int number = rand.Next(10, 100);
Console.WriteLine($"Сгенерировалось случайное число {number}");
int digit2 = number % 10; // команда для того, чтобы вывести 2 цифру на экран
int digit1 = number / 10; // команда для того, чтобы отделить целое первое число,
// а втрое число это остаток, которое будет вторым числом в этой команде
// Console.WriteLine(digit1);
// Console.WriteLine(digit2);
// или так:
if (digit1 > digit2) {
    Console.WriteLine($"Цифра {digit1} больше цифры {digit2}");
}
else if (digit1 < digit2)
{
    Console.WriteLine($"Цифра {digit2} больше цифры {digit1}");
}
else
 {
Console.WriteLine("Цифры равны");
}