using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OutOfRangeDetector : MonoBehaviour
{
    public GameObject[] gameObjects = new GameObject[8];
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
        for(int i = 0; i < gameObjects.Length; i++)
        {
            gameObjects[i].SetActive(false);
        }
        if(other.gameObject.CompareTag("Player"))
        {
            int ShopToken = (int)SurvivalTimeController.ScorePotentialTimer + (int)SurivivalTimeController300.ScorePotentialTimer + (int)SurvivalTimeController500.ScorePotentialTimer + ShopCurrencyHandler.ShopCurrencyYay;
            string currentSceneName = SceneManager.GetActiveScene().name;
            switch(currentSceneName)
            {
                case "Main":
                    PlayerPrefs.SetInt("shopToken", ShopToken);
                    PlayerPrefs.SetFloat("SurvivedTime", SurvivalTimeController.timer);
                    SceneManager.LoadScene("GameOver");
                    break;
                case "Main300":
                    PlayerPrefs.SetInt("shopToken", ShopToken);
                    PlayerPrefs.SetFloat("SurvivedTime", SurivivalTimeController300.timer);
                    SceneManager.LoadScene("GameOver300");
                    break;
                case "Main500":
                    PlayerPrefs.SetInt("shopToken", ShopToken);
                    PlayerPrefs.SetFloat("SurvivedTime", SurvivalTimeController500.timer);
                    SceneManager.LoadScene("GameOver500");
                    break;
                default:
                    return;
            }
        }
    }
}
