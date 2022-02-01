using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LocationSelector : MonoBehaviour
{
    public string location;
    private Button button;

    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(
            () => { LocationManager.location = location; }
        );
    }

    // Update is called once per frame
    void Update()
    {
        if (LocationManager.location == location)
        {
            ColorBlock cb = button.colors;
            cb.normalColor = Color.white;
            button.colors = cb;
        }
        else
        {
            ColorBlock cb = button.colors;
            cb.normalColor = Color.gray;
            button.colors = cb;
        }
    }
}
