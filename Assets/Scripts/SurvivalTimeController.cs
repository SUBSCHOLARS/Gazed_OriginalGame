using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SurvivalTimeController : MonoBehaviour
{
    public Text SurvivalTimeSecond;
    public static float timer = 0;
    public static float SocrePotentialTimer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        SocrePotentialTimer += Time.deltaTime;
        SurvivalTimeSecond.text = timer.ToString("00.0");
    }
}
