using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
   [SerializeField] Paddle paddle;
   [SerializeField] float randomFactor;
   Vector2 paddleToBallVector;
    bool hasStarted ;
    AudioSource audioForTap;
    string paddleTag;
    Rigidbody2D rigidbody2D;
    void Start()
    {
        hasStarted = false;
        paddleToBallVector = transform.position - paddle.transform.position;
        audioForTap =  GetComponent<AudioSource>();
        rigidbody2D = GetComponent<Rigidbody2D>();
        paddleTag = paddle.gameObject.tag;
    }

    // Update is called once per frame
    void Update()
    {
        LaunchOnMouseClick();
        if (hasStarted == false)
        {
           LockTheBall();
        }
       
    }
    public void LaunchOnMouseClick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            hasStarted = true;
            rigidbody2D.velocity = new Vector2(2f,15f);
           
        }
    }
    private void OnCollisionEnter2D(Collision2D other) 
    {
        Vector2 tweaker = new Vector2(Random.Range(0f,randomFactor),Random.Range(0f,randomFactor));
        if (hasStarted)
        {
           if (other.collider.gameObject.tag==paddleTag)
           {
               audioForTap.Play();
           }
         rigidbody2D.velocity += tweaker   ;  
        }
      
    }
    private void LockTheBall()
    {
        Vector2 paddlePos = new Vector2(paddle.transform.position.x, paddle.transform.position.y);
        transform.position = paddlePos + paddleToBallVector;
    }
}
