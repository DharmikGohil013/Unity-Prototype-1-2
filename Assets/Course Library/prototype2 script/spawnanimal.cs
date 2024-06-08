using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnanimal : MonoBehaviour
{
    public GameObject[] spawn;
  
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnrendomanimal",2,1.5f);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    void spawnrendomanimal()
    {
        int animalindex = Random.Range(0, spawn.Length);
        Vector3 spawn2 = new Vector3(Random.Range(-14, 11), 0, 20);
        Instantiate(spawn[animalindex], spawn2, spawn[animalindex].transform.rotation);
    }
}
