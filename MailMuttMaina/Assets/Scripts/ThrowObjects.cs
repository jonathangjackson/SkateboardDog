using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowObjects : MonoBehaviour
{
    public GameObject[] packages;

    GameObject clone;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        if (Random.Range(0, 100) % 99 == 0)
        {
            GameObject clone = null;
            int packageSpawned = Random.Range(0, packages.Length);
            clone = Instantiate(packages[packageSpawned], new Vector3(GetComponent<Transform>().position.x, GetComponent<Transform>().position.y, GetComponent<Transform>().position.z), Quaternion.identity);
            clone.GetComponent<Rigidbody>().AddForce(Random.Range(-200, 200), Random.Range(0, 20), Random.Range(-200, 200));
            Destroy(clone, 10.0f);

        }
    }
}