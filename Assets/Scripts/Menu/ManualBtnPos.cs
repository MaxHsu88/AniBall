﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManualBtnPos : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(Screen.width/2f, Screen.height/1.8f - 2*Screen.width/15f, 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}