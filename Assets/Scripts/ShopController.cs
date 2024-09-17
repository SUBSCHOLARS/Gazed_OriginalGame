using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShopController : MonoBehaviour
{
    public Button BuyButton;
    public GameObject SelectCanvas;
    public Button[] Buttons = new Button[8];
    public Button ResurviveButton;
    public Text ScoreText;
    public static int CountSeaweed = 0;
    private Vector3[] VectorArray = {
        new Vector3(-100, 0, 0),
        new Vector3(0, 0, 0),
        new Vector3(100, 0, 0),
        new Vector3(100, 0, -100),
        new Vector3(100, 0, -200),
        new Vector3(0, 0, -200),
        new Vector3(-100, 0, -200),
        new Vector3(-100, 0, -100)
    };
    // Start is called before the first frame update
    void Start()
    {
        //BuyButton.onClick.AddListener(OnBuyButtonClicked);
        //ResurviveButton.onClick.AddListener(OnResurviveButtonClicked);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnBuyButtonClicked()
    {
        ResurviveButton.gameObject.SetActive(true);
        SelectCanvas.SetActive(true);
        for(int i = 0; i < Buttons.Length; i++)
        {
            Buttons[i].gameObject.SetActive(true);
        }
    }
    public void OnOneVectorButtonClicked()
    {
        PlayerPrefs.SetFloat("SeaweedXOne", VectorArray[0].x);
        PlayerPrefs.SetFloat("SeaweedYOne", VectorArray[0].y);
        PlayerPrefs.SetFloat("SeaweedZOne", VectorArray[0].z);
        MainSceneController.gameObjectOne.SetActive(true);
    }
    public void OnTwoVectorButtonClicked()
    {
        PlayerPrefs.SetFloat("SeaweedXTwo", VectorArray[1].x);
        PlayerPrefs.SetFloat("SeaweedYTwo", VectorArray[1].y);
        PlayerPrefs.SetFloat("SeaweedZTwo", VectorArray[1].z);
        MainSceneController.gameObjectTwo.SetActive(true);
    }
    public void OnThreeVectorButtonClicked()
    {
        PlayerPrefs.SetFloat("SeaweedXThree", VectorArray[2].x);
        PlayerPrefs.SetFloat("SeaweedYThree", VectorArray[2].y);
        PlayerPrefs.SetFloat("SeaweedZThree", VectorArray[2].z);
        MainSceneController.gameObjectThree.SetActive(true);
    }
    public void OnFourVectorButtonClicked()
    {
        PlayerPrefs.SetFloat("SeaweedXFour", VectorArray[3].x);
        PlayerPrefs.SetFloat("SeaweedYFour", VectorArray[3].y);
        PlayerPrefs.SetFloat("SeaweedZFour", VectorArray[3].z);
        MainSceneController.gameObjectFour.SetActive(true);
    }
    public void OnFiveVectorButtonClicked()
    {
        PlayerPrefs.SetFloat("SeaweedXFive", VectorArray[4].x);
        PlayerPrefs.SetFloat("SeaweedYFive", VectorArray[4].y);
        PlayerPrefs.SetFloat("SeaweedZFive", VectorArray[4].z);
        MainSceneController.gameObjectFive.SetActive(true);
    }
    public void OnSixVectorButtonClicked()
    {
        PlayerPrefs.SetFloat("SeaweedXSix", VectorArray[5].x);
        PlayerPrefs.SetFloat("SeaweedYSix", VectorArray[5].y);
        PlayerPrefs.SetFloat("SeaweedZSix", VectorArray[5].z);
        MainSceneController.gameObjectSix.SetActive(true);
    }
    public void OnSevenVectorButtonClicked()
    {
        PlayerPrefs.SetFloat("SeaweedXSeven", VectorArray[6].x);
        PlayerPrefs.SetFloat("SeaweedYSeven", VectorArray[6].y);
        PlayerPrefs.SetFloat("SeaweedZSeven", VectorArray[6].z);
        MainSceneController.gameObjectSeven.SetActive(true);
    }
    public void OnEightVectorButtonClicked()
    {
        PlayerPrefs.SetFloat("SeaweedXEight", VectorArray[7].x);
        PlayerPrefs.SetFloat("SeaweedYEight", VectorArray[7].y);
        PlayerPrefs.SetFloat("SeaweedZEight", VectorArray[7].z);
        MainSceneController.gameObjectEight.SetActive(true);
    }

    void OnResurviveButtonClicked()
    {
        CountSeaweed++;
        SceneManager.LoadScene("Main");
    }
}
