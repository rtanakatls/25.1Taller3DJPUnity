using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] protected float speed;
    protected Rigidbody rb;

    private void Awake()
    {
        Init();
    }

    protected virtual void Init()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Move();
    }

    protected virtual void Move()
    {
        
    }
}
