using System;
public class Parent
{
    public virtual void showP()
    {
        Console.WriteLine("Parent Class called");
    }
}
public class A:Parent
{
    public sealed override void showP() //sealed is used to avoid overriding a method which is once overriden.. We must use override with shield.And it only prevents overriding the method not redefining it.     
    {
        Console.WriteLine("Parent A Show method sealed");
    }
}
sealed class B:A
{
    public override void showP()
    {
        Console.WriteLine("Parent B Show method sealed");
    }
}
class C:A
{
public new void showP()
{
    Console.WriteLine("Child C Show method sealed");
}
public static void Main()
{
C obc=new C();
B obb=new B();
A oba=new A();
Console.WriteLine("-------------------------------Object of class A created-------------------------------------------");
oba.showP();
Console.WriteLine("-------------------------------Object of class B created-------------------------------------------");
obb.showP();
Console.WriteLine("-------------------------------Object of class C created-------------------------------------------");
obc.showP();

}
}