using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BooleanExample : MonoBehaviour
{
    public bool lightSwitch;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(lightSwitch == true)
        {
            GetComponent<Light>().enabled = true;
        }

        if (lightSwitch == false)
        {
            GetComponent<Light>().enabled = false;
        }
    }
}
