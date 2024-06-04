using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plyaerfollow : MonoBehaviour
{
    public GameObject player;
    private Vector3 oofset = new Vector3(-0.12f, 7.42f, -8.55f);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + oofset ;
    }
}
