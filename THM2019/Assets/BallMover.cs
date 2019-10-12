using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMover : MonoBehaviour
{
    Rigidbody rb;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float a, b;
        a=Input.GetAxis("Horizontal");
        b=Input.GetAxis("Vertical");
        rb.AddForce(speed * new Vector3(a, 0f, b));
    }
}
