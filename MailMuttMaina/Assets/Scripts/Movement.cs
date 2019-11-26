using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class Movement : MonoBehaviour
{
    private int sourcePos;
    public float speed;
    public Transform[] waypoints;
    private Quaternion endPoint;
    private int count;
    private float distanceError = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        //endPoint = waypoints[0].rotation;
    }

    public void setSpeed(float s)
    {
        this.speed = s;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.right * Time.deltaTime * speed;
        //float dis = Vector3.Distance(transform.position, waypoints[count].position);
        float step = speed * Time.deltaTime;
        /*
        if(dis < distanceError)
        {
            Debug.Log("IN");
            count++;
            if (count < waypoints.Length)
                endPoint = waypoints[count].rotation;
            else
                Debug.Log("End of Waypoints");
        }*/
        //transform.rotation = Quaternion.Slerp(transform.rotation, endPoint, 0.5f * Time.deltaTime);
    }
}

