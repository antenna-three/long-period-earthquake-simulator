using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocationManager : MonoBehaviour
{
    public static string location = "kng";
    private static Dictionary<string, Vector3> positions
        = new Dictionary<string, Vector3>()
    {
        {"kng", new Vector3(-90, 0, 46)},
        {"tky", new Vector3(-84, 0, 94)}
    };

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = positions[location];
    }
}
