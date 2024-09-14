using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SurvivalTimeMinuteDetector : MonoBehaviour
{
    public Text SurvivalTimeMinute;
    private float MinuteTimer = 0;
    public static int MinuteDetector = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MinuteTimer += Time.deltaTime;
        if(MinuteTimer >= 60)
        {
            MinuteDetector++;
            MinuteTimer = 0;
            SurvivalTimeController.timer = 0;
            SurvivalTimeMinute.text = MinuteDetector.ToString("00");
        }
    }
}
