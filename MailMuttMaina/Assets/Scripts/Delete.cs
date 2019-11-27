using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delete : MonoBehaviour
{
    /*
    public Transform SpawnPoint;
    public GameObject prefab;
    */
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

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.CompareTo("Truck") == 0)
        {
            float distance = this.GetComponent<Transform>().position.x - (-10.77f);
            Debug.Log("YOU WON! Score: " + Mathf.Round(distance));
        }
        /*
        if (other.gameObject.tag.CompareTo("Spawn") == 0)
        {
            Debug.Log("SPAWN");
            GameObject newDog = Instantiate(prefab, SpawnPoint.position, SpawnPoint.rotation);

        }*/
    }
}
