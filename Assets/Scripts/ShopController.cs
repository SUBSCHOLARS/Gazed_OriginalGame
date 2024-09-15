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

        ResurviveButton.gameObject.SetActive(true);
    }

    void OnResurviveButtonClicked()
    {
        SceneManager.LoadScene("Main");
    }
}
