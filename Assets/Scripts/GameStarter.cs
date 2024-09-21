using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStarter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GameStart()
    {
        string currentSceneName = SceneManager.GetActiveScene().name;
        switch(currentSceneName)
        {
            case "GameOver":
            SceneManager.LoadScene("Main");
            break;
            case "GameOver300":
            SceneManager.LoadScene("Main300");
            break;
            case "GameOver500":
            SceneManager.LoadScene("Main500");
            break;
        }
    }
}
