using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingScript : MonoBehaviour
{

    public float speed = 5f;

    public float rotationAngle = 30f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(hor,ver,0f)*speed*Time.deltaTime);

        Quaternion angle = Quaternion.Euler(ver*-rotationAngle, 0f, hor * -rotationAngle);
        transform.GetChild(0).rotation = Quaternion.Slerp(transform.GetChild(0).rotation, angle, speed * Time.deltaTime);
    }
}
