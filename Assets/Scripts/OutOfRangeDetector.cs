using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OutOfRangeDetector : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene("GameOver");
            PlayerPrefs.SetFloat("SurvivedScore", SurvivalTimeController.ScorePotentialTimer);
            PlayerPrefs.SetFloat("SurvivedTime", SurvivalTimeController.timer);
            PlayerPrefs.SetInt("SurvivedTimeMinute", SurvivalTimeMinuteDetector.MinuteDetector);
            SurvivalTimeController.timer = 0;
        }
    }
}
