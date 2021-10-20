/* Brianna Scott
 * Oct. 8, 2021
 * Purpose is to keep track of the current score, highest score, and amount of balls caught and show on the screen
*/

//preprocessor directives
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//public class Score Manager
public class ScoreManager : MonoBehaviour
{
    //declare public text variable, scoreText
    [SerializeField] Text scoreText;
    //declare int variable, score
    public int score;
    //declare in variable, high score
 //   public int highScore;
    //declare int variable balls caught
  //  public int ballsCaught;
    //declare public transform variable, player
    //public Transform player;
    //declare public text variable, highScoreText
  //  public Text highScoreText;
    //declare public text variable, ballsCaughtText
  //  public Text ballsCaughtText;

    //
 void Start()
    {

    }

    void Update()
    {
        scoreText.text = score.ToString();
    }
}
