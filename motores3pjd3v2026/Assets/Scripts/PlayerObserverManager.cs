using System;

public static class PlayerObserverManager
{
    public static event Action OnCoinTriggered;
    public static event Action<int> OnCoinCollected;

    public static void NotifyCoinTriggered()
    {
        OnCoinTriggered?.Invoke();
    }

    public static void NotifyCoinCollected(int currentCoins)
    {
        OnCoinCollected?.Invoke(currentCoins);
    }
}