using DigitalWorlds.StarterPackage2D;
using UnityEngine;

public class KeyPossession : MonoBehaviour
{
    private Inventory inventory;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
        if (inventory.HasItem("Jail Cell Key"))
        {
            if (collision.gameObject.tag == "Player")
            {
                inventory.DeleteItemFromInventory("Jail Cell Key");
                Destroy(gameObject);
            }
        }
    }
}

