using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //SerializeField macht einen Button im Unity Editor
    [SerializeField]
    private float speed = 5f;

    [SerializeField]
    float bulletCoolOffTime = 0.2f;

    [SerializeField]
    float timer = 0;

    [SerializeField]
    private GameObject bullet;

    private Rigidbody2D rigidBody;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame, FixedUpdate nimmt einen mit DataTime berechneten Zeitabstand
    // Physik-basierte Sachen mit FixedUpdate
    void FixedUpdate()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        //Spieler wird unendlich nach rechts bewegt
        //transform.position += new Vector3(0.1f,0,0);
        Debug.Log(horizontalInput);
        //transform.position += new Vector3(horizontalInput, 0, 0);
        rigidBody.linearVelocity = new Vector2(horizontalInput * speed, rigidBody.linearVelocity.y);

        if (timer <= bulletCoolOffTime)
        {
            timer += Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.Space))
        {
            Vector3 bulletPosition = new Vector3(
                transform.position.x,
                transform.position.y + 0.7f,
                0
            );
            GameObject currentBullet = Instantiate(bullet, bulletPosition, Quaternion.identity);
            timer = 0;
        }
    }
}
