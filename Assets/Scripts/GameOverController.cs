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
    private float survivedScore;
    private float survivedTime;
    private int survivedTimeMinute;
    // Start is called before the first frame update
    void Start()
    {
        ShopButton.onClick.AddListener(OnShopButtonClick);
        TitleButton.onClick.AddListener(OnTitleButtonClick);
        //survivedScore = PlayerPrefs.GetFloat("SurvivedScore", 0f);
        //survivedTime = PlayerPrefs.GetFloat("SurvivedTime", 0f);

        SurvivedTimeText.text = SurvivalTimeController.timer.ToString("00.0");
        SurvivedTimeScore.text = SurvivalTimeController.ScorePotentialTimer.ToString("0000");

        /*ScoreManager.accumulatedScore = PlayerPrefs.GetFloat("SurvivedScore", 0f);
        ScoreManager.accumulatedScores += survivedScore;*/
        AccumulatedScore.text = ScoreManager.accumulatedScores.ToString("0000");

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
