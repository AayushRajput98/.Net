using System;
public class Parent
{
    public virtual void show1()
    {
        Console.WriteLine("This is virtual in parent class");
    }
    public virtual void show2()
    {
        Console.WriteLine("This is virtual in parent class");
    }
    public virtual void show3()
    {
        Console.WriteLine("This is virtual in parent class");
    }
}
public class Child:Parent
{
public new void show1()
{
Console.WriteLine("This is show1 in Child class");
}
public override void show2()
{
Console.WriteLine("This is show2 in Child class");
}
public void show3()
{
Console.WriteLine("This is show3 in Child Class");
}
public static void Main()
{
Child c=new Child();
Parent p=new Parent();
Parent pc=new Child();
Console.WriteLine("This is called by child object");
c.show1();
c.show2();
c.show3();
Console.WriteLine("This is called by parent object");
p.show1();
p.show2();
p.show3();
Console.WriteLine("This is called by parent object intialized by new child");
pc.show1();
pc.show2();
pc.show3();
}
}