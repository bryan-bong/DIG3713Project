using DigitalWorlds.StarterPackage2D;
using UnityEngine;

public class FenceBehavior : MonoBehaviour 
{
    private Score debt;
    public GameObject levelEnd;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        debt = GameObject.Find("Debt").GetComponent<Score>();
        int current_score = debt.GetScore();
        int max_score = 100;
        if (collision.gameObject.tag == "Player" && current_score == max_score)
        {
            levelEnd.SetActive(true);
        }
    }
    public void Update()
    {
        // Ease of quitting the game
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
