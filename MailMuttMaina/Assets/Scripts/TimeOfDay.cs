using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeOfDay : MonoBehaviour
{
    public GameObject skyBox;
    public GameObject moon;
    public GameObject sun;
    public bool lampPostLight;
    private Renderer rend;
    private float scaleX;
    // Start is called before the first frame update
    void Start()
    {
        Screen.SetResolution(2560, 1440, true);

        scaleX = 1;
        rend = skyBox.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        scaleX += Time.deltaTime * 0.02f;
        rend.material.mainTextureScale = new Vector2(scaleX, 1);
        sun.transform.Rotate(Vector3.down * (4f * Time.deltaTime));
        if (scaleX % 2 > 1)
        {
            if (moon.GetComponent<Light>().intensity < 0.41f)
            {
                moon.GetComponent<Light>().intensity += Time.deltaTime * 0.01f;
            }
            if (sun.GetComponent<Light>().intensity > 0)
            {
                sun.GetComponent<Light>().intensity += Time.deltaTime * 0.01f;
            }
            lampPostLight = true;
        }
        else
        {
            if (moon.GetComponent<Light>().intensity > 0)
            {
                moon.GetComponent<Light>().intensity -= Time.deltaTime * 0.01f;
            }
            if (sun.GetComponent<Light>().intensity < 1)
            {
                sun.GetComponent<Light>().intensity += Time.deltaTime * 0.01f;
            }
            lampPostLight = false;
        }
        if(scaleX % 2 > 1.4f || scaleX %2 < 0.2f)
        {
            lampPostLight = true;
        }
        else
        {
            lampPostLight = false;
        }
        //if(rotation of direction light > x) set sun to 0 and turn on moon 
        //else set moon to off and sun to on 
        //if(timeOfDay > 7 o'clock) turn on lamp post 

    }
}
