using UnityEngine;

public class SurvivalTimer : MonoBehaviour
{
    public float goal = 60f;
    public Animator gateAnimator;
    float t;
    bool won;
    public float Elapsed => t;
    public bool HasWon => won;

    void Update()
    {
        t += Time.deltaTime;
        if (!won && t >= goal)
        {
            won = true;
            Debug.Log("YOU WIN!");
            gateAnimator.SetBool("Open", true);
        }
    }
}
