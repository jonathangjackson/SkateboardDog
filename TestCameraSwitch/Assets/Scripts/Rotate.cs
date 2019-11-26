using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("d"))
        {
            this.GetComponent<Transform>().rotation = new Quaternion(this.GetComponent<Transform>().rotation.x, this.GetComponent<Transform>().rotation.y - (1 * Time.deltaTime), this.GetComponent<Transform>().rotation.z, this.GetComponent<Transform>().rotation.w);
        }
        if (Input.GetKey("a"))
        {
            this.GetComponent<Transform>().rotation = new Quaternion(this.GetComponent<Transform>().rotation.x, this.GetComponent<Transform>().rotation.y + (1 * Time.deltaTime), this.GetComponent<Transform>().rotation.z, this.GetComponent<Transform>().rotation.w);
        }
    }
}
