using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCracker : MonoBehaviour
{
    public float crackSdMin, crackSdMax;
    private float crackSd;
    private MeshRenderer mr;
    private Color32 delta = new Color32(0, 0, 0, 1);
    private bool cracked;

    // Start is called before the first frame update
    void Start()
    {
        crackSd = Random.Range(crackSdMin, crackSdMax);
        mr = GetComponent<MeshRenderer>();
        mr.material.color -= new Color(0, 0, 0, 1f);
        cracked = false;
    }

    // Update is called once per frame
    void Update()
    {
        float sd = MotionManager.sd.x;
        if (sd > crackSd)
        {
            cracked = true;
        }
        if (cracked)
        {
            Color color = mr.material.color;
            color.a = System.Math.Min(color.a + Time.deltaTime, 1f);
            mr.material.color = color;
        }
    }
}
