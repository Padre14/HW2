//Задача 10. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
    
 Console.WriteLine("Task 10");
 Console.WriteLine("Введите трехзначное число :");
string? strNumber = Console.ReadLine();
int number = 0;
        
if (int.TryParse(strNumber, out number))
{
    if (number>99)
    {
    int number1 = (number/10)%10;
    Console.WriteLine(number1);
    }
    else
    {
      Console.WriteLine("Введиде трехзначное число");  
    }
}

// Задача 13. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет
    
Console.WriteLine("Task 13");
Console.WriteLine("Введите номер дня недели:");
string? strNumberDayOfWeek = Console.ReadLine();
int numberDayOfWeek = 0;
    
if (int.TryParse(strNumberDayOfWeek, out numberDayOfWeek))
{
    if (numberDayOfWeek>0 && numberDayOfWeek<8)
    {
    switch(numberDayOfWeek)
        {
            case 6: Console.WriteLine("да"); break;
            case 7: Console.WriteLine("да"); break;
            default: Console.WriteLine("нет"); break; 
        }
    }
    else
        {
            Console.WriteLine("Введиде число от 1 до 7");
        }
}
// Задача 10. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Task 10");
Console.WriteLine("Enter numbers :");
string? strNumberA = Console.ReadLine();
int numberA = 0;

if (int.TryParse(strNumberA, out numberA))
{
   int result = -1;
   if (numberA >= 100)
   {
    while (numberA > 999)
    {
           numberA = numberA / 10; 
    }
    result = numberA % 10;
    Console.WriteLine(result);
   }
   else
   {
    Console.WriteLine("третьей цифры нет"); 
   }

}