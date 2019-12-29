﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public MusicController musicController;
    public bool isSoccerGame = false;

    /* 任何碰到Respawn Area的物品都會觸發 */
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            col.gameObject.GetComponent<BallRespawn>().RespawnPlayer();   
            if (isSoccerGame)
                musicController.PlayWaterDrop();
        }
        if (col.gameObject.tag == "Barrel")
        {
            col.gameObject.GetComponent<Barrel>().resetBarrel("center", 2.0f, false);
            if (isSoccerGame)
                musicController.PlayWaterDrop();
        }
        if (col.gameObject.tag == "Floor")
        {
            Destroy(col.gameObject);
        }
    }
}
