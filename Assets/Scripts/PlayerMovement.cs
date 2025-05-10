using UnityEngine;

public class PlayerMovement : Movement
{    
    protected override void Move()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 direction = new Vector3(horizontal, 0, vertical).normalized;
        Vector3 velocity = direction * speed + new Vector3(0, rb.linearVelocity.y, 0);

        rb.linearVelocity = velocity;

        if (direction.magnitude > 0)
        {
            transform.forward = direction;
        }
    }
}
