using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SurvivalTimeController500 : MonoBehaviour
{
    public Text SurvivalTimeSecond;
    public static float timer = 0;
    public static float Detimer = 0;
    public static float ScorePotentialTimer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Detimer += Time.deltaTime;
        timer = 500 - Detimer;
        ScorePotentialTimer += Time.deltaTime;
        SurvivalTimeSecond.text = timer.ToString("000.0");
        if(timer <= 0)
        {
            SceneManager.LoadScene("GameClear");
        }
    }
}
