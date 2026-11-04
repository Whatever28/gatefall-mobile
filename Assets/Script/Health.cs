using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

// Lessons 4, 5, 7 and 9 combined into the Health component.
public class Health : MonoBehaviour
{
    public int hp = 3;
    public AudioClip hurtClip;
    public AudioClip pickupClip;
    bool invincible;
    SpriteRenderer sr;
    AudioSource src;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        src = GetComponent<AudioSource>();
        Debug.Log("HP: " + hp);
    }

    public void TakeDamage(int dmg)
    {
        if (invincible) return;
        hp -= dmg;
        src.PlayOneShot(hurtClip);
        Debug.Log("HP: " + hp);
        StartCoroutine(Invincibility());
        if (hp <= 0) GameOver();
    }

    public void Heal(int amount)
    {
        hp += amount;
        src.PlayOneShot(pickupClip);
        Debug.Log("HP: " + hp);
    }

    IEnumerator Invincibility()
    {
        invincible = true;
        for (int i = 0; i < 10; i++)
        {
            sr.enabled = !sr.enabled;
            yield return new WaitForSeconds(0.2f);
        }
        sr.enabled = true;
        invincible = false;
    }

    void GameOver()
    {
        Debug.Log("Game over");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
