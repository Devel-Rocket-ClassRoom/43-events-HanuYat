using System;

class GameEventArgs : EventArgs
{
    public string EventName { get; }
    public object Data { get; } = new object();

    public GameEventArgs(string name, object data)
    {
        EventName = name;
        Data = data;
    }
}