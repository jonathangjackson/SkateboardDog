using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delete : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.CompareTo("package") == 0)
        {
            this.GetComponent<Leash>().getCurrentDog().GetComponent<Dog>().packageHit(10.0f);
            Destroy(collision.gameObject);
        }
    }
}
