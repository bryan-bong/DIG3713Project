using DigitalWorlds.StarterPackage2D;
using UnityEngine;

public class Trading : MonoBehaviour
{
    private Score debt;
    private Inventory inventory;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
        debt = GameObject.Find("Debt").GetComponent<Score>();

        if (inventory.HasItem("Prison Wine") && collision.gameObject.tag == "Player")
        {
            inventory.DeleteItemFromInventory("Prison Wine");
            debt.AdjustScore(30);
        }
    }
}
