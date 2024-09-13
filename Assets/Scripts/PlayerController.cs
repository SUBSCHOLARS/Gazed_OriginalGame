using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    float MovingSpeed = 20f;
    float VerticalMovingSpeed = 15f;
    float PotentialScoreTimer = 0;
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
        PotentialScoreTimer += Time.deltaTime;
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += new Vector3(0, 0, 1) * MovingSpeed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += new Vector3(0, 0, -1) * MovingSpeed * Time.deltaTime;
        }
        else if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += new Vector3(-1, 0, 0) * MovingSpeed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += new Vector3(1, 0, 0) * MovingSpeed * Time.deltaTime;
        }
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
            float GottenScore = PotentialScoreTimer;
            /*Vector3 CollisionDirection = collision.contacts[0].normal;
            playerRB.AddForce(-CollisionDirection * Force, ForceMode.Impulse);*/
        }
    }
}
