using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeashView : MonoBehaviour
{

    public float leashRange = 50f;

    private Camera leashCam;

    // Start is called before the first frame update
    void Start()
    {
        leashCam = GetComponentInParent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 lineOrigin = leashCam.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 0));
        Debug.DrawRay(lineOrigin, leashCam.transform.forward * leashRange, Color.red);
    }
}
