using DigitalWorlds.StarterPackage2D;
using UnityEngine;

public class FenceBehavior : MonoBehaviour 
{
    private Score debt;
    public int max_score;
    public GameObject levelEndText;
    public GameObject endDoor;
    public GameObject endTeleport;
    public AudioClip doorSound;
    public AudioSource audioSource;
    private bool levelFinished = false;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        debt = GameObject.Find("Debt").GetComponent<Score>();
        int current_score = debt.GetScore();
        
        if (collision.gameObject.tag == "Player" && current_score == max_score && levelFinished == false)
        {
            // Tutorial Text
            levelEndText.SetActive(true);

            // Opens the exit door and activates teleporter
            audioSource.PlayOneShot(doorSound);
            endDoor.SetActive(false);
            endTeleport.SetActive(true);
            levelFinished = true;
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
