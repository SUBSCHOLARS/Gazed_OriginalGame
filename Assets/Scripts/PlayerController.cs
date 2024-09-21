using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    float MovingSpeed = 20f;
    private float rotationAngle;
    float VerticalMovingSpeed = 15f;
    float NormalVertical = 5f;
    Rigidbody playerRB;
    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.up * NormalVertical * Time.deltaTime;
        rotationAngle = -transform.eulerAngles.y * Mathf.Deg2Rad;

        float moveForward = Input.GetAxis("Horizontal") * MovingSpeed * Time.deltaTime;
        float moveRight = Input.GetAxis("Vertical") * MovingSpeed * Time.deltaTime;

        float RotationMatrixX = moveForward * Mathf.Cos(rotationAngle) - moveRight * Mathf.Sin(rotationAngle);
        float RotationMatrixZ = moveForward * Mathf.Sin(rotationAngle) + moveRight * Mathf.Cos(rotationAngle);

        this.transform.position += new Vector3(RotationMatrixX, 0, RotationMatrixZ);
        

        if(Input.GetMouseButton(0))
        {
            transform.position += Vector3.down * VerticalMovingSpeed * Time.deltaTime;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Cat"))
        {
            int ShopToken = (int)SurvivalTimeController.ScorePotentialTimer + (int)SurivivalTimeController300.ScorePotentialTimer + (int)SurvivalTimeController500.ScorePotentialTimer;       
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
            }
            //PlayerPrefs.SetInt("SurvivedTimeMinute", SurvivalTimeMinuteDetector.MinuteDetector);
        }
    }
}
