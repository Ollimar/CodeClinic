using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListExample : MonoBehaviour
{

    public List<string> players;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Jump"))
        {
            AddName();
        }

        if (Input.GetButtonDown("Fire1"))
        {
            RemoveName();
        }
    }

    void AddName()
    {
        players.Add("Antti");
    }

    void RemoveName()
    {
        players.Remove("Antti");
    }
}
