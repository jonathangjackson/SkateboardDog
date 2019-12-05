using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Leash : MonoBehaviour
{

    public float fireRate = 0.25f;
    public float leashRange = 50f;
    public Transform leashEnd;
    public Camera leashCam;

    private WaitForSeconds leashDuration = new WaitForSeconds(0.7f);
    private LineRenderer leashLine;
    private float nextFire;

    public GameObject currentDog;
    public GameObject dogPosition;

    AudioClip rope;
    public AudioSource ropeSource;

    GameObject[] dogs = new GameObject[3];
    //private List<GameObject> dogs;

    // Start is called before the first frame update
    void Start()
    {
        leashLine = GetComponent<LineRenderer>();
        dogs[0] = currentDog;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && Time.time > nextFire)
        {
            ropeSource.Play();
            nextFire = Time.time + fireRate;

            StartCoroutine(leashEffect());

            Vector3 rayOrigin = leashCam.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 0));
            RaycastHit hit;

            leashLine.SetPosition(0, leashEnd.position);

            if (Physics.Raycast(rayOrigin, leashCam.transform.forward, out hit, leashRange))
            {
                leashLine.SetPosition(1, hit.point);

                if (hit.transform.gameObject.tag == "NewDog")
                {
                    Debug.Log("HIT");
                    dogs[0].SetActive(false);
                    dogs[1] = dogs[0];
                    hit.transform.GetComponent<Rigidbody>().constraints = new RigidbodyConstraints();
                    hit.transform.GetComponent<Dog>().setActive(true);
                    hit.transform.gameObject.GetComponent<ConstantForce>().force = new Vector3(0, 0, 0);
                    hit.transform.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
                    hit.transform.gameObject.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
                    hit.transform.gameObject.transform.position = dogPosition.transform.position;
                    hit.transform.position = new Vector3(hit.transform.position .x, - 1.16f, hit.transform.position.z);
                    hit.transform.gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
                    hit.transform.gameObject.transform.parent = dogPosition.transform;
                    GetComponent<SpringJoint>().connectedBody = dogPosition.GetComponent<Rigidbody>();
                    hit.transform.gameObject.tag = "Dog";
                    dogs[0] = hit.transform.gameObject;
                }
                
            }
            else
            {
                leashLine.SetPosition(1, rayOrigin + (leashCam.transform.forward * leashRange));
            }
        }
        
    }

    public GameObject getCurrentDog()
    {
        return dogs[0];
    }

    private IEnumerator leashEffect()
    {

        leashLine.enabled = true;
        yield return leashDuration;
        leashLine.enabled = false;
    }
}
