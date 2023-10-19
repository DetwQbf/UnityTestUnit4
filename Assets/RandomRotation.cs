using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRotation : MonoBehaviour
{
    public float newRotateValue = 200;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().angularVelocity = Random.value * newRotateValue;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
