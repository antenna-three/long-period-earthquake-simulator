using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeViewer : MonoBehaviour
{
    private Text text;
    private float startTime;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponentInChildren<Text>();
    }

    void Awake()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        int time = (int)Math.Floor(Time.time - startTime);
        int sec = time % 60;
        int min = time / 60;
        text.text = $"{min:D2}:{sec:D2}";
    }
}
