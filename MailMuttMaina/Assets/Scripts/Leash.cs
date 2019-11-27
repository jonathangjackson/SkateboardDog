using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Leash : MonoBehaviour
{

    public float fireRate = 0.25f;
    public float leashRange = 50f;
    public Transform leashEnd;
    public GameObject dog;
    public Camera leashCam;

    private WaitForSeconds leashDuration = new WaitForSeconds(0.7f);
    private LineRenderer leashLine;
    private float nextFire;

    public GameObject currentDog;

    // Start is called before the first frame update
    void Start()
    {
        leashLine = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && Time.time > nextFire)
        {
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
                    hit.transform.gameObject.transform.position = currentDog.transform.position;
                    hit.transform.gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
                    hit.transform.gameObject.transform.parent = currentDog.transform;
                    GetComponent<SpringJoint>().connectedBody = currentDog.GetComponent<Rigidbody>();
                    hit.transform.gameObject.tag = "Dog";
                }
                
            }
            else
            {
                leashLine.SetPosition(1, rayOrigin + (leashCam.transform.forward * leashRange));
            }
        }
        
    }

    private IEnumerator leashEffect()
    {

        leashLine.enabled = true;
        yield return leashDuration;
        leashLine.enabled = false;
    }
}
