using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameClearController : MonoBehaviour
{
    public Text SurvivedTimeScore;
    public Text AccumulatedScore;
    public float bonusScore = 100;
    private float survivedScore;
    // Start is called before the first frame update
    void Start()
    {
        //survivedScore = PlayerPrefs.GetFloat("SurvivedScore", 0f) + bonusScore;
        SurvivedTimeScore.text = (SurvivalTimeController.ScorePotentialTimer + bonusScore).ToString("0000");
        
        /*ScoreManager.accumulatedScore = PlayerPrefs.GetFloat("SurvivedScore", 0f);
        ScoreManager.accumulatedScores += survivedScore;*/
        ScoreManager.accumulatedScores += bonusScore;
        AccumulatedScore.text = (ScoreManager.accumulatedScores + bonusScore).ToString("0000");

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
