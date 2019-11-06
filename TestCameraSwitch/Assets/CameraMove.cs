using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraMove : MonoBehaviour
{
    public GameObject staminaSlider;
    public Transform[] points;
    private int dest;
    private float angle;
    public float speed;
    public float jump;
    public GameObject currentDog;
    private string curDogName;
    public GameObject Doberman;
    public GameObject Greyhound;
    private Vector3 offScreen;
    private float[] staminas;
    private float staminaRate;

    // Start is called before the first frame update
    void Start()
    {
        staminas = new float[2];
        staminas[0] = 100;
        staminas[1] = 100;
        staminaRate = 1.0f;
        dest = 0;
        offScreen = new Vector3(0, 0, -510);
        curDogName = "Doberman";
        Doberman.GetComponent<Transform>().position = currentDog.GetComponent<Transform>().position;
        Doberman.GetComponent<Transform>().SetParent(currentDog.GetComponent<Transform>());
        nextWayPoint();
    }

    // Update is called once per frame
    void Update()
    {
        //this.transform.position.Set(this.transform.position.x, this.transform.position.y, this.transform.position.z + (speed * Time.deltaTime));
        this.GetComponent<Transform>().position = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z + (speed * Time.deltaTime));
        //this.GetComponent<Transform>().rotation = new Quaternion(this.GetComponent<Transform>().rotation.x, this.GetComponent<Transform>().rotation.y + ((Time.deltaTime * angle) * 0.1f), this.GetComponent<Transform>().rotation.z, this.GetComponent<Transform>().rotation.w);

        if (Input.GetKey("d") && (this.name.CompareTo("Player") == 0))
        {
            this.GetComponent<Transform>().position = new Vector3(this.transform.position.x + (speed * Time.deltaTime), this.transform.position.y, this.transform.position.z);
            currentDog.GetComponent<Transform>().position = new Vector3(currentDog.GetComponent<Transform>().position.x - ((speed / 2) * Time.deltaTime), currentDog.GetComponent<Transform>().position.y, currentDog.GetComponent<Transform>().position.z);
        }
        if (Input.GetKey("a") && (this.name.CompareTo("Player") == 0))
        {
            this.GetComponent<Transform>().position = new Vector3(this.transform.position.x - (speed * Time.deltaTime), this.transform.position.y, this.transform.position.z);
            currentDog.GetComponent<Transform>().position = new Vector3(currentDog.GetComponent<Transform>().position.x + ((speed / 2) * Time.deltaTime), currentDog.GetComponent<Transform>().position.y, currentDog.GetComponent<Transform>().position.z);
        }
        if (Input.GetKey("space") && (this.name.CompareTo("Player") == 0))
        {
            //this.GetComponent<Transform>().position = new Vector3(this.transform.position.x - (speed * Time.deltaTime), this.transform.position.y, this.transform.position.z);
        }
        if ((this.name.CompareTo("Player") == 0))
        {
            switch (curDogName)
            {
                case "Doberman":
                    staminas[0] -= staminaRate * Time.deltaTime;
                    staminaSlider.GetComponent<Slider>().value = staminas[0] / 100.0f;
                    break;
                case "Greyhound":
                    staminas[1] -= staminaRate * Time.deltaTime;
                    staminaSlider.GetComponent<Slider>().value = staminas[1] / 100.0f;
                    break;
            }
        }
    }

    public bool checkWayPoint()
    {
        return false;
    }

    public void nextWayPoint()
    {
        float opp = points[dest].position.x - this.GetComponent<Transform>().position.x;
        float adj = points[dest].position.z - this.GetComponent<Transform>().position.z;
        angle = Mathf.Tan(opp / adj);
        dest++;
    }

    public void changeStaminaBar()
    {
        switch (curDogName)
        {
            case "Doberman":
                staminaSlider.GetComponent<Slider>().value = staminas[0]/100.0f;
                break;
            case "Greyhound":
                staminaSlider.GetComponent<Slider>().value = staminas[1]/100.0f;
                break;
        }
    }

    public void ChangeDog(string dogName)
    {
        switch (curDogName)
        {
            case "Doberman":
                Doberman.GetComponent<Transform>().parent = null;
                Doberman.GetComponent<Transform>().position = offScreen;
                break;
            case "Greyhound":
                Greyhound.GetComponent<Transform>().parent = null;
                Greyhound.GetComponent<Transform>().position = offScreen;
                break;
        }

        curDogName = "NULL";
        switch (dogName)
        {
            case "Doberman":
                curDogName = "Doberman";
                this.speed = 40;
                this.jump = 10;
                staminaRate = 0.5f;
                Doberman.GetComponent<Transform>().position = currentDog.GetComponent<Transform>().position;
                Doberman.GetComponent<Transform>().SetParent(currentDog.GetComponent<Transform>());
                break;
            case "Greyhound":
                curDogName = "Greyhound";
                this.speed = 80;
                this.jump = 2;
                staminaRate = 1.5f;
                Greyhound.GetComponent<Transform>().position = currentDog.GetComponent<Transform>().position;
                Greyhound.GetComponent<Transform>().SetParent(currentDog.GetComponent<Transform>());
                break;
        }

    }
}
