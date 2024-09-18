using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitleController : MonoBehaviour
{
    public Text LongestSurvivedTimeMinute;
    public Text LongestSurvivedTime;
    public Text AccumulatedScore;
    public static float accumulatedScores = 0;
    public static float accumulatedScore;
    private float survivedScore;
    // Start is called before the first frame update
    void Start()
    {
        //Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        survivedScore = PlayerPrefs.GetFloat("SurvivedScore", 0f);
        float highScore = PlayerPrefs.GetFloat("HighScore", survivedScore);
        if(survivedScore > highScore)
        {
            PlayerPrefs.SetFloat("HighScore", survivedScore);
        }

        /*if(highScore < 60)
        {
            LongestSurvivedTime.text = highScore.ToString("00.0");
        }
        else if(highScore >= 60)
        {
            LongestSurvivedTime.text = (highScore / 60).ToString("00.0");
            LongestSurvivedTimeMinute.text = (highScore % 60).ToString("00");
        }*/

        accumulatedScore = PlayerPrefs.GetFloat("SurvivedScore", 0f);
        accumulatedScores += accumulatedScore;
        AccumulatedScore.text = accumulatedScores.ToString("0000");
    }
}
