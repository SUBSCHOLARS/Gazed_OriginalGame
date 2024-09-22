using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class RemainingTimeGeometrizer : MonoBehaviour
{
    public Text FishLine;
    public Text FishLine2;
    public Text FishLineRealizeFraud;
    public Text FishLinePreparetionRestart;
    public Text FishLineResolutuion;
    private float FishSpeed = 0.8f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(1, 0, 0) * FishSpeed * Time.deltaTime;
        if(SurvivalTimeController500.FishLineChangeDetector >= 10)
        {
            FishLine.gameObject.SetActive(true);
            if(SurvivalTimeController500.FishLineChangeDetector >= 60)
            {
                FishLine2.gameObject.SetActive(true);
                FishLine.gameObject.SetActive(false);
                if(SurvivalTimeController500.FishLineChangeDetector >= 150)
                {
                    FishLineRealizeFraud.gameObject.SetActive(true);
                    FishLine2.gameObject.SetActive(false);
                    if(SurvivalTimeController500.FishLineChangeDetector >= 200)
                    {
                        FishLinePreparetionRestart.gameObject.SetActive(true);
                        FishLineRealizeFraud.gameObject.SetActive(false);
                        if(SurvivalTimeController500.FishLineChangeDetector >= 250)
                        {
                            FishLineResolutuion.gameObject.SetActive(true);
                            FishLinePreparetionRestart.gameObject.SetActive(true);
                        }
                    }
                }
            }
        }
    }
}
