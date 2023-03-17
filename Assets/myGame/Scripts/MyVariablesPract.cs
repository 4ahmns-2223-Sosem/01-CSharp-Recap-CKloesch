using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyVariablesPract : MonoBehaviour
{
    public int integerVar;
    public bool boolVar;
    public float floatVar;
    public string stringVar;

    public GameObject gameObjectVar;

    // Value Variablen speichern einen Wert, Referenzvariablen speichern eine Adresse
    void Start()
    {
        integerVar = 3;
        boolVar = true;
        floatVar = 4.3f;
        stringVar = "Hello World";

        gameObjectVar = FindObjectOfType<GameObject>();

        Debug.Log(integerVar);
        Debug.Log(boolVar);
        Debug.Log(floatVar);
        Debug.Log(stringVar);

        if (gameObjectVar.name == "Variablen")
        {
            Debug.Log("GameObject zugewiesen");
        }
    }
}
