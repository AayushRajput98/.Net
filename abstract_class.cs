using System;
abstract class A
{
    abstract public float area(int a, int b);
    abstract public float area(int a);
    abstract public float area(float a);
}
class B:A
{
public override float area(int a, int b)
{
 return a*b;
}
public override float area(int a)
{
return a*a;
}
public override float area(float a)
{
 return 3.14f*a*a;
}
public static void Main()
{
Console.WriteLine("Enter Your Choice");
Console.WriteLine("1. Area of rectangle");
Console.WriteLine("2. Area of square");
Console.WriteLine("3. Area of circle");
int b=int.Parse(Console.ReadLine());
A obj=new B();
float ar=0;
switch(b)
{
case 1:{
Console.WriteLine("Enter The Dimenssions");
int p=int.Parse(Console.ReadLine());
int c=int.Parse(Console.ReadLine());
ar=obj.area(p,c);
break;
}
case 2:
{
Console.WriteLine("Enter The Dimenssions");
int p=int.Parse(Console.ReadLine());
ar=obj.area(p);
break;
}
case 3:
{
Console.WriteLine("Enter The Dimenssions");
float p=float.Parse(Console.ReadLine());
ar=obj.area(p);
break;
}
}
Console.WriteLine("The area is "+ar);
}
}