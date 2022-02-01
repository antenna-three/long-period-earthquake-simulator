using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainSceneLoader : MonoBehaviour
{
    public void OnClick()
    {
        string area = AreaManager.area;
        string location = LocationManager.location;
        string floor = FloorManager.floor;
        string fileName = $"area{area}_{location}_floor{floor}.csv";
        MotionManager.fileName = fileName;
        SceneManager.LoadScene("Main");
    }
}
