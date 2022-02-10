using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntegerExample : MonoBehaviour
{
    public int energy = 100;

    // Start is called before the first frame update
    void Start()
    {
        energy = 100;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Player has: " + energy + " hitpoints");

        if (Input.GetKeyDown(KeyCode.A))
        {
            energy += 1;
        }

        if(Input.GetKeyDown(KeyCode.F))
        {
            energy -= 1;
        }

        if(energy <= 0)
        {
            print("Player is död");
        }
    }
}
