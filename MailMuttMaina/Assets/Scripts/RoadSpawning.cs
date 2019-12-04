using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadSpawning : MonoBehaviour
{

    public GameObject roadA;
    public GameObject roadB;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.tag == "SpawnRoad"){

            Destroy(roadA);
            roadA = roadB;
            Vector3 roadPos = roadA.GetComponent<Transform>().position;
            roadB = Instantiate(roadB, new Vector3(roadPos.x + 1400, roadPos.y, roadPos.z), Quaternion.identity);
        }
    }
}
