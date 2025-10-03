using DigitalWorlds.StarterPackage2D;
using Unity.VisualScripting;
using UnityEngine;

public class CoinPickup : MonoBehaviour
{
    private Score debt;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        debt = GameObject.Find("Debt").GetComponent<Score>();
        if (collision.gameObject.tag == "Player")
        {
            debt.AdjustScore(10);
            Destroy(gameObject);
        }
    }
}
