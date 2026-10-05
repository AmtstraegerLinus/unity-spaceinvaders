using UnityEngine;

public class InvaderController : MonoBehaviour
{
    public GameManager GameManager = new GameManager();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() { }

    [SerializeField]
    private float moveDistance = 0.2f;

    [SerializeField]
    private float seconds = 1;

    [SerializeField]
    private float timer = 0;

    [SerializeField]
    private int direction = 1;

    // Update is called once per frame
    void Update()
    {
        if (timer <= seconds)
        {
            timer += Time.deltaTime;
        }
        else
        {
            timer = 0;
            transform.position = new Vector3(
                transform.position.x + moveDistance * direction,
                transform.position.y,
                0
            );
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            direction *= -1;
        }
    }

    // private void OnTriggerEnter2D(Collider2D collision)
    // {
    //     if (collision.gameObject.tag == "Wall")
    //     {
    //         direction *= -1;
    //     }
    // }
}
