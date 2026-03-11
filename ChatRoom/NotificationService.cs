using System;

class NotificationService
{
    public void Urgent(string sender, string message)
    {
        if (message.Contains("긴급"))
        {
            Console.WriteLine($"[알림]: 긴급 메시지 수신!");
        }
    }
}