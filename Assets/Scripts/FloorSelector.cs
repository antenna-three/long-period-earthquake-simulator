using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FloorSelector : MonoBehaviour
{
    public string value;
    private Button button;

    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(OnClick);
    }

    // Update is called once per frame
    void Update()
    {
        if (FloorManager.floor == value)
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

    public void OnClick()
    {
        FloorManager.floor = value;
    }
}
