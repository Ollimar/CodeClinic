using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public Camera[] cameras;

    // Start is called before the first frame update
    void Start()
    {
        cameras[1].enabled = false;
        cameras[1].GetComponent<Animator>().enabled = false;

        cameras[2].enabled = false;
        cameras[2].GetComponent<Animator>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeCamera()
    {
        cameras[1].enabled = true;
        cameras[1].GetComponent<Animator>().enabled = true;

        cameras[0].enabled = false;
        cameras[0].GetComponent<Animator>().enabled = false;
    }

    public void ChangeCamera2()
    {
        cameras[2].enabled = true;
        cameras[2].GetComponent<Animator>().enabled = true;

        cameras[1].enabled = false;
        cameras[1].GetComponent<Animator>().enabled = false;
    }
}
