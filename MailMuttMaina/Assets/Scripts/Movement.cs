using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
    private int sourcePos;
    public float speed;
    public Transform[] waypoints;
    public GameObject speedText;
    private Quaternion endPoint;
    private int count;
    private float distanceError = 10.0f;
    AudioClip gameMusic;
    public AudioSource musicSource;

    AudioClip skate;
    public AudioSource skateSource;

    // Start is called before the first frame update
    void Start()
    {
        //Screen.SetResolution(2560, 1440, true);

        count = 0;
        //endPoint = waypoints[0].rotation;
        musicSource.Play();
        musicSource.loop = true;
        skateSource.Play();
        skateSource.loop = true;
    }

    public void setSpeed(float s)
    {
        this.speed = s;
        speedText.GetComponent<Text>().text = "Speed: " + Mathf.Round(speed);

        if (Mathf.Round(this.speed) <= 0)
        {
            Debug.Log("GAME OVER");
            SceneManager.LoadScene("LoseScreen");
        }
           
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

