﻿//   System.Console.WriteLine("Vvedite hislo");
//   int num = Convert.ToInt32(Console.ReadLine());
//  int resault = num*num; 
//   System.Console.WriteLine($"Kvadrat chisla {num}->{resault}");
//  int a= 1;

// System.Console.WriteLine("Введите возводимое в квадрат число");
// int a = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите результат возведения");
// int b = Convert.ToInt32(Console.ReadLine());

// if (a*a == b)
// {

// System.Console.WriteLine("Verno");

// }

// else
// {
// System.Console.WriteLine("Neverno");

// }


// Алгоритм дня недели с массивом

// System.Console.WriteLine("Введите число дня недели");
// int numbday = Convert.ToInt32(Console.ReadLine());
// string[] nameday = { "Понедельник","Вторник","Среда","Четверг","Пятница","Суббота","Воскресенье"};
// if ( numbday>=1 & numbday<=7 ){
// System.Console.WriteLine($"{numbday} день недели это - {nameday[numbday-1]}");
// // System.Console.Write(nameday[numbday-1]);
// }
// else
// {
//     System.Console.WriteLine("Введите корректное число");
// }


System.Console.WriteLine("Введите число дня недели");
int numbday = Convert.ToInt32(Console.ReadLine());

if (numbday == 1)
{
    System.Console.WriteLine("Понедельник");
}
 else if (numbday == 2)
{
    System.Console.WriteLine("Вторник");
}
else if (numbday == 3)
{
    System.Console.WriteLine("Среда");
}
else if (numbday == 4)
{
    System.Console.WriteLine("Четверг");
}
else if (numbday == 5)
{
    System.Console.WriteLine("Пятница");
}
else if (numbday == 6)
{
    System.Console.WriteLine("Суббота");
}
else if (numbday == 7)
{
    System.Console.WriteLine("Воскресенье");
}
else 
{
    System.Console.WriteLine("Введите корректное число");

}
