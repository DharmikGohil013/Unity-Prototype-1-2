using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PLAYERCONTROLAER : MonoBehaviour
{
    public float speed = 0.0f;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            speed=speed + Time.deltaTime;

        }
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
