using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static float accumulatedScores = 0;
    public static float accumulatedScore;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this);
        accumulatedScore = PlayerPrefs.GetFloat("SurvivedScore", 0f);
        accumulatedScores += accumulatedScore;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
