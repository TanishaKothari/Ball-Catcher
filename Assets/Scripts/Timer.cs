using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timeText;
    public Text gameOverText;
    public GameObject score;
    public GameObject Game_Over;
    public GloveMovement glove;
    public float timeRemaining = 5f;
    public bool timerIsRunning = false;
    // Start is called before the first frame update
    void Start()
    {
        timerIsRunning = true;
        Game_Over.SetActive(false);
        score.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);
            }
            else
            {
                Time.timeScale = 0f;
                score.SetActive(false);
                glove.enabled = false;
                Game_Over.SetActive(true);
                //this.score.transform.position = transform.position + new Vector3(960, -527);
                gameOverText.text = "Game Over! Your Score is " + Score.scoreValue.ToString();
                timeRemaining = 0;
                timerIsRunning = false;
            }
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
