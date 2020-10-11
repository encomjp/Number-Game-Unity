using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    // Start is called before the first frame update
    private int highestNumber = 50;
    private int lowestNumber = 1;
    void Start()
    { 
        Debug.Log("Welcome to number wizard");
        Debug.Log("Pick a number:");
        Debug.Log("Highest number is: " + highestNumber);
        Debug.Log("Lowest number is: " + lowestNumber);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
