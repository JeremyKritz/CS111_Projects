﻿using UnityEngine;
using System.Collections;

public class KEtest : MonoBehaviour
{
    public float reset = 0;

    // Use this for initialization
    void Start()
    {
        //start = GameObject.transform.position;
    }

    // Update is called once per frame

    void Update()
    {
        GameObject sphObj;

        sphObj = GameObject.Find("Planet");
        Rigidbody sph = sphObj.GetComponent<Rigidbody>();

        GameObject KEsph = GameObject.Find("KEball"); // this needs to be name of thingy
        

        Vector3 vel3 = sph.velocity;
        float mass = sph.mass;
        //Debug.Log(mass);
        double vx = vel3.x;
        
        double vy = vel3.y;

        double vz = vel3.z;
        double vel = System.Math.Sqrt(System.Math.Pow(vx, 2) + System.Math.Pow(vy, 2) + System.Math.Pow(vz, 2));
        double velsq = System.Math.Pow(vel, 2);
        float velsqf = (float)velsq;
        //Debug.Log(velsqf);
        float KEf = (float).5 * mass * velsqf;

        reset = reset + (float).05;
        Vector3 oldPos = KEsph.transform.position;
        if (reset >= 20)
        {
            reset = 0;
            oldPos.x = oldPos.x - 20;
        }



        
        transform.position = new Vector3(oldPos.x + (float).05, KEf * (float).1, oldPos.z );


    }
}
