using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverController : MonoBehaviour
{
    public Text SurvivedTimeText;
    // Start is called before the first frame update
    void Start()
    {
        float SurvivedTime = PlayerPrefs.GetFloat("SurvivedTime", 0f);
        SurvivedTimeText.text = SurvivedTime.ToString("000");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
