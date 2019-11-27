using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{
    private int sourcePos;
    public float speed;
    public Transform[] waypoints;
    public GameObject speedText;
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
        speedText.GetComponent<Text>().text = "Speed: " + Mathf.Round(speed);
    }

    public float getSpeed()
    {
        return this.speed;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.right * Time.deltaTime * speed;
        
        
        /*Rotation
        float dis = Vector3.Distance(transform.position, waypoints[count].position);
        float step = speed * Time.deltaTime;
        
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

