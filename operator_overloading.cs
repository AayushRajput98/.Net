using System;
class A
{
    int a;
    int b;
     public A(int a, int b)
    {
        this.a=a;
        this.b=b;
    }
    public static A operator+(A obx, A oby)
    {
        return new A(obx.a+oby.a,obx.b+oby.b);
    }
    public void show()
    {
        Console.WriteLine(a+"+i"+b);
    }
    public static void Main()
    {
        A oba=new A(10,5);
        A obb=new A(11,3);
        oba.show();
        obb.show();
        A obc=oba+obb;
        obc.show();
        Console.ReadKey();
    }
}
