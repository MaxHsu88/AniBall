﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Up : MonoBehaviour
{
    float cnt = 0;
    float speed = 0.1f;
    float finalHeight = 50f;
    bool isLifting = false;
    FallFloor fallFloor;
    public Transform ringTransform;

    void Start()
    {
        Time.timeScale = 0;
        fallFloor = GetComponent<FallFloor> ();
        isLifting = true;
    }

    void Update()
    {
        if (isLifting)
        {
            ringTransform.Translate((new Vector3(0,speed,0)));
            cnt += speed;
            if (cnt >= finalHeight)
            {
                SettleGroundHeight();     // 設定每一個玩家Ball Respawn裡面的Ground Height參數
                fallFloor.EnableFalling();
                Time.timeScale = 1;
                isLifting = false;
            }
        }
    }

    void SettleGroundHeight()
    {
        BallRespawn[] ballRespawnList = FindObjectsOfType<BallRespawn> ();
        foreach(BallRespawn ballRespawn in ballRespawnList)
        {
            ballRespawn.SetGroundHeight(transform.position.y);
        }
    }
}