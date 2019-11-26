using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private float x;
    // Start is called before the first frame update
    void Start()
    {
        x = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("d") && x < 20)
        {
            this.GetComponent<Transform>().position = new Vector3(this.transform.position.x + (10 * Time.deltaTime), this.transform.position.y, this.transform.position.z);
            x++;
        }
        if (Input.GetKey("a") && x > -20)
        {
            x--;
            this.GetComponent<Transform>().position = new Vector3(this.transform.position.x - (10 * Time.deltaTime), this.transform.position.y, this.transform.position.z);
        }
    }
}
