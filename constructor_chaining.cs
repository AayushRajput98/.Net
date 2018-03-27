using System;
public class A
{ int a,b;
    public A()
    {
        Console.WriteLine("This is A class' default constructor");
    }
    public A(int a,int b):this()
    {
        this.a=a;
        this.b=b;
        Console.WriteLine("This is the parametrized constructor of A class setting the value of a to "+a+" and b to "+b);
    }
}
public class B:A
{
public B():base(10,3)
{
Console.WriteLine("This is B class' default constructor");
}
}
public class C
{
public C()
{
Console.WriteLine("This is C class' default constructor");
}
}
public class D:C
{
public D()
{
Console.WriteLine("This is D class' default constructor");
}
}
class run
{
    public static void Main()
    {   Console.WriteLine();
        Console.WriteLine("-------------------------------Object of class A created-------------------------------------------");
        A oba=new A(10,20);
        Console.WriteLine("-------------------------------Object of class B created-------------------------------------------");
        B obb=new B();
        Console.WriteLine("-------------------------------Object of class C created-------------------------------------------");
        C obc=new C();
        Console.WriteLine("-------------------------------Object of class D created-------------------------------------------");
        D obd=new D();
    }
}