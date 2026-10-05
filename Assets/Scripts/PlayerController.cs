using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float speed = 5f;

    [SerializeField]
    private float bulletCoolOffTime = 0.5f;

    [SerializeField]
    private GameObject bullet;

    private Rigidbody2D rigidBody;
    private float timer = 0f;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    // Shooting: every frame
    void Update()
    {
        timer += Time.deltaTime;

        if (Input.GetKey(KeyCode.Space) && timer >= bulletCoolOffTime)
        {
            Instantiate(bullet, transform.position + Vector3.up * 0.7f, Quaternion.identity);
            timer = 0f;
        }
    }

    // Movement: physics, fixed timestep
    void FixedUpdate()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        rigidBody.linearVelocity = new Vector2(horizontalInput * speed, rigidBody.linearVelocity.y);
    }
}
