using UnityEngine;

public class Coin : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(Vector3.up * 90 * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") || (other.attachedRigidbody != null && other.attachedRigidbody.CompareTag("Player")))
        {
            PlayerObserverManager.NotifyCoinTriggered();
            Destroy(gameObject);
        }
    }
}