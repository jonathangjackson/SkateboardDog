using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dog : MonoBehaviour
{
    private Movement move;
    private GameObject obj;
    private float stamina;
    private float speed;
    private float aValue;

    public float startSpeed;
    public float staminaRate;
    public string name;
    public bool isActive;
    public GameObject player;
    public float maxSpeed;
    public float acceleration;
    public GameObject slider;
    public GameObject text;

    // Start is called before the first frame update
    void Start()
    {
        aValue = 0;
        speed = startSpeed;
        //isActive = false;
        obj = this.GetComponent<GameObject>();
        stamina = 100;
        move = player.GetComponent<Movement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isActive)
        {
            
            setSpeed();
        }
    }

    public void packageHit(float decrease)
    {
        stamina -= decrease;
    }

    public void setActive(bool a)
    {
        if (a)
            text.GetComponent<Text>().text = name;
        isActive = a;
    }

    //Sets the speed of the player when the player is connected to this dog
    public void setSpeed()
    {
        if (aValue < 1.0f)
        {
            aValue += acceleration * Time.deltaTime;//acceleration * Time.deltaTime
            speed = Mathf.Lerp(startSpeed, maxSpeed, aValue);
            move.setSpeed(Mathf.Lerp(move.getSpeed(), speed, aValue));
        }
        if(stamina < 0)
        {
            move.setSpeed(Mathf.Lerp(move.getSpeed(), 0, 0.2f * Time.deltaTime));
        }
        else
        {
            stamina -= staminaRate * Time.deltaTime;
            slider.GetComponent<Slider>().value = stamina / 100.0f;
        }
    }
}
