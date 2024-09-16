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
    public float rayDistance = 100f;
    public GameObject SeaWeed;
    private Camera subMainCamera;
    Vector3 finalCameraPosition = new Vector3(4, 300, -100);
    // Start is called before the first frame update
    void Start()
    {
        GameObject cameraObject = GameObject.FindWithTag("SubMainCamera");
        if(cameraObject != null)
        {
            subMainCamera = cameraObject.GetComponent<Camera>();
        }
        ResurviveButton.gameObject.SetActive(false);
        BuyButton.onClick.AddListener(OnBuyButtonClicked);
        ResurviveButton.onClick.AddListener(OnResurviveButtonClicked);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnBuyButtonClicked()
    {
        /*randomPosition = new Vector3(Random.Range(-50, 50), 0, Random.Range(-50, 50));

        PlayerPrefs.SetFloat("SeaweedX", randomPosition.x);
        PlayerPrefs.SetFloat("SeaweedY", randomPosition.y);
        PlayerPrefs.SetFloat("SeaweedZ", randomPosition.z);*/

        SceneManager.LoadScene("SampleMain");
        ResurviveButton.gameObject.SetActive(true);
    }

    void OnResurviveButtonClicked()
    {
        CountSeaweed++;
        SceneManager.LoadScene("Main");
    }
}
