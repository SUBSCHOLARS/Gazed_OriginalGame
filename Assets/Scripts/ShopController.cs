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
    public static float accumulatedScores = 0;
    public static float accumulatedScore;
    public Text AccumulatedScore;
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
        accumulatedScore = PlayerPrefs.GetFloat("SurvivedScore", 0f);
        accumulatedScores += accumulatedScore;
        AccumulatedScore.text = accumulatedScore.ToString("0000");
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
        Vector3 spawnPosTwo = new Vector3(0, 10, 0);
        PlayerPrefs.SetFloat("SeaweedXTwo", spawnPosTwo.x);
        PlayerPrefs.SetFloat("SeaweedYTwo", spawnPosTwo.y);
        PlayerPrefs.SetFloat("SeaweedZTwo", spawnPosTwo.z);
        Debug.Log("Saved Location");
        gameObjects[1].SetActive(true);
        PlayerPrefs.SetString("Button", buttonTwo);
        Debug.Log("Saved Button");
        //MainSceneController.gameObjectTwo.SetActive(true);
    }
    public void OnThreeVectorButtonClicked(string buttonThree)
    {
        Vector3 spawwnPosThree = new Vector3(100, 10, 0);
        PlayerPrefs.SetFloat("SeaweedXThree", spawwnPosThree.x);
        PlayerPrefs.SetFloat("SeaweedYThree", spawwnPosThree.y);
        PlayerPrefs.SetFloat("SeaweedZThree", spawwnPosThree.z);
        gameObjects[2].SetActive(true);
        PlayerPrefs.SetString("Button", buttonThree);
        //MainSceneController.gameObjectThree.SetActive(true);
    }
    public void OnFourVectorButtonClicked(string buttonFour)
    {
        Vector3 spawnPosFour = new Vector3(100, 10, -100);
        PlayerPrefs.SetFloat("SeaweedXFour", spawnPosFour.x);
        PlayerPrefs.SetFloat("SeaweedYFour", spawnPosFour.y);
        PlayerPrefs.SetFloat("SeaweedZFour", spawnPosFour.z);
        gameObjects[3].SetActive(true);
        PlayerPrefs.SetString("Button", buttonFour);
        //MainSceneController.gameObjectFour.SetActive(true);
    }
    public void OnFiveVectorButtonClicked(string buttonFive)
    {
        Vector3 spawnPosFive = new Vector3(100, 10, -200);
        PlayerPrefs.SetFloat("SeaweedXFive", spawnPosFive.x);
        PlayerPrefs.SetFloat("SeaweedYFive", spawnPosFive.y);
        PlayerPrefs.SetFloat("SeaweedZFive", spawnPosFive.z);
        gameObjects[4].SetActive(true);
        PlayerPrefs.SetString("Button", buttonFive);
        //MainSceneController.gameObjectFive.SetActive(true);
    }
    public void OnSixVectorButtonClicked(string buttonSix)
    {
        Vector3 spawnPosSix = new Vector3(0, 10, -200);
        PlayerPrefs.SetFloat("SeaweedXSix", spawnPosSix.x);
        PlayerPrefs.SetFloat("SeaweedYSix", spawnPosSix.y);
        PlayerPrefs.SetFloat("SeaweedZSix", spawnPosSix.z);
        gameObjects[5].SetActive(true);
        PlayerPrefs.SetString("Button", buttonSix);
        //MainSceneController.gameObjectSix.SetActive(true);
    }
    public void OnSevenVectorButtonClicked(string buttonSeven)
    {
        Vector3 spawnPosSeven = new Vector3(-100, 10, -200);
        PlayerPrefs.SetFloat("SeaweedXSeven", spawnPosSeven.x);
        PlayerPrefs.SetFloat("SeaweedYSeven", spawnPosSeven.y);
        PlayerPrefs.SetFloat("SeaweedZSeven", spawnPosSeven.z);
        gameObjects[6].SetActive(true);
        PlayerPrefs.SetString("Button", buttonSeven);
        //MainSceneController.gameObjectSeven.SetActive(true);
    }
    public void OnEightVectorButtonClicked(string buttonEight)
    {
        Vector3 spawnPosEight = new Vector3(-100, 10, -100);
        PlayerPrefs.SetFloat("SeaweedXEight", spawnPosEight.x);
        PlayerPrefs.SetFloat("SeaweedYEight", spawnPosEight.y);
        PlayerPrefs.SetFloat("SeaweedZEight", spawnPosEight.z);
        gameObjects[7].SetActive(true);
        PlayerPrefs.SetString("Button", buttonEight);
        //MainSceneController.gameObjectEight.SetActive(true);
    }

    public void OnResurviveButtonClicked()
    {
        //CountSeaweed++;
        SceneManager.LoadScene("Main");
    }
}
