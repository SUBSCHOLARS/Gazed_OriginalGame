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

        float newX = moveForward * Mathf.Cos(rotationAngle) - moveRight * Mathf.Sin(rotationAngle);
        float newZ = moveForward * Mathf.Sin(rotationAngle) + moveRight * Mathf.Cos(rotationAngle);

        this.transform.position += new Vector3(newX, 0, newZ);
        /*Vector3 moveDirection = Vector3.zero;

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

        transform.Translate(moveDirection.normalized * MovingSpeed * Time.deltaTime);*/

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
