using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SurvivalTimeController500 : MonoBehaviour
{
    public Text SurvivalTimeSecond;
    public static float timer = 400;
    public static float Detimer = 0;
    public static float ScorePotentialTimer = 0;
    public static float FishLineChangeDetector = 0;
    float EnemyGenerating = 0;
    public static float ThisGameScoreShower = 0;
    public GameObject[] gameObjects = new GameObject[8];
    public GameObject AdditionalEnemyGenerator;
    float TextTimer = 0;
    public Text Notification;
    string NotificationText = "増援がやってきた!!!";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Detimer += Time.deltaTime;
        timer = 400 - Detimer;
        ScorePotentialTimer += Time.deltaTime;
        FishLineChangeDetector += Time.deltaTime;
        ThisGameScoreShower += Time.deltaTime;
        EnemyGenerating += Time.deltaTime;
        SurvivalTimeSecond.text = timer.ToString("000.0");
        if(timer <= 0)
        {
            AdditionalEnemyGenerator.SetActive(false);
            EnemyGenerating = 0;
            int ShopToken = (int)SurvivalTimeController.ScorePotentialTimer + (int)SurivivalTimeController300.ScorePotentialTimer + (int)SurvivalTimeController500.ScorePotentialTimer + ShopCurrencyHandler.ShopCurrencyYay;
            PlayerPrefs.SetInt("shopToken", ShopToken);
            PlayerPrefs.SetFloat("SurvivedTime", timer);
            for(int i = 0; i < gameObjects.Length; i++)
            {
                gameObjects[i].SetActive(false);
            }
            SceneManager.LoadScene("GameClear");
        }
        else if(EnemyGenerating >= 250)
        {
            AdditionalEnemyGenerator.SetActive(true);
            TextTimer += Time.deltaTime;
            Notification.text = NotificationText;
            if(TextTimer >= 3.0f)
            {
                Notification.gameObject.SetActive(false);
            }
        }
    }
}
