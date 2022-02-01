using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorManager : MonoBehaviour
{
    public static string floor = "30";
    public GameObject building;
    private static Dictionary<string, Vector3> offsets
        = new Dictionary<string, Vector3>()
    {
        {"1", new Vector3(8, 15, 0)},
        {"15", new Vector3(8, 33, 0)},
        {"30", new Vector3(8, 51, 0)}
    };

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = building.transform.position + offsets[floor];
    }
}
