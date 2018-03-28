using System;
//To overload any unary operator we have to follow some rules 
//Rule1: There should  be only one argument with operator.
//The method is same as other operator overloadded methods.
//NOTE: In case of prefix and postfix it will manage automatically by the framewrk. 
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
    public static A operator-(A obx)
    {
        return new A(--obx.a,--obx.b);
    }
    public static A operator++(A obx)
    {
        return new A(obx.a+1,obx.b+1);
    }
    public void show()
    {
        Console.WriteLine(a+"+i"+b);
    }
    public static void Main()
    {
        A oba=new A(10,5);
        A obb=new A(11,3);
        //oba.show();
        //obb.show();
        A obc=oba+obb;
        A obs=-obc;
        obs.show();
        A obin=++obs;
        A obpost=obs++;
        obpost.show();// operator smahdar hei.
        obin.show();
        //obc.show();
        Console.ReadKey();
    }
}

//Operators that cant be overloaded:
//All short hand operators.
//->, (, ) {, }, &, |
//=, ., ',', ?:, new, is, as, sizeof