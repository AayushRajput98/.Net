using System;
class point
{
    public int X{get;set;}
    public int Y{get;set;}
}
class setPoint
{   public static void Main()
{
    point ob=new point();
    ob.X=10;
    ob.Y=9;
    Console.Write("The points are ("+ob.X+","+ob.Y+")");
}
}