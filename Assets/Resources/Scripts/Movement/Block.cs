using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    Level level;
    GameStatus gameStatus;
    [SerializeField] GameObject blockSparklesVFX;
    
    int timesHit;
    
    [SerializeField] Sprite[] sprites;
    void Start()
    {
        CountBlocks();
        timesHit =0;
        gameStatus = FindObjectOfType<GameStatus>();
    }

    private void CountBlocks()
    {
        level = FindObjectOfType<Level>();
        if (tag=="BreakableBlocks")
        {
             level.CountBreakableBlocks();
        }
       
    }

    [SerializeField] AudioClip clip ;
   private void OnCollisionEnter2D(Collision2D other)
    {
        if (tag=="BreakableBlocks")
        {
            timesHit++;
            int maxHit = sprites.Length+1;
            if (maxHit<=timesHit)
            {
                 DestroyBlock();
            }
            else
            {
                ShowHitSprite();
            }
           
        }
       

    }
    public void ShowHitSprite()
    {
        int spriteIndex = timesHit-1;
        if (sprites[spriteIndex]!= null)
        {
             GetComponent<SpriteRenderer>().sprite = sprites[spriteIndex];
        }
        else
        {
            Debug.LogError("Particular Sprite Missing " + gameObject.name);
        }
       

    }
    private void DestroyBlock()
    {
        BlockDestroySFX();
        level.BlockDestroy();
        Destroy(this.gameObject);
        TriggerParticleVFX();
    }

    private void BlockDestroySFX()
    {
        gameStatus.AddToScore();
        AudioSource.PlayClipAtPoint(clip, Camera.main.transform.position);
    }

    private void TriggerParticleVFX()
   {
      GameObject sparkle = Instantiate(blockSparklesVFX,transform.position,Quaternion.identity);
      Destroy(sparkle,1f);
   }
}
