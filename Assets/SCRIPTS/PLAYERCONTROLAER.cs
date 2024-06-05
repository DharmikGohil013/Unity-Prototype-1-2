using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PLAYERCONTROLAER : MonoBehaviour
{
    //all speed and trun speed varibal

    private float speed = 15.0f;
    private float turnspeed=25.0f;
    private float horzontolinput;
    private float verttolinput;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //alll horijotol and vetical axis
        horzontolinput = Input.GetAxis("Horizontal");
        verttolinput = Input.GetAxis("Vertical");
        //add transer
        transform.Translate(Vector3.forward * speed * Time.deltaTime * verttolinput);
        transform.Rotate(Vector3.up, Time.deltaTime * turnspeed * horzontolinput);
      
    }
}
