using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorExample : MonoBehaviour
{

    public Vector3 movement; 

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(1f,5f,7f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(movement*1f*Time.deltaTime);
    }

    void FixedUpdate()
    {
        //GetComponent<Rigidbody>().velocity = new Vector3(movement.x,GetComponent<Rigidbody>().velocity.y,movement.z) * 1f;
    }
}
