using UnityEngine;
using UnityEngine.SceneManagement;

public class Player2D : MonoBehaviour
{
    public float speed = 7f;
    public float jumpForce = 12f;

    private Rigidbody2D rb;
    private Animator anim;
    private SpriteRenderer sr;
    private Animator gate;
    private bool onGround;
    private int coins;
    private int coinsTotal;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
    }

    void Start()
    {
        coinsTotal = GameObject.FindGameObjectsWithTag("Coin").Length;
        // A5: minimum code required to connect the exit Animator.
        gate = GameObject.FindGameObjectWithTag("Exit").GetComponent<Animator>();
        Debug.Log("Coins in this level: " + coinsTotal);
    }

    void Update()
    {
        // Animation parameter lines from the teacher's lesson kit.
        float x = Input.GetAxisRaw("Horizontal");
        anim.SetFloat("Speed", Mathf.Abs(x));
        if (x != 0) sr.flipX = x < 0;
        anim.SetBool("Grounded", onGround);

        // a jump is a single press: Update catches it, FixedUpdate can miss it
        if (Input.GetKeyDown(KeyCode.Space) && onGround)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
            onGround = false;
        }
    }

    void FixedUpdate()
    {
        // movement runs on the physics clock
        float x = Input.GetAxisRaw("Horizontal");
        rb.linearVelocity = new Vector2(x * speed, rb.linearVelocity.y);
    }

    // things you pass through
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
            coins++;
            gate.SetBool("Open", coins >= coinsTotal);
            Debug.Log("Coins: " + coins + " / " + coinsTotal);
        }

        if (other.CompareTag("Exit"))
        {
            if (coins >= coinsTotal)
                Debug.Log("You win!");
            else
                Debug.Log("Collect all coins first! " + coins + " / " + coinsTotal);
        }
    }

    // Ground departure check from the teacher's lesson kit.
    void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground")) onGround = false;
    }

    // things you bump into
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
            onGround = true;

        if (other.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Game over");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}

