using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    Level level;
    GameStatus gameStatus;
    void Start()
    {
        level = FindObjectOfType<Level>();
        level.CountBreakableBlocks();
        gameStatus = FindObjectOfType<GameStatus>();
    }
    [SerializeField] AudioClip clip ;
   private void OnCollisionEnter2D(Collision2D other) 
   {
       gameStatus.AddToScore();
       AudioSource.PlayClipAtPoint(clip,Camera.main.transform.position);
       level.BlockDestroy();
       Destroy(this.gameObject);
   }
}
