using System;
class Login
{
    public String Uname{get;set;}
    public String Password{protected get; set;}
}
class setLogin
{
    public static void Main()
    {
        Login obj=new Login();
        obj.Uname="Aaysuh";
        Console.WriteLine("UserName is "+obj.Uname);
        obj.Password="1234";
        //Console.Write(obj.Password);
    }
}