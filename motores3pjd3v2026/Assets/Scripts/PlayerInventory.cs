using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    private int coinsCount = 0;

    private void OnEnable()
    {
        PlayerObserverManager.OnCoinTriggered += AddCoin;
    }

    private void OnDisable()
    {
        PlayerObserverManager.OnCoinTriggered -= AddCoin;
    }

    private void AddCoin()
    {
        coinsCount++;
        PlayerObserverManager.NotifyCoinCollected(coinsCount);
    }
}