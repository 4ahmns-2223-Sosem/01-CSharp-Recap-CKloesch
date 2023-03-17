using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyIfStatementsPract : MonoBehaviour
{
    public string a = "Recording";
    public string b = "Start";
    public string c = "Stop";

    private int randomInt;
    
    void Start()
    {
        randomInt = Random.Range(0, 2);
        Debug.Log(randomInt);

        if (randomInt == 0)
        {
            Debug.Log(a);
        }
        else if (randomInt == 1)
        {
            Debug.Log(b);
        }
        else
        {
            Debug.Log(c);
        }
    }
}
