using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Level : MonoBehaviour
{
    [SerializeField] int breakAbleBlocks;
   int currentScene ;
   
   void Start()
   {
       currentScene = SceneManager.GetActiveScene().buildIndex;
   }
   public void CountBreakableBlocks()
   {
       breakAbleBlocks++;
       
   }
   public void BlockDestroy()
   {
       breakAbleBlocks--;
       if (breakAbleBlocks<=0)
       {
           if (SceneManager.sceneCountInBuildSettings-2>currentScene)
           {
               SceneManager.LoadScene(currentScene+1);
           }
           
       }
   }
}
