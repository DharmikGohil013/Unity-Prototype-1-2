using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PLAYERCONTROLAER : MonoBehaviour
{
    public float speed = 5.0f;
    public float turnspeed;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        transform.Translate(Vector3.right* Time.deltaTime * turnspeed);
      
    }
}
