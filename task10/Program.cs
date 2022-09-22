// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
// Решение готово:
Console.Clear();
Console.Write("Введите число от 1-7:  ");
int num = Convert.ToInt32(Console.ReadLine());
if(num > 7) Console.Write("нет такого дня недели");
if(num == 7) Console.Write("выходной день  ");
if(num == 6) Console.Write("выходной день  ");

if(num == 1) Console.Write("понедельник");
if(num == 2) Console.Write("вторник");
if(num == 3) Console.Write("среда");
if(num == 4) Console.Write("четверг");
if(num == 5) Console.Write("пятница");
if(num == 6) Console.Write("суббота");
if(num == 7) Console.Write("воскресенье");
