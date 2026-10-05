using UnityEngine;

public class InvaderController : MonoBehaviour
{
    [SerializeField]
    private float moveDistance = 0.2f;

    [SerializeField]
    private float seconds = 1f;

    [SerializeField]
    private float stepDown = 0.3f;

    private float timer = 0f;
    private int direction = 1;
    private bool hitWall = false;

    // Called by any invader that touches a wall
    public void OnInvaderHitWall()
    {
        hitWall = true;
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer < seconds)
            return;
        timer = 0f;

        if (hitWall)
        {
            // This step goes down instead of sideways, then reverse
            direction *= -1;
            transform.position += Vector3.down * stepDown;
            hitWall = false;
        }
        else
        {
            transform.position += Vector3.right * moveDistance * direction;
        }
    }
}
