using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccApplyer : MonoBehaviour
{
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(-MotionManager.acc, ForceMode.Acceleration);
    }
}
