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
    float accumulatedScores = 0;
    private float survivedScore;
    private float survivedTime;
    private int survivedTimeMinute;
    public static float accumulatedScore = 0;
    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine(WaitForBeingZero());
        ShopButton.onClick.AddListener(OnShopButtonClick);
        TitleButton.onClick.AddListener(OnTitleButtonClick);
        //survivedScore = PlayerPrefs.GetFloat("SurvivedScore", 0f);
        //survivedTime = PlayerPrefs.GetFloat("SurvivedTime", 0f);
        string currentSceneName = SceneManager.GetActiveScene().name;
        switch(currentSceneName)
        {
            case "GameOver":
            ScoreManager.accumulatedScore = PlayerPrefs.GetFloat("SurvivedScore", 0f);
            AccumulatedScore.text = ScoreManager.accumulatedScores.ToString("0000");
            SurvivedTimeText.text = SurvivalTimeController.timer.ToString("000.0");
            SurvivedTimeScore.text = SurvivalTimeController.ScorePotentialTimer.ToString("0000");
            Debug.Log("累積スコアが代入されました");
            SurvivalTimeController.Detimer = 0;
            SurvivalTimeController.ScorePotentialTimer = 0;
            break;
            case "GameOver300":
            ScoreManager.accumulatedScore = PlayerPrefs.GetFloat("SurvivedScore", 0f);
            SurvivedTimeText.text = SurivivalTimeController300.timer.ToString("000.0");
            SurvivedTimeScore.text = SurivivalTimeController300.ScorePotentialTimer.ToString("0000");
            AccumulatedScore.text = ScoreManager.accumulatedScores.ToString("0000");
            Debug.Log("累積スコアが代入されました");
            SurivivalTimeController300.Detimer = 0;
            SurvivalTimeController.ScorePotentialTimer = 0;
            break;
            case "GameOver500":
            ScoreManager.accumulatedScore = PlayerPrefs.GetFloat("SurvivedScore", 0f);
            SurvivedTimeText.text = SurvivalTimeController500.timer.ToString("000.0");
            SurvivedTimeScore.text = SurvivalTimeController500.ScorePotentialTimer.ToString("0000");
            AccumulatedScore.text = ScoreManager.accumulatedScores.ToString("0000");
            Debug.Log("累積スコアが代入されました");
            SurvivalTimeController500.Detimer = 0;
            SurvivalTimeController.ScorePotentialTimer = 0;
            break;
        }

        /*ScoreManager.accumulatedScore = PlayerPrefs.GetFloat("SurvivedScore", 0f);
        ScoreManager.accumulatedScores += survivedScore;*/
        //AccumulatedScore.text = ScoreManager.accumulatedScores.ToString("0000");

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
    IEnumerator WaitForBeingZero()
    {
        yield return new WaitForSeconds(3);

        ScoreManager.accumulatedScore = 0;
        Debug.Log("値を0にしました");
    }
}
