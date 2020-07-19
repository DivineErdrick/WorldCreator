using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class WorldCreatorTiles : MonoBehaviour
{
    public GameObject tile;

    void Awake ()
    {
        Assert.IsNotNull(tile, "No tile object has been assigned to the Tiles script.");
    }

    // Start is called before the first frame update
    void Start()
    {
        ChangeTileSize();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeTileSize ()
    {
        WorldCreatorUIData data = GetComponent<WorldCreatorUIData>();

        Sprite[] sprites = Resources.LoadAll<Sprite>("Tiles");

        tile.GetComponent<SpriteRenderer>().sprite = sprites[data.TileSize];
    }
}
