using System;

static class EventManager
{
    public static event EventHandler<GameEventArgs> OnGameEvent;

    public static void TriggerEvent(string eventName, object data = null)
    {
        GameEventArgs e = new GameEventArgs(eventName, data);

        if (data != null)
        {
            OnGameEvent?.Invoke(data, e);
        }
    }
}