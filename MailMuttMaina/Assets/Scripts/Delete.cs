using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Delete : MonoBehaviour
{
    
    public Transform SpawnPoint;
    public GameObject[] dogPrefabs;

    AudioClip chi;
    public AudioSource chiSource;

    AudioClip dob;
    public AudioSource dobSource;

    AudioClip grey;
    public AudioSource greySource;

    // Start is called before the first frame update
    void Start()
    {
        Screen.SetResolution(2560, 1440, true);

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
            PlayerPrefs.SetString("Score", distance.ToString());
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
                    chiSource.Play();
                    newDog = Instantiate(dogPrefabs[0], spawn.position, spawn.rotation);
                    break;
                case 1:
                    dobSource.Play();
                    newDog = Instantiate(dogPrefabs[1], spawn.position, spawn.rotation);
                    break;
                case 2:
                    greySource.Play();
                    newDog = Instantiate(dogPrefabs[2], spawn.position, spawn.rotation);
                    break;
            }

        }
    }
}
