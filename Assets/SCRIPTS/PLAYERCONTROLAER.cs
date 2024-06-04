using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PLAYERCONTROLAER : MonoBehaviour
{
    public int a=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            a=a+1;  
        }
        else if(Input.GetKeyDown(KeyCode.S)) { a=a-1; }
        transform.Translate(Vector3.forward *Time.deltaTime*a);
    }
}
