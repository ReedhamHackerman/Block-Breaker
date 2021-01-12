using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadGameFromStart : MonoBehaviour
{
   public void LoadFirstScene()
   {
       FindObjectOfType<GameStatus>().ResetGame();
       SceneManager.LoadScene(0);
   }
}
