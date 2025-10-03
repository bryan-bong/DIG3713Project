using DigitalWorlds.StarterPackage2D;
using UnityEngine;

public class KeyPossession : MonoBehaviour
{
    public Inventory inventory;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
        if (inventory.HasItem("Jail Cell Key"))
        {
            inventory.DeleteItemFromInventory("Jail Cell Key");
            if (collision.gameObject.tag == "Player")
            {
                Destroy(gameObject);
            }
        }
    }
}

