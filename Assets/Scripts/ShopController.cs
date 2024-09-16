using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShopController : MonoBehaviour
{
    public Button BuyButton;
    public Button ResurviveButton;
    private Vector3 randomPosition;
    public GameObject Text1;
    public GameObject Text2;
    public GameObject Text3;
    public GameObject Text4;
    public GameObject SeaweedForDisplay;
    // Start is called before the first frame update
    void Start()
    {
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
        randomPosition = new Vector3(Random.Range(-50, 50), 0, Random.Range(-50, 50));

        PlayerPrefs.SetFloat("SeaweedX", randomPosition.x);
        PlayerPrefs.SetFloat("SeaweedY", randomPosition.y);
        PlayerPrefs.SetFloat("SeaweedZ", randomPosition.z);

        SceneManager.LoadScene("Main", LoadSceneMode.Additive);
        Time.timeScale = 0;
        ResurviveButton.gameObject.SetActive(true);
        Text1.SetActive(false);
        Text2.SetActive(false);
        Text3.SetActive(false);
        Text4.SetActive(false);
        SeaweedForDisplay.SetActive(false);

    }

    void OnResurviveButtonClicked()
    {
        MainSceneController.CountSeaweed++;
        SceneManager.LoadScene("Main");
        Time.timeScale = 1;
    }
}
