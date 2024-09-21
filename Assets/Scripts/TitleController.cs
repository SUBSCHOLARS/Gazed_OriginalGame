using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitleController : MonoBehaviour
{
    public Text AccumulatedScore;
    private float survivedScore;
    // Start is called before the first frame update
    void Start()
    {
        int shopTokens = PlayerPrefs.GetInt("shopToken", 0);
        //AccumulatedScore.text = (SurvivalTimeController.ScorePotentialTimer + SurivivalTimeController300.ScorePotentialTimer + SurvivalTimeController500.ScorePotentialTimer).ToString("0000");
        AccumulatedScore.text = shopTokens.ToString("0000");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
