using System;
class handle_exception
{
    public int Function(int i)
    {
        try
        {
        if(1/i==0)
            Console.Write("ABDb");
            return 1;
        }
        catch(Exception e)
        {
            Console.Write(e+" Exception sotted \n");
            return 0;
        }
        finally
        {
            Console.Write("Finally called\n");
        }
    }
    public static void Main()
    {
        handle_exception obj=new handle_exception();
        int x=obj.Function(0);
        if(x==0)
            Console.Write(x+"Catch Block returned");
    }
}