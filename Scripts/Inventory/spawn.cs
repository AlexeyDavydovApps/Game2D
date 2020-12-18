﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject item;
    private Transform player;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    public void SpawnDroppedItem()
    {
        Vector2 playerpos = new Vector2(player.position.x + 4,player.position.y - 1);
        Instantiate(item, playerpos, Quaternion.identity);
    }
}
