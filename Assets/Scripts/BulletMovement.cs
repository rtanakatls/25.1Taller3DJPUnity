using UnityEngine;

public class BulletMovement : Movement
{
    protected Vector3 direction;

    public void SetUp(Vector3 direction)
    {
        this.direction = direction;
    }

    protected override void Move()
    {
        rb.linearVelocity = direction.normalized * speed;
    }
}
