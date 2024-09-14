using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitleController : MonoBehaviour
{
    public Text LongestSurvivedTimeMinute;
    public Text LongestSurvivedTime;
    public Text AccumulatedScore;
    float accumulatedScores = 0;
    // Start is called before the first frame update
    void Start()
    {
        //Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        float highScore = PlayerPrefs.GetFloat("HighScore", 0f);

        if(highScore < 60)
        {
            LongestSurvivedTime.text = highScore.ToString("00.0");
        }
        else if(highScore >= 60)
        {
            LongestSurvivedTime.text = (highScore / 60).ToString("00.0");
            LongestSurvivedTimeMinute.text = (highScore % 60).ToString("00");
        }

        float accumulatedScore = PlayerPrefs.GetFloat("SurvivedScore", 0f);
        accumulatedScores *= accumulatedScore;
        AccumulatedScore.text = accumulatedScore.ToString("0000");
    }
}
