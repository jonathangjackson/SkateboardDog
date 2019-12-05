using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowObjects : MonoBehaviour
{
    public GameObject[] packages;
    private float lastTime;
    GameObject clone;
    private float randWait = 0;
    AudioClip package;
    public AudioSource packageSource;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 300;
        randWait = Random.Range(0, 2);
        lastTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - lastTime > randWait)
        {
            if (Random.Range(0, 200) % 99 == 0)
            {
                randWait = Random.Range(0, 2);
                lastTime = Time.time;
                GameObject clone = null;
                int packageSpawned = Random.Range(0, packages.Length);
                clone = Instantiate(packages[packageSpawned], new Vector3(GetComponent<Transform>().position.x, GetComponent<Transform>().position.y, GetComponent<Transform>().position.z), Quaternion.identity);
                packageSource.Play();
                clone.GetComponent<Rigidbody>().AddForce(Random.Range(100, 500), Random.Range(0, 20), Random.Range(-400, 400));
                Destroy(clone, 10.0f);

            }
        }
    }
}