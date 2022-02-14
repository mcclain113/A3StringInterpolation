using System;

namespace A3StringInterpolation
{
  internal class Program
  {
    public static void Main(string[] args)
    {
    
    DateTime today = DateTime.Now;
    //From today’s date
    //1.January 22, 2019 (right aligned in a 40 character field)
    //note that i am including the numbering in the total count of the field
    Console.WriteLine($"1. {today,(40-11):MMMM} {today:dd} {today:yyyy}");
    //2.2019.01.22
    Console.WriteLine($"2.{today:yyyy}.{today:MM}.{today:dd}");
    //3.Day 22 of January, 2019
    Console.WriteLine($"3.Day {today:dd} of {today:MMMM}, {today:yyyy}");
    //4.Year: 2019, Month: 01, Day: 22
    Console.WriteLine($"4.Year: {today:yyyy}, Month: {today:MM}, Day: {today:dd}");
    //5. Tuesday (10 spaces total, right aligned)
    //note that i am including the numbering in the total count of the field
    Console.WriteLine($"5. {today,(10-3):dddd}");
    //6.     11:01 PM             Tuesday (10 spaces total for each including the day-of-week, both right-aligned)
    //note that i am including the numbering in the total count of the field
    Console.WriteLine($"6. {today,(10-3):hh:mm tt}{today,10:dddd}");
    //7.h:11, m:01, s:27
    Console.WriteLine($"7.h:{today:hh}, m:{today:mm}, s:{today:ss}");
    //8.2019.01.22.11.01.27
    Console.WriteLine($"8.{today:yyyy}.{today:MM}.{today:dd}.{today:hh}.{today:mm}.{today:ss}");
    
    
    //If you have PI (3.1415) - use var pi = Math.PI;
    //1. Output as currency
    var pi = Math.PI;
    Console.WriteLine("9. {0:C2}",pi);
    //2. Output as right-aligned (10 spaces), number with 3 decimal places
    //note that i am including the numbering in the total count of the field
    Console.WriteLine("10. {0,6:N3}",pi);

    }
  }
}