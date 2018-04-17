using System;
class throw_key{
    public void fun1()
    {
        try
        {
            int a=0;
            int b=10/a;
        }
        catch(Exception e)
        {
            Console.WriteLine("Catched Exception "+e);
            throw e;
        }
    }
    public static void Main()
    {
        try
        {
            throw_key obj=new throw_key();
            obj.fun1();
        }
        catch(Exception e)
        {
            Console.WriteLine("Main Catched ecxception "+e);
        }
        
    }
}