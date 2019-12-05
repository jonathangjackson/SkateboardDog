﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampPost : MonoBehaviour
{
    public TimeOfDay getLamp;
    // Start is called before the first frame update
    void Start()
    {
        Screen.SetResolution(2560, 1440, true);

    }

    // Update is called once per frame
    void Update()
    {
        if (getLamp.lampPostLight)
        {
            this.GetComponent<Light>().intensity = 21.02f;
        }
        else
        {
            this.GetComponent<Light>().intensity = 0.0f;
        }
    }
}
