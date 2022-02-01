using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Randomizer : MonoBehaviour
{
    public float maxTranslation;
    public float maxRotation;

    // Start is called before the first frame update
    void Start()
    {
        Vector2 translation = Random.insideUnitCircle * maxTranslation;
        float rotation = Random.Range(-maxRotation, maxRotation);
        gameObject.transform.Translate(translation.x, 0, translation.y);
        gameObject.transform.Rotate(0, rotation, 0);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
