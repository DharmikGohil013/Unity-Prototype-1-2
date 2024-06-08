using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class topdown : MonoBehaviour
{
    private float topdown1 = 30.0f ;
    private float lowdown2 = -10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(transform.position.z > topdown1)
        {
            Destroy(gameObject);      
        }
        else if(transform.position.z < lowdown2)
        {
            Destroy(gameObject); 
        }
    }
}
