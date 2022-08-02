using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GamePanel : MonoBehaviour
{
    public FollowUp wp;
    public BlackTrain bt;
    public YellowTrain yt;
    public int RedBool = 0;
    public int BlackBool = 0;
    public int YellowBool = 0;
    button2 ct;
    button3 ct3;

    public float timeRemaining = 10;
    public bool timerIsRunning = false;
    public Text timeText;
    public Text WinLose;

    public GameOverScreen GameOverScreen;
    int maxPlatform = 0;
    public WinScreen WinScreen;

    public void GameOver()
    {
        GameOverScreen.Setup(maxPlatform);
    }
    public void Win()
    {
        WinScreen.Setup(maxPlatform);
    }
    // Start is called before the first frame update
    void Start()
    {
        timerIsRunning = true;
    }

    // Update is called once per frame
    void Update()

    {
        DisplayTime(timeRemaining);
        if(bt.transform.position.x == 5.49f && bt.transform.position.y == 1.36f)
        {
            BlackBool = 1;
        }
        if(wp.transform.position.x == -2.33f && wp.transform.position.y == 1.47f)
        {
            RedBool = 1;
        }
        if (yt.transform.position.x == 5.26f && yt.transform.position.y == 3.86f)
        {
            YellowBool = 1;
        }
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
            }
            else
            {
                
                timeRemaining = 0;
                timerIsRunning = false;
                GameOver();
            }
        }
        
        if(bt.transform.position.x == -2.33f && bt.transform.position.y ==1.47f || bt.transform.position.x == 5.26f && bt.transform.position.y == 3.86f)
        {
            GameOver();
        }
        if (yt.transform.position.x == -2.33f && yt.transform.position.y == 1.47f || yt.transform.position.x == 5.49f && yt.transform.position.y == 1.36f)
        {
            GameOver();
        }
        if (wp.transform.position.x == -5.49f && wp.transform.position.y == 1.36f || wp.transform.position.x == 5.26f && wp.transform.position.y == 3.86f)
        {
            GameOver();
        }
        if (wp.transform.position.x <= -5.47f || bt.transform.position.x <= -5.47f || yt.transform.position.x <= -5.47f )
        {
            GameOver();
        }


        if (RedBool == 1 && BlackBool == 1 && YellowBool == 1)
        {
            Win();
        }
        
    }
    void DisplayTime(float timeToDisplay)
    {
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
