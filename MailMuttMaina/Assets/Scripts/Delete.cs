using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Delete : MonoBehaviour
{
    
    public Transform SpawnPoint;
    public GameObject[] dogPrefabs;
    
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
            SceneManager.LoadScene("WinScreen");
        }
        
        if (other.gameObject.tag.CompareTo("SpawnDog") == 0)
        {
            Debug.Log("SPAWN");
            GameObject newDog = null;
            Transform spawn = other.gameObject.GetComponent<HoldSpawnPoint>().spawnPoint.transform;
            switch (Random.Range(0, 3))
            {
                case 0:
                    newDog = Instantiate(dogPrefabs[0], spawn.position, spawn.rotation);
                    break;
                case 1:
                    newDog = Instantiate(dogPrefabs[1], spawn.position, spawn.rotation);
                    break;
                case 2:
                    newDog = Instantiate(dogPrefabs[2], spawn.position, spawn.rotation);
                    break;
            }

        }
    }
}
