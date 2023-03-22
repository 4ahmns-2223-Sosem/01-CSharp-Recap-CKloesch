using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyArraysPract : MonoBehaviour
{
    public string[] iceCream = new string[10];
    
    void Start()
    {
        Debug.Log("Choose " + FlavourChooser(iceCream) + " and " + FlavourChooser(iceCream) + "!");
    }
    public string FlavourChooser(string[] ice)
    {
        int iceInt = Random.Range(0, iceCream.Length);
        string iceCreamFlavour = iceCream[iceInt];
        return iceCreamFlavour;
    }
}
