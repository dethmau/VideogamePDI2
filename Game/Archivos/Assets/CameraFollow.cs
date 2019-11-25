﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject follow;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float posx = follow.transform.position.x;
        float posy = follow.transform.position.y;

        transform.position = new Vector3(posx, posy, transform.position.z);

    }
}
