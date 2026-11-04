using UnityEngine;

// ДВИЖЕНИЕ + ПРЫЖОК + АНИМАЦИЯ. Продолжение урока физики.
// Требует: Rigidbody2D, BoxCollider2D, Animator (параметр Speed: Float), SpriteRenderer.
// Unity 6: rb.linearVelocity -> rb.linearVelocity (2 места).
public class SurvivalPlayerController : MonoBehaviour
{
    public float speed = 7f;
    public float jumpForce = 12f;

    Rigidbody2D rb;
    Animator anim;
    SpriteRenderer sr;
    bool grounded;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        rb.linearVelocity = new Vector2(x * speed, rb.linearVelocity.y);

        if (Input.GetKeyDown(KeyCode.Space) && grounded)
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);

        // === АНИМАЦИЯ: 3 строки ===
        anim.SetFloat("Speed", Mathf.Abs(x));   // Idle <-> Walk решает Animator
        if (x != 0) sr.flipX = x < 0;           // разворот влево/вправо
        anim.SetBool("Grounded", grounded);     // для прыжка (если добавите состояние Jump)
    }

    void OnCollisionEnter2D(Collision2D c)
    {
        if (c.gameObject.CompareTag("Ground")) grounded = true;
    }

    void OnCollisionExit2D(Collision2D c)
    {
        if (c.gameObject.CompareTag("Ground")) grounded = false;
    }
}

