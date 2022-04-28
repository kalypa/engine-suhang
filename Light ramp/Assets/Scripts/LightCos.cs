using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightCos : MonoBehaviour
{
    [SerializeField]
    private Light lightRamp;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        lightRamp.intensity = (Mathf.Cos(Time.time) + 1f) * 0.5f
            ;
    }
}
