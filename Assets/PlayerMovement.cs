using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed; // Speed of the player
    public AudioSource collectAudio;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        collectAudio = GetComponent<AudioSource>();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        rb.MovePosition(rb.position + movement.normalized * speed * Time.fixedDeltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Coletavel")
        {
            collectAudio.Play();
            GameController.Collect();
            Destroy(other.gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Zumbi"))
        {
            GameController.GameOverByZombie();
        }
    }
}
