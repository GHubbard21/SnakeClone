using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public static ScoreScript instance;

    public Text scoreText;
    public Text highscoreText;
    
    public static int score = 0;
    public static int highScore = 0;


    private void Awake() {
        instance = this;
    }

    // Start is called before the first frame update
    void Start() {
       // updateHighScore();
        scoreText.text = "Score: " + score.ToString();
        highscoreText.text = "Highscore: " + highScore.ToString();
       
    }

    // Update is called once per frame
    public void addPoint() {
        score += 1;
        scoreText.text = "Score: " + score.ToString();
       // checkHighScore();
    }

    public void ResetScore() {
        score = 0;
        scoreText.text = "Score: " + score.ToString();
    }

    /** public void updateHighScore() {
         highscoreText.text = "Highscore: " + score.ToString();
             //PlayerPrefs.GetInt("HIGHSCORE", 0);
         //highScore = PlayerPrefs.GetInt("highscore", 0);
    
     }*/

    /** public void checkHighScore() {
         if (highScore > PlayerPrefs.GetInt("HIGHSCORE", 0)) {
             PlayerPrefs.SetInt("HIGHSCORE", score);

             updateHighScore();
         }
     }
    */

}
