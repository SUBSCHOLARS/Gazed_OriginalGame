using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverController : MonoBehaviour
{
    public Text SurvivedTimeScore;
    public Text AccumulatedScore;
    public Text SurvivedTimeText;

    private float survivedScore;
    private float survivedTime;
    private int survivedTimeMinute;
    // Start is called before the first frame update
    void Start()
    {
        survivedScore = PlayerPrefs.GetFloat("SurvivedScore", 0f);
        survivedTime = PlayerPrefs.GetFloat("SurvivedTime", 0f);

        SurvivedTimeText.text = SurvivalTimeController.timer.ToString("00.0");
        SurvivedTimeScore.text = SurvivalTimeController.ScorePotentialTimer.ToString("0000");

        TitleController.accumulatedScore = PlayerPrefs.GetFloat("SurvivedScore", 0f);
        TitleController.accumulatedScores += survivedScore;
        AccumulatedScore.text = TitleController.accumulatedScores.ToString("0000");

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
