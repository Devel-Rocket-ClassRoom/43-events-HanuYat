using System;

class ChatLogger
{    
    public void Log(string sender, string message)
    {
        Console.WriteLine($"[로그]: {sender}: {message}");
    }
}