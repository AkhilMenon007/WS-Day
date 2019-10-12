using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMover : MonoBehaviour
{
    Transform camTransform;
    public Transform playerTransform;
    // Start is called before the first frame update
    Vector3 offset;
    void Start()
    {
        camTransform = GetComponent<Transform>();
        offset = camTransform.position - playerTransform.position;
    }

    // Update is called once per frame
    void Update()
    {
        camTransform.position = playerTransform.position + offset;
    }
}
