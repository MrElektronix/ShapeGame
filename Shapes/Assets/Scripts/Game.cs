using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour {
    private Shapes shapes;


    private void Start()
    {
        shapes = GetComponent<Shapes>();
        shapes.CreateShape("block");
    }


}
