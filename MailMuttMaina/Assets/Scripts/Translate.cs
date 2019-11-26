using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Translate : MonoBehaviour
{

    private float z;
    // Start is called before the first frame update
    void Start()
    {
        z = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("d") && z < 20)
        {
            transform.position += transform.forward * Time.deltaTime * -10;
            //this.GetComponent<Transform>().position = new Vector3(this.transform.position.x , this.transform.position.y, this.transform.position.z - (10 * Time.deltaTime));
            z++;
        }
        if (Input.GetKey("a") && z > -20)
        {
            z--;

            transform.position += transform.forward * Time.deltaTime * 10;
            //this.GetComponent<Transform>().position = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z + (10 * Time.deltaTime));
        }
    }
}
