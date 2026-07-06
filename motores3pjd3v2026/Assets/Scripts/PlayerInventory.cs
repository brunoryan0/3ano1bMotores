using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    private int coinsCount = 0;

    private void Start()
    {
        PlayerObserverManager.ResetCoins();
    }

    public void AddCoin()
    {
        coinsCount++;
        PlayerObserverManager.SendCoinCollected(coinsCount);
    }
}