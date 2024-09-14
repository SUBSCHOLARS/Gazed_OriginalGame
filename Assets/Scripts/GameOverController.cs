using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverController : MonoBehaviour
{
    public Text SurvivedTimeScore;
    public Text SurivivedTimeTextMinute;
    public Text SurvivedTimeText;
    /*public static float SurvivedHighScore;
    public static float SurvivedTime;
    public static int SurvivedTimeMinute;
    public static float SurvivedScore;
    public static float AccumulatedScore = 0;*/

    private float survivedScore;
    private float survivedTime;
    private int survivedTimeMinute;
    // Start is called before the first frame update
    void Start()
    {
        /*SurvivedHighScore = PlayerPrefs.GetFloat("SurvivedScore", 0f);
        SurvivedTime = PlayerPrefs.GetFloat("SurvivedTime", 0f);
        SurvivedTimeMinute  = PlayerPrefs.GetInt("SurvivedTimeMinute", 0);
        SurvivedScore = PlayerPrefs.GetFloat("SurvivedScore", 0f);*/
        //Time.timeScale = 0;
        survivedScore = PlayerPrefs.GetFloat("SurvivedScore", 0f);
        survivedTime = PlayerPrefs.GetFloat("SurvivedTime", 0f);
        survivedTimeMinute = PlayerPrefs.GetInt("SurvivedTimeMinute", 0);

        SurvivedTimeText.text = survivedTime.ToString("00.0");
        SurivivedTimeTextMinute.text = survivedTimeMinute.ToString("00");
        SurvivedTimeScore.text = survivedScore.ToString("0000");

        float highScore = PlayerPrefs.GetFloat("HighScore", survivedScore);
        if(survivedScore > highScore)
        {
            PlayerPrefs.SetFloat("HighScore", survivedScore);
        }
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
