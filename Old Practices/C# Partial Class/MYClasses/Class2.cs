using System;



    public partial class MyClass
    {

    public void Method2()
    {
        Console.WriteLine("Ssiya");
    }

    partial void Method3()
    {
       Console.WriteLine(" Im The King :-)" );
    }

    public void Method4()
    {
        Method3 ();
    }
}

