using System;
class B
{
    public static void Main(){ //ReadLine is equivalent to nextLine in java,we can also use Read or ReadKey.
    int a,b,c;
        Console.Write("Enter the number: ");
        a=int.Parse(Console.ReadLine()); //Each keyword is a synonum of a particular class so it can be used to call a method.
        Console.Write("Enter the number: ");
        b=Int32.Parse(Console.ReadLine()); //Int32 is a class that is denoted by the keyword 'int'.
        Console.Write("Sum= "+(a+b));        
    }
}