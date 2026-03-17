using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YourDeltaTime : MonoBehaviour
{
    float deltaTime = 1f;
    bool stopMeasure = false;
    float hello = 0;
    // Update is called once per frame
    void Update()
    {
        if (stopMeasure) return;
        deltaTime -= Time.deltaTime;
        hello ++;

        if (deltaTime < 0)
        {
            stopMeasure = true; 
            print("Your number of frames is: " + hello);
        }
    }
}
