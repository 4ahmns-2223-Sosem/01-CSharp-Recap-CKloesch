using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum State
{
    Done,
    WIP,
    Cancel
}
public class MyEnumPract : MonoBehaviour
{  
    //Deklaration
    State myState;
    
    void Start()
    {
        myState = State.Done;
        //Downcast: switch((int)myState)
        //Upcast: int i = 0; switch((myState)i)
        switch (myState)
        {
            case State.Done: 
                Debug.Log(State.Done);
                break;

            case State.WIP:
                Debug.Log(State.WIP);
                break;

            case State.Cancel:
                Debug.Log(State.Cancel);
                break;
                //gibt auch return und continue, return aus Methode raus, continue weiter, break aus switch raus

        }
        //mit IF Statements würde das so aussehen:
        if (myState == State.Done)
        {
            Debug.Log(State.Done);
        }
        else if(myState == State.WIP)
        {
            Debug.Log(State.WIP);
        }
        else
        {
            Debug.Log(State.Cancel);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
