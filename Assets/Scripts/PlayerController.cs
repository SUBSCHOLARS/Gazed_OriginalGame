using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private GameObject mainCamera;
    [SerializeField] private GameObject playerModel;
    float MovingSpeed = 25f;
    float VerticalMovingSpeed = 15f;
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
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 cameraForward = Vector3.Scale(mainCamera.transform.forward, new Vector3(1, 0, 1)).normalized;
        Vector3 cameraRight = Vector3.Scale(mainCamera.transform.right, new Vector3(1, 0, 1)).normalized;
        Vector3 moveDirection = (cameraForward * verticalInput + cameraRight * horizontalInput).normalized;
        transform.position += moveDirection * Time.deltaTime * MovingSpeed;
        if (moveDirection != Vector3.zero)
        {
            playerModel.transform.rotation = Quaternion.LookRotation(moveDirection);
        }
        if(Input.GetMouseButton(0))
        {
            playerModel.transform.position += Vector3.down * VerticalMovingSpeed * Time.deltaTime;
        }
        else if(Input.GetMouseButton(1))
        {
            playerModel.transform.position += Vector3.up * VerticalMovingSpeed * Time.deltaTime;
        }
    }
}
