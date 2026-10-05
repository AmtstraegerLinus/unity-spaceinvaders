using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        GetComponent<Rigidbody2D>().linearVelocity = new Vector3(0, 1, 0);
        // rb.linearVelocity = new Vector3(0, 1, 0);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Invader"))
        {
            Destroy(collision.gameObject);
        }
    }

    // Update is called once per frame
    void Update() { }
}
