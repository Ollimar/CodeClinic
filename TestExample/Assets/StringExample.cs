using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StringExample : MonoBehaviour
{
    public string playerName;
    public TextMeshProUGUI textField;

    // Start is called before the first frame update
    void Start()
    {
        textField.text = playerName;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
