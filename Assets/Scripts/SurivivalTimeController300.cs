using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SurivivalTimeController300 : MonoBehaviour
{
    public Text SurvivalTimeSecond;
    public static float timer = 300;
    public static float Detimer = 0;
    public static float ScorePotentialTimer = 0;
    public static float FishLineChangeDetector = 0;
    public static float ThisGameScoreShower = 0;
    public GameObject AdditionalEnemyGenerator; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Detimer += Time.deltaTime;
        timer = 300 - Detimer;
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
       else  if(ScorePotentialTimer >= 200)
        {
            AdditionalEnemyGenerator.SetActive(true);
        }
    }
}
