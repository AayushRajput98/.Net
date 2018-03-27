//Write a program to enter any two number a and b and find out a^b withot using and function.
using System;
class power
{
    public static void Main(){
    int count=1;
    Console.Write("Enter the base number: ");
    int a=int.Parse(Console.ReadLine());
        if(a==0)
            Console.Write("Invalid input");
            return;
    Console.Write("Enter the power: ");
    int b=int.Parse(Console.ReadLine());
    int ans=1;
    while(count<=b)
    {
        ans=ans*a;
        count=count+1;
    }
    Console.WriteLine("a^b= "+ans);
}
}