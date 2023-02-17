using UnityEngine;

public class Fall : MonoBehaviour
{
    private HingeJoint2D _joint;
    private void Start()
    {
        _joint = GetComponent<HingeJoint2D>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _joint.enabled = false;
        }
    }
}
