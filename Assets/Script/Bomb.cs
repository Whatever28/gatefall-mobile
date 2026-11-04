using UnityEngine;

// Lesson 3. The visual effect implements its mini-task; no area damage bonus.
public class Bomb : MonoBehaviour
{
    public GameObject explosionPrefab;

    void Start()
    {
        Invoke(nameof(Explode), 2f);
    }

    public void Explode()
    {
        GameObject effect = Instantiate(explosionPrefab, transform.position, Quaternion.identity);
        Destroy(effect, 0.6f);
        Destroy(gameObject);
    }
}
