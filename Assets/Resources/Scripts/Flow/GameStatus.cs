using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameStatus : MonoBehaviour
{
   [Range(0.1f,10f)] [SerializeField] float gameSpeed;
   [SerializeField] int pointPerBlockDestroyed = 83;
   [SerializeField] int currentScore = 0;
   [SerializeField] TextMeshProUGUI text;
   [SerializeField]  bool isAutoPlay;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        int statusCount = FindObjectsOfType<GameStatus>().Length;
        if (statusCount>1)
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
        Time.timeScale = gameSpeed;
        text.SetText("Score :" +currentScore,true);
     
    }

    public void AddToScore()
    {
        currentScore += pointPerBlockDestroyed;
    }
    public void ResetGame()
{
     Destroy(gameObject);
}

public bool isAutoPlayEnabled()
{
    return isAutoPlay;;
}

}
