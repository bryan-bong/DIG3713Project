using DigitalWorlds.StarterPackage2D;
using UnityEngine;

public class SoundEffects : MonoBehaviour
{
    public AudioClip pickUpSound;
    public AudioClip cellDoorSound;
    public AudioClip teleporterSound;
    public AudioClip detectionSound;

    public AudioSource audioSource;
    private Inventory inventory;
    public void PlayPickupSound()
    {
        audioSource.PlayOneShot(pickUpSound);
    }

    public void CellDoorOpenSound()
    {
        audioSource.PlayOneShot(cellDoorSound);
    }

    public void Teleporter()
    {
        audioSource.PlayOneShot(teleporterSound);
    }

    public void Detected()
    {
        audioSource.PlayOneShot(detectionSound);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Collectible")
        {
            PlayPickupSound();
        }

        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
        if (collision.gameObject.tag == "CellDoor" && inventory.HasItem("Jail Cell Key"))
        {
            CellDoorOpenSound();
        }

        if (collision.gameObject.tag == "Teleporter")
        {
            Teleporter();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Collectible" || collision.gameObject.tag == "Key")
        {
            PlayPickupSound();
        }

        if (collision.gameObject.tag == "Enemy")
        {
            Detected();
        }
    }
}
