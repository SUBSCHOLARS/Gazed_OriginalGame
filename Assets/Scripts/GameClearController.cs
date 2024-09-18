using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameClearController : MonoBehaviour
{
    public Text SurvivedTimeScore;
    public Text SurivivedTimeTextMinute;
    public Text SurvivedTimeText;
    public float bonusScore = 100;

    private float survivedScore;
    //private float survivedTime;
    //private int survivedTimeMinute;
    // Start is called before the first frame update
    void Start()
    {
        survivedScore = PlayerPrefs.GetFloat("SurvivedScore", 0f) + bonusScore;
        //survivedTime = PlayerPrefs.GetFloat("SurvivedTime", 0f);
        //survivedTimeMinute = PlayerPrefs.GetInt("SurvivedTimeMinute", 0);

        //SurvivedTimeText.text = SurvivalTimeController.timer.ToString("00.0");
        //SurivivedTimeTextMinute.text = SurvivalTimeMinuteDetector.MinuteDetector.ToString("00");
        SurvivedTimeScore.text = SurvivalTimeController.ScorePotentialTimer.ToString("0000");

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
