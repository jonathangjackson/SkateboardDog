using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowObjects : MonoBehaviour
{
    public GameObject package;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Random.Range(0, 200) % 199 == 0)
        {
            GameObject clone = Instantiate(package, new Vector3(this.GetComponent<Transform>().position.x, this.GetComponent<Transform>().position.y, this.GetComponent<Transform>().position.z), Quaternion.identity);
            clone.GetComponent<Rigidbody>().AddForce(Random.Range(-500, 500), 0, Random.Range(-1000, -100));
            Destroy(clone, 10.0f);
        }
    }
}
