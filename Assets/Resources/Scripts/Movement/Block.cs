using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    Level level;
   
    void Start()
    {
        level = FindObjectOfType<Level>();
        level.CountBreakableBlocks();
    }
    [SerializeField] AudioClip clip ;
   private void OnCollisionEnter2D(Collision2D other) 
   {
       AudioSource.PlayClipAtPoint(clip,Camera.main.transform.position);
       level.BlockDestroy();
       Destroy(this.gameObject);
   }
}
