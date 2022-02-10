using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotattor : MonoBehaviour
{
    public Transform target;
    public float rotationSpeed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Quaternion targetRotation = Quaternion.LookRotation(target.position - transform.position);
        print(targetRotation);
        transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
    }
}
