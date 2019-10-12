using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider other)
    {
        GameManager.instance.AddScore();
        Destroy(gameObject);
    }
}
