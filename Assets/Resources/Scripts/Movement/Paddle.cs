using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Paddle : MonoBehaviour
{
    [SerializeField] float screenWidthInUnits=16f;
    [SerializeField] float minX;
    [SerializeField] float maxX;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       float mousePositionX = (Input.mousePosition.x / Screen.width)* screenWidthInUnits;
       Vector2 paddlePos = new Vector2(transform.position.x,transform.position.y);
       paddlePos.x = Mathf.Clamp(mousePositionX,minX,maxX);
       transform.position = paddlePos;
    }
}
