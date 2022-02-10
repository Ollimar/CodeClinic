using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastExample : MonoBehaviour
{
    public float rayLength = 20f;

    public LayerMask layerMask;

    // Start is called before the first frame update
    void Start()
    {
        
    }

   
    void FixedUpdate()
    {
        Debug.DrawRay(transform.position, transform.forward* rayLength, Color.green,1f);

        if(Physics.Raycast(transform.position,transform.forward, rayLength, layerMask))
        {
            print("hit something");
        }
    }
}
