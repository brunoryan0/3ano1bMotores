using UnityEngine;
using TMPro;

public class CoinsHUD : MonoBehaviour
{
    [SerializeField] private TMP_Text coinText; 

    private void Start()
    {
        if (coinText != null)
        {
            coinText.text = "Moedas: 0";
        }
    }

    private void OnEnable()
    {
        PlayerObserverManager.OnCoinCollected += UpdateCoinDisplay;
    }

    private void OnDisable()
    {
        PlayerObserverManager.OnCoinCollected -= UpdateCoinDisplay;
    }

    private void UpdateCoinDisplay(int currentCoins)
    {
        if (coinText != null)
        {
            coinText.text = "Moedas: " + currentCoins;
        }
    }
}