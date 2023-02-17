using UnityEngine;

public class RopeSwing : MonoBehaviour
{
    private Rigidbody2D _rigidbody;
    private float _speed = 500;

    void Start()
    {
        _rigidbody = gameObject.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        _rigidbody.AddForce(new Vector2(horizontal * _speed * Time.deltaTime, 0), ForceMode2D.Force);
    }
}