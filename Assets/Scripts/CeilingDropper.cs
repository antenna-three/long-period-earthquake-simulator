using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CeilingDropper : MonoBehaviour
{
    public float dropAccMin;
    public float dropAccMax;
    private Rigidbody rb;
    private SpringJoint sj;
    private float dropAcc;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        sj = GetComponent<SpringJoint>();
        dropAcc = Random.Range(dropAccMin, dropAccMax);
    }

    // Update is called once per frame
    void Update()
    {
        if (MotionManager.acc.magnitude > dropAcc)
        {
            Destroy(sj);
            rb.constraints = RigidbodyConstraints.None;
        }
    }
}
