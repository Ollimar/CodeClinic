using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptCommunicationExample : MonoBehaviour
{

    public BooleanExample boolScript;

    // Start is called before the first frame update
    void Start()
    {
        boolScript = GameObject.Find("GameObject").GetComponent<BooleanExample>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Jump"))
        {
            boolScript.lightSwitch = true;
        }

        if(Input.GetButtonUp("Jump"))
        {
            boolScript.lightSwitch = false;
        }
    }
}
