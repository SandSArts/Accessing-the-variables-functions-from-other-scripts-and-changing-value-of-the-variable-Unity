using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_1 : MonoBehaviour
{
    public float health;
    // Start is called before the first frame update
    void Start()
    {
       health-=7f; 
    } 

    void Print()
    {
        Debug.Log("Hello");
    }

  
}
