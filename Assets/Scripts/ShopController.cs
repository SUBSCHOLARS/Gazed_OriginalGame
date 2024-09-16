using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShopController : MonoBehaviour
{
    public Button BuyButton;
    public Camera MainCamera;
    public Button ResurviveButton;
    public Button ZoomInButton;
    public Button ZoomOutButton;
    public GameObject EventSystem;
    private Vector3 randomPosition;
    public GameObject Activator;
    public GameObject Text1;
    public GameObject Text2;
    public GameObject Text3;
    public GameObject Text4;
    public GameObject SeaweedForDisplay;
    public static int CountSeaweed = 0;
    float smoothedSpeed = 0.125f;
    Vector3 initialCameraPosition = new Vector3(0, 1, -10);
    Vector3 finalCameraPosition = new Vector3(4, 300, -100);
    // Start is called before the first frame update
    void Start()
    {
        ResurviveButton.gameObject.SetActive(false);
        BuyButton.onClick.AddListener(OnBuyButtonClicked);
        ResurviveButton.onClick.AddListener(OnResurviveButtonClicked);
        ZoomInButton.onClick.AddListener(OnZoomInButtonClicked);
        ZoomOutButton.onClick.AddListener(OnZoomOutButtonClicked);
    }

    // Update is called once per frame
    void Update()
    {
        if(MainCamera.gameObject.transform.position == finalCameraPosition)
        {
            if(Input.GetKey(KeyCode.W))
            {
                MainCamera.gameObject.transform.position += new Vector3(0, 0, 10);
            }
            if(Input.GetKey(KeyCode.S))
            {
                MainCamera.gameObject.transform.position += new Vector3(0, 0, -10);
            }
            if(Input.GetKey(KeyCode.A))
            {
                MainCamera.gameObject.transform.position += new Vector3(-10, 0, 0);
            }
            if(Input.GetKey(KeyCode.D))
            {
                MainCamera.gameObject.transform.position += new Vector3(10, 0, 0);
            }
            if(Input.GetMouseButtonDown(0))
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit, Mathf.Infinity))
                {
                    Vector3 spawnPosition = hit.point;
                    Instantiate(MainSceneController.Seaweed, spawnPosition, Quaternion.identity);
                }
            }
            
        }
        else
        {
            return;
        }
    }

    void OnBuyButtonClicked()
    {
        /*randomPosition = new Vector3(Random.Range(-50, 50), 0, Random.Range(-50, 50));

        PlayerPrefs.SetFloat("SeaweedX", randomPosition.x);
        PlayerPrefs.SetFloat("SeaweedY", randomPosition.y);
        PlayerPrefs.SetFloat("SeaweedZ", randomPosition.z);*/

        SceneManager.LoadScene("Main", LoadSceneMode.Additive);
        Time.timeScale = 0;
        ResurviveButton.gameObject.SetActive(true);
        ZoomInButton.gameObject.SetActive(true);
        ZoomOutButton.gameObject.SetActive(true);
        Text1.SetActive(false);
        Text2.SetActive(false);
        Text3.SetActive(false);
        Text4.SetActive(false);
        EventSystem.SetActive(false);
        SeaweedForDisplay.SetActive(false);
        MainCamera.gameObject.transform.position = Vector3.Lerp(initialCameraPosition, finalCameraPosition, smoothedSpeed);
        MainCamera.gameObject.transform.Rotate(90, 0, 0);
        Activator.SendMessage("MainMainCameraDeactivate");
    }
    void OnResurviveButtonClicked()
    {
        CountSeaweed++;
        SceneManager.LoadScene("Main");
        Time.timeScale = 1;
    }
    void OnZoomInButtonClicked()
    {
        MainCamera.gameObject.transform.position += new Vector3(0, -10, 0) * Time.deltaTime;
    }
    void OnZoomOutButtonClicked()
    {
        MainCamera.gameObject.transform.position += new Vector3(0, 10, 0) * Time.deltaTime;
    }
}
