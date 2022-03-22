
using System; //System이라고 이름 붙여준 라이브러리를 쓸거야.

class Hello_World
{
    static void Main()
    {
        //모든 프로그램은 Main()메소드를 하나만 가짐.
        //PrintHello("안뇽");
        //PrintHello("Hello");
        //PrintHello("Hello");
        AA var = new AA();
        var.PrintHello("Hello World too");
    }
    static void PrintHello(string str)
    {
        Console.WriteLine(str);
    }
}

class AA
{
    public void PrintHello(String str)
    {
        Console.WriteLine(str);
    }
}