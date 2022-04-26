using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static bool Over;

    public int currentScore = 0;
    public int totalScore = 0;
    private float timer;
    public Text totalScoreText;
    public Text currentScoreText;

    // Start is called before the first frame update
    void Start()
    {
        totalScore = PlayerPrefs.GetInt("Score", 0);
        currentScore = 0;
        Over = true;
        totalScoreText.text = totalScore.ToString("00000");
    }

    // Update is called once per frame
    void Update()
    {
        
        if (!Over)
        {
            timer += Time.deltaTime;

            if (timer > 0.1f)
            {

                currentScore += 1;

                //We only need to update the text if the score changed.
                currentScoreText.text = currentScore.ToString("00000");

                //Reset the timer to 0.
                timer = 0;
            }

            if(currentScore > 100 && currentScore < 200)
            {
                Time.timeScale = 1.3f;
            }

            if (currentScore > 400 && currentScore < 500)
            {
                Time.timeScale = 1.7f;
            }

            if (currentScore > 700 && currentScore < 800)
            {
                Time.timeScale = 2f;
            }
        }

       

       else if (Over)
        {
            if(totalScore < currentScore)
            {
                totalScore = currentScore;
                PlayerPrefs.SetInt("Score", totalScore);
                totalScoreText.text = totalScore.ToString("00000");
            }
        }
        


    }
}
