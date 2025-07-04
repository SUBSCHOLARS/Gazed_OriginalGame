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
    public RectTransform uiElement;
    public Vector3 startPosition = new Vector3(-359, 175, 0);
    public Vector3 targetPosition = new Vector3(158, 175, 0);
    float duration = 100f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(MoveUIElement(startPosition, targetPosition, duration));
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position += new Vector3(1, 0, 0) * FishSpeed * Time.deltaTime;
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
                    if(SurvivalTimeController.FishLineChangeDetector >= 99)
                    {
                        FishLinePreparetionRestart.gameObject.SetActive(true);
                        FishLineRealizeFraud.gameObject.SetActive(false);
                    }
                }
            }
        }
    }
    IEnumerator MoveUIElement(Vector3 start, Vector3 target, float time)
    {
        float elapsedTime = 0f;
        uiElement.anchoredPosition = start;
        while(elapsedTime < time)
        {
            uiElement.anchoredPosition = Vector3.Lerp(start, target, elapsedTime  / time);
            elapsedTime += Time.deltaTime;
            yield return null;
        }
        uiElement.anchoredPosition = target;
    }
}
