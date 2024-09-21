using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class RemainingTimeGeometrizer100: MonoBehaviour
{
    public Text FishLine;
    public Text FishLine2;
    public Text FishLineRealizeFraud;
    public Text FishLinePreparetionRestart;
    public Text FishLineResolutuion;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(3.2f, 0, 0) * Time.deltaTime;
        if(SurvivalTimeController.FishLineChangeDetector >= 10)
        {
            FishLine.gameObject.SetActive(true);
            if(SurvivalTimeController.FishLineChangeDetector >= 50)
            {
                FishLine2.gameObject.SetActive(true);
                FishLine.gameObject.SetActive(false);
                if(SurvivalTimeController.FishLineChangeDetector >= 90)
                {
                    FishLineRealizeFraud.gameObject.SetActive(true);
                    FishLine2.gameObject.SetActive(false);
                    if(SurvivalTimeController.FishLineChangeDetector >= 100)
                    {
                        FishLinePreparetionRestart.gameObject.SetActive(true);
                        FishLineRealizeFraud.gameObject.SetActive(false);
                    }
                }
            }
        }
    }
}
