using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static bool gameRunning;
    public Ball ball;

    public int scorePlayer;
    public int scoreCPU;
    
    public Text scoreText1;
    public Text scoreText2;
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartRound();
        }
        if (Input.GetKeyDown(KeyCode.Escape)) {
            Application.Quit();
        }
            
    }
    
    private void StartRound()
    {
        if (gameRunning)
        {
            return;
        }
        
        Debug.Log("Round Started");
        gameRunning = true;
        ball.InitialBallImpulse();
    }

    public void IncreaseScore(bool player)
    {
        if (player)
        {
            scorePlayer++;
        }
        else
        {
            scoreCPU++;
        }
        checkEndMatch();
        UpdateScore();
    }

    public void checkEndMatch()
    {
        if (scorePlayer == 3 || scoreCPU == 3)
        {
            if (scorePlayer == 3)
            {
                Debug.Log("Der Spieler hat gewonnen!");
            }
            else
            {
                Debug.Log("Die AI hat gewonnen!");
            }
            scorePlayer = 0;
            scoreCPU = 0;

            UpdateScore();
        }
    }
    
    private void UpdateScore()
    {
        scoreText1.text = scorePlayer.ToString();
        scoreText2.text = scoreCPU.ToString();
    }
    
}
