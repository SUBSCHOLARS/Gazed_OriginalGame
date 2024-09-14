using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverController : MonoBehaviour
{
    public Text SurvivedTimeScore;
    public Text SurivivedTimeTextMinute;
    public Text SurvivedTimeText;
    // Start is called before the first frame update
    void Start()
    {
        float SurvivedTime = PlayerPrefs.GetFloat("SurvivedTime", 0f);
        int SurvivedTimeMinute = PlayerPrefs.GetInt("SurvivedTimeMinute", 0);
        float SurvivedScore = PlayerPrefs.GetFloat("SurvivedScore", 0f);
        SurvivedTimeText.text = SurvivedTime.ToString("00.0");
        SurivivedTimeTextMinute.text = SurvivedTimeMinute.ToString("00");
        SurvivedTimeScore.text = SurvivedScore.ToString("000");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
