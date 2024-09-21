using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public static float accumulatedScores = 0;
    public static float accumulatedScore = 0;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this);
        accumulatedScore = PlayerPrefs.GetFloat("SurvivedScore", 0f);
        Debug.Log("値が保存されました");
        accumulatedScores += accumulatedScore;
        Debug.Log("保存された値をaccumulatedScoresに加算しました");
        /*string currentSceneName = SceneManager.GetActiveScene().name;
        switch(currentSceneName)
        {
            case"GameClear":
            accumulatedScores += accumulatedScore;
            break;
            case "GameClear300":
            accumulatedScores += accumulatedScore;
            break;
            case "GameClear500":
            accumulatedScores += accumulatedScore;
            break;
            case "GameOver":
            accumulatedScores += accumulatedScore;
            break;
            case "GameOver300":
            accumulatedScores += accumulatedScore;
            break;
            case "GameOver500":
            accumulatedScores += accumulatedScore;
            break;
        }*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
