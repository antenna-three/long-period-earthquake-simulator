using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PosApplyer : MonoBehaviour
{
    private Vector3 initialPos;

    // Start is called before the first frame update
    void Start()
    {
        initialPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = initialPos - MotionManager.pos;
    }
}
