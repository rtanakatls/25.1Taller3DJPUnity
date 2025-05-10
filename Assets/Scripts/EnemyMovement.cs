using UnityEngine;

public class EnemyMovement : Movement
{
    protected override void Move()
    {
        rb.linearVelocity = Vector3.right * speed;
    }
}
