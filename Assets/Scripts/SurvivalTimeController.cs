using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SurvivalTimeController : MonoBehaviour
{
    public Text SurvivalTimeSecond;
    public static float timer = 100;
    public static float Detimer = 0;
    public static float ScorePotentialTimer = 0;
    public static float FishLineChangeDetector = 0;
    public static float ThisGameScoreShower = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Detimer += Time.deltaTime;
        timer = 100 - Detimer;
        ScorePotentialTimer += Time.deltaTime;
        FishLineChangeDetector += Time.deltaTime;
        ThisGameScoreShower += Time.deltaTime;
        SurvivalTimeSecond.text = timer.ToString("000.0");
        if(timer <= 0)
        {
            int ShopToken = (int)SurvivalTimeController.ScorePotentialTimer + (int)SurivivalTimeController300.ScorePotentialTimer + (int)SurvivalTimeController500.ScorePotentialTimer;
            PlayerPrefs.SetInt("shopToken", ShopToken);
            PlayerPrefs.SetFloat("SurvivedTime", timer);
            SceneManager.LoadScene("GameClear");
        }
    }
}
