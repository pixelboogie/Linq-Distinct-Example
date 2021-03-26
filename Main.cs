using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq; // * Linq needed


public class Main : MonoBehaviour
{
    public string[] names = {"uno", "uno", "dos", "dos", "tres", "quatro"};

    void Start()
    {
       var uniqueNames = names.Distinct();
       
        foreach(var name in uniqueNames)
        {
            Debug.Log(name);
        }
    }
}
