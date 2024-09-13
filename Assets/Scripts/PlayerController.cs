using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private GameObject playerModel;
    float MovingSpeed = 20f;
    float VerticalMovingSpeed = 15f;
    float Force = 10f;
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
        float horizontalMove = Input.GetAxis("Horizontal");
        float verticalMove = Input.GetAxis("Vertical");

        this.gameObject.transform.position += new Vector3(horizontalMove * MovingSpeed * Time.deltaTime, 0, verticalMove * MovingSpeed * Time.deltaTime);

        if(Input.GetMouseButton(0))
        {
            playerModel.transform.position += Vector3.down * VerticalMovingSpeed * Time.deltaTime;
        }
        else if(Input.GetMouseButton(1))
        {
            playerModel.transform.position += Vector3.up * VerticalMovingSpeed * Time.deltaTime;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Cat"))
        {
            Vector3 CollisionDirection = collision.contacts[0].normal;
            playerRB.AddForce(-CollisionDirection * Force, ForceMode.Impulse);
        }
    }
}
