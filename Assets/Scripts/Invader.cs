using UnityEngine;

public class Invader : MonoBehaviour
{
    private InvaderController grid;

    void Start()
    {
        // Find the InvaderController on the parent object
        grid = GetComponentInParent<InvaderController>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Wall"))
        {
            grid.OnInvaderHitWall();
        }
    }
}
