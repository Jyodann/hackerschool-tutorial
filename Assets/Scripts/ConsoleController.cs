using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConsoleController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("Hello! I'm a test message!");
        Debug.LogWarning("I'm a warning!");
        Debug.Log("Here's an error:");
        this.GetComponent<Rigidbody>().velocity = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
