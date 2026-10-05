using UnityEngine;

public class InvaderController : MonoBehaviour
{
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

    [SerializeField]
    private float stepDown = 0.3f;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Wall"))
        {
            direction *= -1;
            transform.position += Vector3.down * stepDown;
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
