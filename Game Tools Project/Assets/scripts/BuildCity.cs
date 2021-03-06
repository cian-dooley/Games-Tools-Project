﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildCity : MonoBehaviour
{
    public GameObject[] buildings;
    public int mapWidth = 20;
    public int mapHeight = 20;

    // Start is called before the first frame update
    void Start()
    {
        for (int h = 0; h < mapHeight; h++)
        {
            for (int w = 0; h < mapWidth; w++)
            {
                Vector3 pos = new Vector3(w, 0, h);
                int n = Random.Range(0, buildings.Length);
                Instantiate(buildings[n], pos, Quaternion.identity);
            }
        }
    }

}