// Напишите программу, которая на вход
// принимает число, а на выход его квадрат

Console.Write("Введите целое число : ") ;
int number = Convert.ToInt32(Console.ReadLine()) ;
int square = number * number ;
Console.WriteLine($"квадрат числа {number} = {square}");
