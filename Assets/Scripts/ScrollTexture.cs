using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Kyle Knotek

public class ScrollTexture : MonoBehaviour
{
    public float ScrollX = 0.5f;
    public float OffsetY = 0.5f;

    // Update is called once per frame
    void Update()
    {
        float OffsetX = Time.time * ScrollX;

        GetComponent<Renderer>().material.mainTextureOffset = new Vector2(OffsetX, OffsetY);
    }
}
