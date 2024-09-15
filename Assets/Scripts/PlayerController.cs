using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    float MovingSpeed = 20f;
    float VerticalMovingSpeed = 15f;
    float NormalVertical = 5f;
    //float Force = 10f;
    /*float RotateSpeed = 15f;
    float x;
    float y;*/
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
        Vector3 moveDirection = Vector3.zero; // 移動ベクトルを初期化

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            moveDirection -= transform.forward;
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            moveDirection += transform.forward;
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            moveDirection += transform.right;
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            moveDirection -= transform.right;
        }

        transform.Translate(moveDirection.normalized * MovingSpeed * Time.deltaTime);

        if(Input.GetMouseButton(0))
        {
            transform.position += Vector3.down * VerticalMovingSpeed * Time.deltaTime;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Cat"))
        {
            SceneManager.LoadScene("GameOver");
            PlayerPrefs.SetFloat("SurvivedScore", SurvivalTimeController.ScorePotentialTimer);
            PlayerPrefs.SetFloat("SurvivedTime", SurvivalTimeController.timer);
            PlayerPrefs.SetInt("SurvivedTimeMinute", SurvivalTimeMinuteDetector.MinuteDetector);
            SurvivalTimeController.timer = 0;
        }
    }
}
