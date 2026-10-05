using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField]
    private float speed = 8f;

    void Start()
    {
        GetComponent<Rigidbody2D>().linearVelocity = Vector2.up * speed;
    }

    // Destroy the bullet once it leaves the screen at the top
    void Update()
    {
        Camera cam = Camera.main;
        if (transform.position.y > cam.transform.position.y + cam.orthographicSize)
        {
            Destroy(gameObject);
        }
    }

    // On hitting an invader, destroy both
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Invader"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
