using System;

public static class PlayerObserverManager
{
    private static int lastSavedCoins = 0;
    public static event Action<int> OnCoinCollected;

    public static void SendCoinCollected(int currentCoins)
    {
        lastSavedCoins = currentCoins;
        OnCoinCollected?.Invoke(currentCoins);
    }

    public static int GetCurrentCoins()
    {
        return lastSavedCoins;
    }

    public static void ResetCoins()
    {
        lastSavedCoins = 0;
    }
}