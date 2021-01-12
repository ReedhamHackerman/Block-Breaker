using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Paddle : MonoBehaviour
{
    [SerializeField] float screenWidthInUnits=16f;
    [SerializeField] float minX;
    [SerializeField] float maxX;
    GameStatus status;
    void Start()
    {
        status = FindObjectOfType<GameStatus>();
    }

    // Update is called once per frame
    void Update()
    {
       
       Vector2 paddlePos = new Vector2(transform.position.x,transform.position.y);
       paddlePos.x = Mathf.Clamp(GetXpos(),minX,maxX);
       transform.position = paddlePos;
    }
    private float GetXpos()
    {
            if (status.isAutoPlayEnabled())
            {
                return FindObjectOfType<Ball>().transform.position.x;
            }
            else
            {
               return (Input.mousePosition.x / Screen.width)* screenWidthInUnits;
            }
    }
}
