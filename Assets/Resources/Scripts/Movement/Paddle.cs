using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] float screenWidthInUnits=16f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       float mousePositionX = (Input.mousePosition.x / Screen.width)* screenWidthInUnits;
       Vector2 paddlePos = new Vector2(mousePositionX,1f);
       transform.position = paddlePos;
    }
}
