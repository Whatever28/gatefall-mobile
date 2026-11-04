using UnityEngine;

// Assignment 6, lesson 1 + facing-direction and audio mini-tasks.
public class Shooter : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float cooldown = 0.3f;
    public AudioClip shootClip;
    float nextShot;
    AudioSource src;
    SpriteRenderer sr;

    void Start()
    {
        src = GetComponent<AudioSource>();
        sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (Time.timeScale == 0) return;
        if ((Input.GetKey(KeyCode.X) || MobileControls.FireHeld) && Time.time >= nextShot)
        {
            nextShot = Time.time + cooldown;
            Quaternion direction = Quaternion.Euler(0, 0, sr.flipX ? 180f : 0f);
            Instantiate(bulletPrefab, transform.position, direction);
            src.PlayOneShot(shootClip);
        }
    }
}
