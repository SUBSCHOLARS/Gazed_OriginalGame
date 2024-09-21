using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameClearController : MonoBehaviour
{
    public Text SurvivedTimeScore;
    public Text AccumulatedScore;
    public float bonusScore = 100;
    /*public static float accumulatedScores = 0;
    public static float accumulatedScore = 0;*/
    private float survivedScore;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(WaitForBeingZero());
        //survivedScore = PlayerPrefs.GetFloat("SurvivedScore", 0f) + bonusScore;
        string currentSceneName = SceneManager.GetActiveScene().name;
        switch(currentSceneName)
        {
            case "GameClear":
            ScoreManager.accumulatedScore = PlayerPrefs.GetFloat("SurvivedScore", 0f);
            SurvivedTimeScore.text = SurvivalTimeController.ScorePotentialTimer.ToString("0000");
            AccumulatedScore.text = ScoreManager.accumulatedScores.ToString("0000");
            Debug.Log("累積スコアが代入されました");
            SurvivalTimeController.Detimer = 0;
            SurvivalTimeController.ScorePotentialTimer = 0;
            break;
            case "GameClear300":
            ScoreManager.accumulatedScore = PlayerPrefs.GetFloat("SurvivedScore", 0f);
            SurvivedTimeScore.text = SurivivalTimeController300.ScorePotentialTimer.ToString("0000");
            AccumulatedScore.text = ScoreManager.accumulatedScores.ToString("0000");
            Debug.Log("累積スコアが代入されました");
            SurivivalTimeController300.Detimer = 0;
            SurivivalTimeController300.ScorePotentialTimer = 0;
            break;
            case "GameClear500":
            ScoreManager.accumulatedScore = PlayerPrefs.GetFloat("SurvivedScore", 0f);
            SurvivedTimeScore.text = SurvivalTimeController500.ScorePotentialTimer.ToString("0000");
            AccumulatedScore.text = ScoreManager.accumulatedScores.ToString("0000");
            Debug.Log("累積スコアが代入されました");
            SurvivalTimeController500.Detimer = 0;
            SurvivalTimeController500.ScorePotentialTimer = 0;
            break;
        }
        
        /*ScoreManager.accumulatedScore = PlayerPrefs.GetFloat("SurvivedScore", 0f);
        ScoreManager.accumulatedScores += survivedScore;*/
        //ScoreManager.accumulatedScores += bonusScore;
        //AccumulatedScore.text = ScoreManager.accumulatedScores.ToString("0000");

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator WaitForBeingZero()
    {
        yield return new WaitForSeconds(3);

        ScoreManager.accumulatedScore = 0;
        Debug.Log("値を0にしました");
    }
}
