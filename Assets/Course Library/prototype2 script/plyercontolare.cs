using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plyercontolare : MonoBehaviour
{
    public float hori;
    private float speed=20.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < -13.82f)
        {
            transform.position = new Vector3(-13.82f, transform.position.y,transform.position.z);
        }
        else if(transform.position.x>10.0f)
        {
            transform.position = new Vector3(10.0f, transform.position.y, transform.position.z);
        }
        hori = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime*hori*speed);
    }
}
