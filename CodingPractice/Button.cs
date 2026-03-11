using System;

class Button
{
    public event EventHandler1 Click;

    public void OnClick()
    {
        Click?.Invoke();
    }    
}