using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_2 : MonoBehaviour
{
    public Script_1 s;
    // Start is called before the first frame update
    void Start()
    {
       s.Print();
    }
    void Update()
    {
    
    
    }
    void OnCollisionEnter(Collision o)
    {
        Debug.Log(o.gameObject.GetComponent<Script_1>().health);
        o.gameObject.GetComponent<Script_1>().health=30f;
        o.gameObject.GetComponent<Script_1>().Print();

    }
     
    
}
