using UnityEngine;

// Coin collection from Assignment 4, kept in Survival Mode; the gate is now controlled by time.
public class SurvivalCollectibles : MonoBehaviour
{
    int coins;
    public int Score => coins;
    int coinsTotal;
    AudioSource src;

    void Start()
    {
        coinsTotal = GameObject.FindGameObjectsWithTag("Coin").Length;
        src = GetComponent<AudioSource>();
        Debug.Log("Coins in this level: " + coinsTotal);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
            coins++;
            src.PlayOneShot(GetComponent<Health>().pickupClip);
            Debug.Log("Coins: " + coins + " / " + coinsTotal);
        }
    }
}
