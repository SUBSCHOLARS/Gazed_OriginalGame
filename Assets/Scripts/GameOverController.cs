using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverController : MonoBehaviour
{
    public Text SurvivedTimeScore;
    public Text AccumulatedScore;
    public Text SurvivedTimeText;
    public Button ShopButton;
    public Button TitleButton;
    // Start is called before the first frame update
    void Start()
    {
        int shopTokens = PlayerPrefs.GetInt("shopToken", 0);
        ShopButton.onClick.AddListener(OnShopButtonClick);
        TitleButton.onClick.AddListener(OnTitleButtonClick);
        string currentSceneName = SceneManager.GetActiveScene().name;
        switch(currentSceneName)
        {
            case "GameOver":
            //AccumulatedScore.text = SurvivalTimeController.ThisGameScoreShower.ToString("0000");
            int IntScore = (int)SurvivalTimeController.ThisGameScoreShower;
            AccumulatedScore.text = IntScore.ToString("0000");
            SurvivedTimeText.text = SurvivalTimeController.timer.ToString("000.0");
            //SurvivedTimeScore.text = (SurvivalTimeController.ScorePotentialTimer + SurivivalTimeController300.ScorePotentialTimer + SurvivalTimeController500.ScorePotentialTimer).ToString("0000");
            SurvivedTimeScore.text = shopTokens.ToString("0000");
            Debug.Log("累積スコアが代入されました");
            SurvivalTimeController.Detimer = 0;
            SurvivalTimeController.ThisGameScoreShower = 0;
            SurvivalTimeController.FishLineChangeDetector = 0;
            break;
            case "GameOver300":
            SurvivedTimeText.text = SurivivalTimeController300.timer.ToString("000.0");
            int IntScore300 = (int)SurivivalTimeController300.ThisGameScoreShower;
            //SurvivedTimeScore.text = (SurvivalTimeController.ScorePotentialTimer + SurivivalTimeController300.ScorePotentialTimer + SurvivalTimeController500.ScorePotentialTimer).ToString("0000");
            SurvivedTimeScore.text = shopTokens.ToString("0000");
            //AccumulatedScore.text = SurivivalTimeController300.ThisGameScoreShower.ToString("0000");
            AccumulatedScore.text = IntScore300.ToString("0000");
            Debug.Log("累積スコアが代入されました");
            SurivivalTimeController300.Detimer = 0;
            SurivivalTimeController300.ThisGameScoreShower = 0;
            SurivivalTimeController300.FishLineChangeDetector = 0;
            break;
            case "GameOver500":
            SurvivedTimeText.text = SurvivalTimeController500.timer.ToString("000.0");
            int IntScore500 = (int)SurvivalTimeController500.ThisGameScoreShower;
            //SurvivedTimeScore.text = (SurvivalTimeController.ScorePotentialTimer + SurivivalTimeController300.ScorePotentialTimer + SurvivalTimeController500.ScorePotentialTimer).ToString("0000");
            SurvivedTimeScore.text = shopTokens.ToString("0000");
            //AccumulatedScore.text = SurvivalTimeController500.ThisGameScoreShower.ToString("0000")
            AccumulatedScore.text = IntScore500.ToString("0000");;
            Debug.Log("累積スコアが代入されました");
            SurvivalTimeController500.Detimer = 0;
            SurvivalTimeController500.ThisGameScoreShower = 0;
            SurvivalTimeController500.FishLineChangeDetector = 0;
            break;
        }

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnShopButtonClick()
    {
        string currentSceneName = SceneManager.GetActiveScene().name;  
        switch(currentSceneName)
            {
                case "GameOver":
                    SceneManager.LoadScene("Shop");
                    break;
                case "GameOver300":
                    SceneManager.LoadScene("Shop300");
                    break;
                case "GameOver500":
                    SceneManager.LoadScene("Shop500");
                    break;
                default:
                    return;
            }
    }
    void OnTitleButtonClick()
    {
        string currentSceneName = SceneManager.GetActiveScene().name;   
        switch(currentSceneName)
            {
                case "GameOver":
                    SceneManager.LoadScene("TitleAfterfirst");
                    break;
                case "GameOver300":
                    SceneManager.LoadScene("TitleAfterFirst300");
                    break;
                case "GameOver500":
                    SceneManager.LoadScene("TitleAfterFirst500");
                    break;
                default:
                    return;
            }
    }
}
