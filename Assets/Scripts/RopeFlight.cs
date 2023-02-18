using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RopeFlight : MonoBehaviour
{
    [SerializeField] private string _tag;

    private HingeJoint2D _joint;
    private string _current;

    private void Start()
    {
        _joint = GetComponent<HingeJoint2D>();
        _current = gameObject.tag;
    }

    private void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag != _current)
        {
            Rigidbody2D rb = collision.gameObject.GetComponent<Rigidbody2D>();

            _joint.connectedBody = rb;
            _joint.enabled = true;
            _current = collision.gameObject.tag;
        }
    }
}
