using System;
class multiple
{
public static void Main()
{
int t=10;
    int j=0;
int[] a=new int [3];
try
{
    for(int i=0;i<4;i++)
    {
        a[i]=Int32.Parse(Console.ReadLine());
    }
    int b=t/j;
}
    catch(DivideByZeroException e)
    {
        Console.WriteLine("Exception Occured\n"+e);
    }
    catch(Exception e)
    {
        Console.WriteLine("Exception Occured\n"+e);
    }
}
}