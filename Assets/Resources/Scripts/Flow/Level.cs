using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Level : MonoBehaviour
{
    [SerializeField] int breakAbleBlocks;
    Sceneloader sceneloader;
   public void CountBreakableBlocks()
   {
       breakAbleBlocks++;
   }
   public void BlockDestroy()
   {
       breakAbleBlocks--;
       if (breakAbleBlocks<=0)
       {
           
       }
   }
}
