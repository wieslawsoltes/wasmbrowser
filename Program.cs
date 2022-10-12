using System;
using System.Runtime.InteropServices.JavaScript;
using System.Runtime.Versioning;
using System.Threading;

[assembly:SupportedOSPlatform("browser")]

new Thread(SecondThread).Start();
Console.WriteLine($"Hello, Browser from the main thread {Thread.CurrentThread.ManagedThreadId}");

static void SecondThread()
{
    Console.WriteLine($"Hello from Thread {Thread.CurrentThread.ManagedThreadId}");
    for (int i = 0; i < 5; ++i)
    {
        Console.WriteLine($"Ping {i}");
        Thread.Sleep(1000);
    }
}

public partial class MyClass
{
    [JSExport]
    internal static string Greeting()
    {
        var text = $"Hello, World! Greetings from {GetHRef()}";
        Console.WriteLine(text);
        return text;
    }

    [JSImport("window.location.href", "main.js")]
    internal static partial string GetHRef();
}
