using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public float speed = 3f;
    public float changeTime = 3f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Change",3f,3f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    public void Change()
    {
        speed = -speed;
    }
}
