using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaManager : MonoBehaviour
{
    public static string area = "01";
    public GameObject area10;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (area == "01")
        {
            area10.SetActive(false);
        }
        else
        {
            area10.SetActive(true);
        }
    }
}
