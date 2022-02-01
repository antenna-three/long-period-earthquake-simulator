using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenShotCapturer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            string date = DateTime.Now.ToString("yyyyMMddHHmmss");
            ScreenCapture.CaptureScreenshot($"ss_{date}.png");
        }
    }
}
