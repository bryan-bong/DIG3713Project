using DigitalWorlds.StarterPackage2D;
using UnityEngine;

public class BossFight : MonoBehaviour
{
    private Inventory inventory;
    public GameObject exitBarrier;
    public GameObject barrier;
    public GameObject boss;

    public GameObject phase1;
    public GameObject phase2;
    public GameObject phase3;

    public AudioSource audioSource;
    public AudioClip barrierSound;

    public static int collectedGems = 0;
    public bool red, blue, green, gold = false;
    bool bossFightStarted = false;

    public static void GemCollection()
    {
        collectedGems++;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
        if (collectedGems == 4)
        {
            boss.SetActive(false);
            exitBarrier.SetActive(false);
        }

        if (inventory.HasItem("RedGem") && !red)
        {
            GemCollection();
            red = true;
        }

        if (inventory.HasItem("BlueGem") && !blue)
        {
            GemCollection();
            blue = true;
        }

        if (inventory.HasItem("GreenGem") && !green)
        {
            GemCollection();
            green = true;
        }

        if (inventory.HasItem("GoldGem") && !gold)
        {
            GemCollection();
            gold = true;
        }

        if (collectedGems > 0)
        {
            phase1.SetActive(true);
        }

        if (collectedGems > 1)
        {
            phase2.SetActive(true);
        }

        if (collectedGems > 2)
        {
            phase3.SetActive(true);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            barrier.SetActive(true);
            if (!bossFightStarted)
            {
                bossFightStarted=true;
                audioSource.PlayOneShot(barrierSound);
                boss.SetActive(true);
            }
        }
    }

}
