using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomExample : MonoBehaviour
{
    public int diceNumber;

    public float randomPercentage;

    public List<GameObject> shapeObjects;
    public GameObject[] shapes;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            ThrowDice();
        }
    }

    public void ThrowDice()
    {
        diceNumber = Random.Range(0,shapes.Length);
        Instantiate(shapes[diceNumber], transform.position, transform.rotation);
        shapeObjects.Add(shapes[diceNumber]);
    }
}
