using UnityEngine;

public class RBNav : MonoBehaviour
{
    [SerializeField] private float speed = 10f;
    Rigidbody _rb;
    Vector2 _movement;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        _movement = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
    }

    private void FixedUpdate()
    {
        MovePositionRB(_movement);
    }

    void AddForce()
    {
        _rb.AddForce(_movement);
    }

    void MovePositionRB(Vector2 _direction)
    {
        _rb.MovePosition(_rb.position + new Vector3(_direction.x, 0, _direction.y) * speed * Time.fixedDeltaTime);
    }
}
