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
    public GameObject[] gameObjects = new GameObject[8];
    public Button ResurviveButton;
    public Text ScoreText;
    public static int CountSeaweed = 0;
    private Vector3[] VectorArray = {
        new Vector3(-100, 10, 0),
        new Vector3(0, 10, 0),
        new Vector3(100, 10, 0),
        new Vector3(100, 10, -100),
        new Vector3(100, 10, -200),
        new Vector3(0, 10, -200),
        new Vector3(-100, 10, -200),
        new Vector3(-100, 10, -100)
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

    public void OnBuyButtonClicked()
    {
        ResurviveButton.gameObject.SetActive(true);
        SelectCanvas.SetActive(true);
        for(int i = 0; i < Buttons.Length; i++)
        {
            Buttons[i].gameObject.SetActive(true);
        }
    }
    public void OnOneVectorButtonClicked(string buttonOne)
    {
        Vector3 spawnPosOne = new Vector3(-100, 10, 0);
        PlayerPrefs.SetFloat("SeaweedXOne", spawnPosOne.x);
        PlayerPrefs.SetFloat("SeaweedYOne", spawnPosOne.y);
        PlayerPrefs.SetFloat("SeaweedZOne", spawnPosOne.z);
        Debug.Log("Saved Location");
        gameObjects[0].SetActive(true);
        PlayerPrefs.SetString("Button", buttonOne);
        Debug.Log("Saved Button");
        //MainSceneController.gameObjectOne.SetActive(true);
    }
    public void OnTwoVectorButtonClicked(string buttonTwo)
    {
        PlayerPrefs.SetFloat("SeaweedXTwo", VectorArray[1].x);
        PlayerPrefs.SetFloat("SeaweedYTwo", VectorArray[1].y);
        PlayerPrefs.SetFloat("SeaweedZTwo", VectorArray[1].z);
        PlayerPrefs.SetString("Button", buttonTwo);
        //MainSceneController.gameObjectTwo.SetActive(true);
    }
    public void OnThreeVectorButtonClicked(string buttonThree)
    {
        PlayerPrefs.SetFloat("SeaweedXThree", VectorArray[2].x);
        PlayerPrefs.SetFloat("SeaweedYThree", VectorArray[2].y);
        PlayerPrefs.SetFloat("SeaweedZThree", VectorArray[2].z);
        PlayerPrefs.SetString("Button", buttonThree);
        //MainSceneController.gameObjectThree.SetActive(true);
    }
    public void OnFourVectorButtonClicked(string buttonFour)
    {
        PlayerPrefs.SetFloat("SeaweedXFour", VectorArray[3].x);
        PlayerPrefs.SetFloat("SeaweedYFour", VectorArray[3].y);
        PlayerPrefs.SetFloat("SeaweedZFour", VectorArray[3].z);
        PlayerPrefs.SetString("Button", buttonFour);
        //MainSceneController.gameObjectFour.SetActive(true);
    }
    public void OnFiveVectorButtonClicked(string buttonFive)
    {
        PlayerPrefs.SetFloat("SeaweedXFive", VectorArray[4].x);
        PlayerPrefs.SetFloat("SeaweedYFive", VectorArray[4].y);
        PlayerPrefs.SetFloat("SeaweedZFive", VectorArray[4].z);
        PlayerPrefs.SetString("Button", buttonFive);
        //MainSceneController.gameObjectFive.SetActive(true);
    }
    public void OnSixVectorButtonClicked(string buttonSix)
    {
        PlayerPrefs.SetFloat("SeaweedXSix", VectorArray[5].x);
        PlayerPrefs.SetFloat("SeaweedYSix", VectorArray[5].y);
        PlayerPrefs.SetFloat("SeaweedZSix", VectorArray[5].z);
        PlayerPrefs.SetString("Button", buttonSix);
        //MainSceneController.gameObjectSix.SetActive(true);
    }
    public void OnSevenVectorButtonClicked(string buttonSeven)
    {
        PlayerPrefs.SetFloat("SeaweedXSeven", VectorArray[6].x);
        PlayerPrefs.SetFloat("SeaweedYSeven", VectorArray[6].y);
        PlayerPrefs.SetFloat("SeaweedZSeven", VectorArray[6].z);
        PlayerPrefs.SetString("Button", buttonSeven);
        //MainSceneController.gameObjectSeven.SetActive(true);
    }
    public void OnEightVectorButtonClicked(string buttonEight)
    {
        PlayerPrefs.SetFloat("SeaweedXEight", VectorArray[7].x);
        PlayerPrefs.SetFloat("SeaweedYEight", VectorArray[7].y);
        PlayerPrefs.SetFloat("SeaweedZEight", VectorArray[7].z);
        PlayerPrefs.SetString("Button", buttonEight);
        //MainSceneController.gameObjectEight.SetActive(true);
    }

    public void OnResurviveButtonClicked()
    {
        //CountSeaweed++;
        SceneManager.LoadScene("Main");
    }
}
