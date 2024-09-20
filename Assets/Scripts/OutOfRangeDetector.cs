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
            string currentSceneName = SceneManager.GetActiveScene().name;
            switch(currentSceneName)
            {
                case "Main":
                    SceneManager.LoadScene("GameOver");
                    break;
                case "Main300":
                    SceneManager.LoadScene("GameOver300");
                    break;
                case "Main500":
                    SceneManager.LoadScene("GameOver500");
                    break;
                default:
                    return;
            }
            PlayerPrefs.SetFloat("SurvivedScore", SurvivalTimeController.ScorePotentialTimer);
            PlayerPrefs.SetFloat("SurvivedTime", SurvivalTimeController.timer);
            PlayerPrefs.SetInt("SurvivedTimeMinute", SurvivalTimeMinuteDetector.MinuteDetector);
            SurvivalTimeController.Detimer = 0;
            SurivivalTimeController300.Detimer = 0;
            SurvivalTimeController500.Detimer = 0;

            SurvivalTimeController.timer = 100;
            SurvivalTimeController.timer = 300;
            SurvivalTimeController500.timer = 500;
        }
    }
}
