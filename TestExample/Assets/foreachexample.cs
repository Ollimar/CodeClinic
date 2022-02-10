using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class foreachexample : MonoBehaviour
{
    public int numberOfPlayers = 5;

    public string[] nameOfPlayer;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i<numberOfPlayers; i++)
        {
            print(i);
        }

        foreach(string number in nameOfPlayer)
        {
            print(number);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
