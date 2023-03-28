/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

Alex Olhovskiy
*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
      
    //Second digit of a three-digit number
    Console.WriteLine("Enter three-digit number");
    int num=Convert.ToInt32(Console.ReadLine());
    
    if(num>=0)
    {
        if(((num/100)>=1)&((num/100)<10))
        {
            Console.WriteLine("Second digit is "+(num/10)%10);
        }
        else
        {
            Console.WriteLine("Invalid number, please try again");
        }
    }
    else
    {
        Console.WriteLine("Please enter number over zero");
    }
    
    //Third digit of any number
    Console.WriteLine("Enter any number");
    num=Convert.ToInt32(Console.ReadLine());
    int third_num=-1;
    if(num>=0)
    {
        while((num/100)!=0)
        {
            third_num=num%10;
            num/=10;
        }
        if(third_num>0)
        {
            Console.WriteLine("Third digit is "+third_num);
        }
        else
        {
            Console.WriteLine("Third digit is missing");
        }
    }
    else
    {
        Console.WriteLine("Please enter number over zero");
    }
      
    //Days of the week
    Console.WriteLine("Enter any day of the week");
    num=Convert.ToInt32(Console.ReadLine());

    switch(num)
    {
        case 1:Console.WriteLine("Monday");
               Console.WriteLine("No");break;
        case 2:Console.WriteLine("Tuesday");
               Console.WriteLine("No");break;
        case 3:Console.WriteLine("Wednesday");
               Console.WriteLine("No");break;
        case 4:Console.WriteLine("Thursday");
               Console.WriteLine("No");break;
        case 5:Console.WriteLine("Friday");
               Console.WriteLine("No");break;
        case 6:Console.WriteLine("Saturday");
               Console.WriteLine("Yes");break;
        case 7:Console.WriteLine("Sunday");
               Console.WriteLine("Yes");break;
        default:Console.WriteLine("Wrong!");break;
    }
  }
}

