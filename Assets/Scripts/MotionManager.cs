using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class MotionManager : MonoBehaviour
{
    public static string fileName = "area01_kng_floor30.csv";
    private float tick;
    public static Vector3 acc;
    public static Vector3 pos;
    public static Vector3 sd;
    public float skipTime;
    private List<Vector3> accs;
    private List<Vector3> poss;
    private List<Vector3> sds;
    private float startTime;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start called");
        acc = Vector3.zero;
        pos = Vector3.zero;
        sd = Vector3.zero;
        accs = new List<Vector3>();
        poss = new List<Vector3>();
        sds = new List<Vector3>();
        tick = 0f;
        startTime = Time.time;

        string path = Application.streamingAssetsPath + "/waves/" + fileName;
        using (var fs = new StreamReader(path))
        {
            while (fs.Peek() != -1)
            {
                string line = fs.ReadLine();
                if (line.StartsWith("//")) continue;
                string[] row = line.Split(',');
                float t = Convert.ToSingle(row[0]);
                if (tick == 0 && t != 0)
                {
                    tick = t;
                }
                accs.Add(new Vector3(
                    Convert.ToSingle(row[17]) / 1000f,
                    0,
                    Convert.ToSingle(row[34]) / 1000f
                ));
                poss.Add(new Vector3(
                    Convert.ToSingle(row[15]) / 1000f,
                    0,
                    Convert.ToSingle(row[32]) / 1000f
                ));
                sds.Add(new Vector3(
                    Convert.ToSingle(row[11]),
                    0,
                    Convert.ToSingle(row[28])
                ));
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        float time = Time.time + skipTime - startTime;
        float index = time / tick;
        int floor = (int)Math.Floor(index);
        float remaining = index - floor;

        static T GetItem<T>(List<T> list, int index, T defaultValue)
        {
            try
            {
                return list[index];
            }
            catch (System.IndexOutOfRangeException)
            {
                return defaultValue;
            }
        }

        acc = GetItem(accs, floor, Vector3.zero) * (1 - remaining) + GetItem(accs, floor + 1, Vector3.zero) * remaining;
        pos = GetItem(poss, floor, Vector3.zero) * (1 - remaining) + GetItem(poss, floor + 1, Vector3.zero) * remaining;
        sd = GetItem(sds, floor, Vector3.zero) * (1 - remaining) + GetItem(sds, floor + 1, Vector3.zero) * remaining;
    }
}
