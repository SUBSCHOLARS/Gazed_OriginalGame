using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitleController : MonoBehaviour
{
    public Text LongestSurvivedTimeMinute;
    public Text LongestSurivedTime;
    public Text AccumulatedScore;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GameOverController.SurvivedTime > GameOverController.SurvivedHighScore)
        {
            GameOverController.SurvivedHighScore = GameOverController.SurvivedTime;
            LongestSurvivedTimeMinute.text = (GameOverController.SurvivedHighScore / 60).ToString("00");
            LongestSurivedTime.text = (GameOverController.SurvivedHighScore % 60).ToString("00.0");
        }
        else
        {
            LongestSurvivedTimeMinute.text = (GameOverController.SurvivedHighScore / 60).ToString("00");
            LongestSurivedTime.text = (GameOverController.SurvivedHighScore % 60).ToString("00.0");
        }
        AccumulatedScore.text = GameOverController.AccumulatedScore.ToString("000");
    }
}
