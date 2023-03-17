using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyForLoopsPract : MonoBehaviour
{
    int b = 0;
   

    
    void Update()
    {
        for (int i = 0; i < 10; i++)
        {
            b = i;
            Debug.Log(b);
        }

        if (b == 9)
        {
            Debug.Log("Loop finished");
        }
    }
}
