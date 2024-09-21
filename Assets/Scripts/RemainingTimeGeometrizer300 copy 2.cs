using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class RemainingTimeGeometrizer300: MonoBehaviour
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
        transform.DOLocalMove(new Vector3(150, 175, 0), 600f);
        if(SurivivalTimeController300.ScorePotentialTimer >= 10)
        {
            FishLine.gameObject.SetActive(true);
            if(SurivivalTimeController300.ScorePotentialTimer >= 50)
            {
                FishLine2.gameObject.SetActive(true);
                FishLine.gameObject.SetActive(false);
                if(SurivivalTimeController300.ScorePotentialTimer >= 100)
                {
                    FishLineRealizeFraud.gameObject.SetActive(true);
                    FishLine2.gameObject.SetActive(false);
                    if(SurivivalTimeController300.ScorePotentialTimer >= 200)
                    {
                        FishLinePreparetionRestart.gameObject.SetActive(true);
                        FishLineRealizeFraud.gameObject.SetActive(false);
                        if(SurivivalTimeController300.ScorePotentialTimer >= 210)
                        {
                            FishLineResolutuion.gameObject.SetActive(true);
                            FishLinePreparetionRestart.gameObject.SetActive(false);
                        }
                    }
                }
            }
        }
    }
}
