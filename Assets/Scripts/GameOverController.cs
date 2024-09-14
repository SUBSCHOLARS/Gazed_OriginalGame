using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverController : MonoBehaviour
{
    public Text SurvivedTimeScore;
    public Text SurivivedTimeTextMinute;
    public Text SurvivedTimeText;
    public static float SurvivedHighScore = PlayerPrefs.GetFloat("SurvivedScore", 0f);
    public static float SurvivedTime = PlayerPrefs.GetFloat("SurvivedTime", 0f);
    public static int SurvivedTimeMinute = PlayerPrefs.GetInt("SurvivedTimeMinute", 0);
    public static float SurvivedScore = PlayerPrefs.GetFloat("SurvivedScore", 0f);
    public static float AccumulatedScore = 0;
    // Start is called before the first frame update
    void Start()
    {
        SurvivedTimeText.text = SurvivedTime.ToString("00.0");
        SurivivedTimeTextMinute.text = SurvivedTimeMinute.ToString("00");
        SurvivedTimeScore.text = SurvivedScore.ToString("000");
        AccumulatedScore += SurvivedHighScore;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
