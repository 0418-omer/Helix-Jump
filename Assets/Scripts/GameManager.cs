using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
   private int score;

   public Text scoreText;

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void gameScore(int ringScore) {
        score += ringScore;
        scoreText.text = score.ToString();
    }

    public void restartGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }


}
