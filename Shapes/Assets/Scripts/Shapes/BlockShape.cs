using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockShape : MonoBehaviour {
    private Shapes shapes;

    [HideInInspector]
    public GameObject block;


    private void Awake()
    {
        shapes = GetComponent<Shapes>();
    }


    public void CreateBlock(GameObject Object)
    {
        block = Instantiate(Object, new Vector3(0f, 0f, 0f), Quaternion.identity);
    }

    private void Update()
    {
        shapes.Moving(block, shapes.speedX, shapes.speedY);
    }
}
