using UnityEngine;

public class Coin : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(Vector3.up * 90 * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.attachedRigidbody != null)
        {
            PlayerInventory inventory = other.attachedRigidbody.GetComponent<PlayerInventory>();

            if (inventory != null)
            {
                inventory.AddCoin();
                Destroy(gameObject);
            }
        }
    }
}