﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balls : MonoBehaviour
{
    Rigidbody sphereRig;

    void Update()
    {
        sphereRig = GetComponent<Rigidbody>();
        sphereRig.AddForce(transform.forward * 50);
    }

}
