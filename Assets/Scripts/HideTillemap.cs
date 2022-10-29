using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class HideTillemap : MonoBehaviour
{ private TilemapRenderer tilemapRenderer;

    // Start is called before the first frame update
    void Start()
    {
        tilemapRenderer = GetComponent<TilemapRenderer>();
        tilemapRenderer.enabled = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
