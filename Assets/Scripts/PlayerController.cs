using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    float MovingSpeed = 20f;
    float VerticalMovingSpeed = 15f;
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

        Vector3 forward = transform.forward;  // プレイヤーの前方向
        Vector3 right = transform.right;      // プレイヤーの右方向

        Vector3 moveDirection = Vector3.zero; // 移動ベクトルを初期化

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            moveDirection += right;
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            moveDirection -= right;
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            moveDirection -= forward;
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            moveDirection += forward;
        }

        // 正規化して、移動速度を調整
        moveDirection = moveDirection.normalized * MovingSpeed * Time.deltaTime;
        transform.position += moveDirection;


        /*if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += new Vector3(1, 0, 0) * MovingSpeed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += new Vector3(-1, 0, 0) * MovingSpeed * Time.deltaTime;
        }
        else if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += new Vector3(0, 0, 1) * MovingSpeed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += new Vector3(0, 0, -1) * MovingSpeed * Time.deltaTime;
        }*/
        if(Input.GetMouseButton(0))
        {
            transform.position += Vector3.down * VerticalMovingSpeed * Time.deltaTime;
        }
        else if(Input.GetMouseButton(1))
        {
            transform.position += Vector3.up * VerticalMovingSpeed * Time.deltaTime;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Cat"))
        {
            SceneManager.LoadScene("GameOver");
            /*PlayerPrefs.SetFloat("SurvivedScore", SurvivalTimeController.ScorePotentialTimer);
            PlayerPrefs.SetFloat("SurvivedTime", SurvivalTimeController.timer);
            PlayerPrefs.SetInt("SurvivedTimeMinute", SurvivalTimeMinuteDetector.MinuteDetector);
            SurvivalTimeController.timer = 0;*/
            /*Vector3 CollisionDirection = collision.contacts[0].normal;
            playerRB.AddForce(-CollisionDirection * Force, ForceMode.Impulse);*/
        }
    }
}
