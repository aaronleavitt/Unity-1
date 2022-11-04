using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintToConsole : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hey I'm printing to the console my boy.");
    }

    // Update is called once per frame
    void Update()
    {
        // rotates the object
        transform.Rotate(0,0,0.75f);
        // Moves object
        transform.Translate(.01f,0,0);
      
    }
}
