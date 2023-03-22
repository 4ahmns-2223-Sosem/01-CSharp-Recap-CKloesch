using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyMethodsPract : MonoBehaviour
{
    
    void Start()
    {
        Debug.Log(IntAddierer(3, 4));
        Debug.Log(NamenAusgeber("Caro", "Klösch"));
        Debug.Log(Division(3.4f, 2.8f));
        Debug.Log(Decision(true, false));
    }

    public int IntAddierer(int a, int b)
    {
        int c = a + b;
        return c;
    }

    public string NamenAusgeber(string vorname, string nachname)
    {
        string name = vorname + " " + nachname;
        return name;
    }

    public float Division(float a, float b)
    {
        float c = a / b;
        return c;
    }

    public bool Decision(bool yes, bool no)
    {
        bool outcome = no;
        return outcome;
    }
}
