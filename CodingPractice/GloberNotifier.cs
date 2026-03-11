using System;

class GlobalNotifier
{
    public static event Action<string> OnGlobalMessage;

    public GlobalNotifier(string message)
    {
        Console.WriteLine($"[Global] 메시지 전송: {message}");
        OnGlobalMessage?.Invoke(message);
    }

    public static void Module1(string message)
    {
        Console.WriteLine($"[Module1] 수신: {message}");
    }

    public static void Module2(string message)
    {
        Console.WriteLine($"[Module2] 수신: {message}");
    }
}