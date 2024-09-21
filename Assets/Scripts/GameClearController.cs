using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameClearController : MonoBehaviour
{
    public Text SurvivedTimeScore;
    public Text AccumulatedScore;
    // Start is called before the first frame update
    void Start()
    {
        string currentSceneName = SceneManager.GetActiveScene().name;
        int shopTokens = PlayerPrefs.GetInt("shopToken", 0);
        switch(currentSceneName)
        {
            case "GameClear":
            //ScoreManager.accumulatedScore = PlayerPrefs.GetFloat("SurvivedScore", 0f);
            //SurvivedTimeScore.text = ((int)SurvivalTimeController.ScorePotentialTimer + (int)SurivivalTimeController300.ScorePotentialTimer + (int)SurvivalTimeController500.ScorePotentialTimer).ToString("0000");
            SurvivedTimeScore.text = shopTokens.ToString("0000");
            AccumulatedScore.text = SurvivalTimeController.ThisGameScoreShower.ToString("0000");
            Debug.Log("累積スコアが代入されました");
            SurvivalTimeController.Detimer = 0;
            SurvivalTimeController.FishLineChangeDetector = 0;
            SurvivalTimeController.ThisGameScoreShower = 0;
            break;
            case "GameClear300":
            //ScoreManager.accumulatedScore = PlayerPrefs.GetFloat("SurvivedScore", 0f);
            //SurvivedTimeScore.text = ((int)SurvivalTimeController.ScorePotentialTimer + (int)SurivivalTimeController300.ScorePotentialTimer + (int)SurvivalTimeController500.ScorePotentialTimer).ToString("0000");
            SurvivedTimeScore.text = shopTokens.ToString("0000");
            AccumulatedScore.text = SurivivalTimeController300.ThisGameScoreShower.ToString("0000");
            Debug.Log("累積スコアが代入されました");
            SurivivalTimeController300.Detimer = 0;
            SurivivalTimeController300.FishLineChangeDetector = 0;
            SurivivalTimeController300.ThisGameScoreShower = 0;
            break;
            case "GameClear500":
            //ScoreManager.accumulatedScore = PlayerPrefs.GetFloat("SurvivedScore", 0f);
            //SurvivedTimeScore.text = ((int)SurvivalTimeController.ScorePotentialTimer + (int)SurivivalTimeController300.ScorePotentialTimer + (int)SurvivalTimeController500.ScorePotentialTimer).ToString("0000");
            SurvivedTimeScore.text = shopTokens.ToString("0000");
            AccumulatedScore.text = SurvivalTimeController500.ThisGameScoreShower.ToString("0000");
            Debug.Log("累積スコアが代入されました");
            SurvivalTimeController500.Detimer = 0;
            SurvivalTimeController500.FishLineChangeDetector = 0;
            SurvivalTimeController500.ThisGameScoreShower = 0;
            break;
        }
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
