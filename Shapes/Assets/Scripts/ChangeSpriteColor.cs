using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSpriteColor : MonoBehaviour {

    private SpriteRenderer spriteRenderer;
    private Color32 newColor;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void Color(Color32 newColor)
    {
        spriteRenderer.color = newColor; //RGBA color
    }
}
