using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shapes : MonoBehaviour {
    private BlockShape blockShape;
    private CircleShape circleShape;
    private TriangleShape triangleShape;

    public GameObject ShapeObject;

    private float size;
    //direction 

    [HideInInspector]
    public float speedX;

    [HideInInspector]
    public float speedY;

    private Vector3 moveVector;
    
    public bool created;

    private void Start()
    {
        blockShape = GetComponent<BlockShape>();
        circleShape = GetComponent<CircleShape>();
        triangleShape = GetComponent<TriangleShape>();

        size = 4f;
        speedX = 0.25f;
        speedY = 0.25f;
    }

    private void Update()
    {
  
    }

    public void CreateShape(string Type) {
        
        switch (Type)
        {
            case "block":
                blockShape.CreateBlock(ShapeObject);

                break;
            case "triangle":

                break;
            case "circle":

                break;
        }
        
    }

    public void Moving(GameObject Object, float x, float y)
    {
        moveVector = new Vector3(x, y, 0);
        Object.transform.position += moveVector;
    }
}
