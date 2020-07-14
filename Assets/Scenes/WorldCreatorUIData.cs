using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.UI;

public class WorldCreatorUIData : MonoBehaviour
{
    public int WorldSize { get; set; }
    public int UnitType { get; set; }
    public int TileSize { get; set; }

    public InputField InputWorldSize;


    void Awake()
    {
        Assert.IsNotNull(InputWorldSize, "Input World Size object is not linked to Main.");
    }
    // Start is called before the first frame update
    void Start()
    {
        WorldSize = 10;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void WorldSizeStringToInt (string worldSize)
    {
        int value;
        if (Int32.TryParse(worldSize, out value))
        {
            if (value >= 10 && WorldSize <= 9999)
            {
                WorldSize = value;
            }
            else if (value < 10)
            {
                WorldSize = 10;
                InputWorldSize.text = "10";
            }
            else
            {
                WorldSize = 9999;
                InputWorldSize.text = "9999";
            }
        }
        else
        {
            WorldSize = 10;
            InputWorldSize.text = "10";
        }
    }
}
