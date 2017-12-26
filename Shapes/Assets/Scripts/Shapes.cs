using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shapes : MonoBehaviour {

    public List<GameObject> shapesList = new List<GameObject>();

    private float size;
    private string direction;

    private float speedX;
    private float speedY;

    private Vector3 moveVector;
    
    private void Start()
    {
        size = 4f;
        speedX = 0.05f;
        speedY = 0.05f;
        moveVector = new Vector3(speedX, speedY, 0);

        CreateShapes();
    }

    private void Update()
    {
        MoveShapes();
    }

    private void CreateShapes()
    {
        if (shapesList != null)
        {
            for (int i = 0; i < shapesList.Count; i++)
            {
                shapesList[i] = Instantiate(shapesList[i], new Vector3(0f, 0f, 0f), Quaternion.identity);
            }
        }
    }

    private void MoveShapes()
    {
        if (shapesList != null)
        {
            for (int i = 0; i < shapesList.Count; i++)
            {
                shapesList[i].transform.position += moveVector;
            }
        }
    }
}
