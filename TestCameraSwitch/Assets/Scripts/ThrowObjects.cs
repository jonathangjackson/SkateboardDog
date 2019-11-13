using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowObjects : MonoBehaviour
{
    public GameObject package;
    public GameObject package2;
    public GameObject package3;
    public GameObject package4;
    public GameObject package5;
    public GameObject package6;
    public GameObject package7;
    public GameObject package8;
    public GameObject package9;
    public GameObject package10;

    GameObject clone;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Random.Range(0, 200) % 199 == 0)
        {
            GameObject clone = null;
            //clone.GetComponent<Rigidbody>().AddForce(Random.Range(-500, 500), 0, Random.Range(-1000, -100));
            //Destroy(clone, 10.0f);

            int packageSpawned = Random.Range(0, 10);
            Debug.Log("Pack Spawn: " + packageSpawned);

            switch (packageSpawned)
            {
                case 0:
                    clone = Instantiate(package, new Vector3(GetComponent<Transform>().position.x, GetComponent<Transform>().position.y, GetComponent<Transform>().position.z), Quaternion.identity);
                    clone.GetComponent<Rigidbody>().AddForce(Random.Range(-500, 500), 0, Random.Range(-1000, -100));
                    Destroy(clone, 10.0f);
                    break;
                case 1:
                    clone = Instantiate(package2, new Vector3(GetComponent<Transform>().position.x, GetComponent<Transform>().position.y, GetComponent<Transform>().position.z), Quaternion.identity);
                    clone.GetComponent<Rigidbody>().AddForce(Random.Range(-500, 500), 0, Random.Range(-1000, -100));
                    Destroy(clone, 10.0f);
                    break;
                case 2:
                    clone = Instantiate(package3, new Vector3(GetComponent<Transform>().position.x, GetComponent<Transform>().position.y, GetComponent<Transform>().position.z), Quaternion.identity);
                    clone.GetComponent<Rigidbody>().AddForce(Random.Range(-500, 500), 0, Random.Range(-1000, -100));
                    Destroy(clone, 10.0f);
                    break;
                case 3:
                    clone = Instantiate(package4, new Vector3(GetComponent<Transform>().position.x, GetComponent<Transform>().position.y, GetComponent<Transform>().position.z), Quaternion.identity);
                    clone.GetComponent<Rigidbody>().AddForce(Random.Range(-500, 500), 0, Random.Range(-1000, -100));
                    Destroy(clone, 10.0f);
                    break;
                case 4:
                    clone = Instantiate(package5, new Vector3(GetComponent<Transform>().position.x, GetComponent<Transform>().position.y, GetComponent<Transform>().position.z), Quaternion.identity);
                    clone.GetComponent<Rigidbody>().AddForce(Random.Range(-500, 500), 0, Random.Range(-1000, -100));
                    Destroy(clone, 10.0f);
                    break;
                case 5:
                    clone = Instantiate(package6, new Vector3(GetComponent<Transform>().position.x, GetComponent<Transform>().position.y, GetComponent<Transform>().position.z), Quaternion.identity);
                    clone.GetComponent<Rigidbody>().AddForce(Random.Range(-500, 500), 0, Random.Range(-1000, -100));
                    Destroy(clone, 10.0f);
                    break;
                case 6:
                    clone = Instantiate(package7, new Vector3(GetComponent<Transform>().position.x, GetComponent<Transform>().position.y, GetComponent<Transform>().position.z), Quaternion.identity);
                    clone.GetComponent<Rigidbody>().AddForce(Random.Range(-500, 500), 0, Random.Range(-1000, -100));
                    Destroy(clone, 10.0f);
                    break;
                case 7:
                    clone = Instantiate(package8, new Vector3(GetComponent<Transform>().position.x, GetComponent<Transform>().position.y, GetComponent<Transform>().position.z), Quaternion.identity);
                    clone.GetComponent<Rigidbody>().AddForce(Random.Range(-500, 500), 0, Random.Range(-1000, -100));
                    Destroy(clone, 10.0f);
                    break;
                case 8:
                    clone = Instantiate(package9, new Vector3(GetComponent<Transform>().position.x, GetComponent<Transform>().position.y, GetComponent<Transform>().position.z), Quaternion.identity);
                    clone.GetComponent<Rigidbody>().AddForce(Random.Range(-500, 500), 0, Random.Range(-1000, -100));
                    Destroy(clone, 10.0f);
                    break;
                case 9:
                    clone = Instantiate(package10, new Vector3(GetComponent<Transform>().position.x, GetComponent<Transform>().position.y, GetComponent<Transform>().position.z), Quaternion.identity);
                    clone.GetComponent<Rigidbody>().AddForce(Random.Range(-500, 500), 0, Random.Range(-1000, -100));
                    Destroy(clone, 10.0f);
                    break;
            }

            Destroy(clone, 10.0f);

        }
    }
}
