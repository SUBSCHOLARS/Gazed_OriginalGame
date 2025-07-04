using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShopController : MonoBehaviour
{
    public Button BuyButton;
    public Text SeaweedText;
    private string[] SeaweedLine = {"冷やかしは返りな！！",
                                    "この世は金がすべてだぜ",
                                    "持ってない奴は\n搾取されるしかない",
                                    "こっちにも生活ってのが\nあるんで",
                                    "お引き取り下さい"
    };
    public GameObject SelectCanvas;
    public Button[] Buttons = new Button[8];
    public GameObject[] gameObjects = new GameObject[8];
    public Button ResurviveButton;
    public Button TitleButton;
    
    public Text AccumulatedScore;
    // Start is called before the first frame update
    void Start()
    {
        int shopTokens = PlayerPrefs.GetInt("shopToken", 0);
        Debug.Log("値を引き継いで代入");
        AccumulatedScore.text = shopTokens.ToString("0000");
        Debug.Log("その値を表示");
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnBuyButtonClicked()
    {
        int shopTokens = PlayerPrefs.GetInt("shopToken", 0);
        if(shopTokens > 200)
        {
            int shopTokensYay = PlayerPrefs.GetInt("shopToken", 0);
            shopTokensYay -= 200;
            ShopCurrencyHandler.ShopCurrencyYay -= 200;
            //AccumulatedScore.text = shopTokens.ToString("0000");
            //int ShopToken = (int)SurvivalTimeController.ScorePotentialTimer + (int)SurivivalTimeController300.ScorePotentialTimer + (int)SurvivalTimeController500.ScorePotentialTimer;
            //ShopToken -= 200;
            PlayerPrefs.SetInt("shopToken", shopTokensYay);
            Debug.Log("保存されている値を更新しました");
            int ModifiedShopToken = PlayerPrefs.GetInt("shopToken", 0);
            Debug.Log("その値を取得しました");
            AccumulatedScore.text = ModifiedShopToken.ToString("0000");
            ResurviveButton.gameObject.SetActive(true);
            SelectCanvas.SetActive(true);
            for(int i = 0; i < Buttons.Length; i++)
            {
                Buttons[i].gameObject.SetActive(true);
            }
        }
        else
        {
            SeaweedText.text = SeaweedLine[Random.Range(0, SeaweedLine.Length - 1)];
            TitleButton.gameObject.SetActive(true);
        }
        AudioSource audioSource = GetComponent<AudioSource>();
        audioSource.Play();
    }
    public void OnOneVectorButtonClicked(string buttonOne)
    {
        Vector3 spawnPosOne = new Vector3(-100, 17.2f, 0);
        PlayerPrefs.SetFloat("SeaweedXOne", spawnPosOne.x);
        PlayerPrefs.SetFloat("SeaweedYOne", spawnPosOne.y);
        PlayerPrefs.SetFloat("SeaweedZOne", spawnPosOne.z);
        Debug.Log("Saved Location");
        //gameObjects[0].SetActive(true);
        PlayerPrefs.SetString("Button", "buttonOne");
        Debug.Log("Saved Button");
        //MainSceneController.gameObjectOne.SetActive(true);
        AudioSource audioSource = GetComponent<AudioSource>();
        audioSource.Play();
    }
    public void OnTwoVectorButtonClicked(string buttonTwo)
    {
        Vector3 spawnPosTwo = new Vector3(0, 17.2f, 0);
        PlayerPrefs.SetFloat("SeaweedXTwo", spawnPosTwo.x);
        PlayerPrefs.SetFloat("SeaweedYTwo", spawnPosTwo.y);
        PlayerPrefs.SetFloat("SeaweedZTwo", spawnPosTwo.z);
        Debug.Log("Saved Location");
        //gameObjects[1].SetActive(true);
        PlayerPrefs.SetString("Button", "buttonTwo");
        Debug.Log("Saved Button");
        //MainSceneController.gameObjectTwo.SetActive(true);
        AudioSource audioSource = GetComponent<AudioSource>();
        audioSource.Play();
    }
    public void OnThreeVectorButtonClicked(string buttonThree)
    {
        Vector3 spawwnPosThree = new Vector3(100, 17.2f, 0);
        PlayerPrefs.SetFloat("SeaweedXThree", spawwnPosThree.x);
        PlayerPrefs.SetFloat("SeaweedYThree", spawwnPosThree.y);
        PlayerPrefs.SetFloat("SeaweedZThree", spawwnPosThree.z);
        //gameObjects[2].SetActive(true);
        PlayerPrefs.SetString("Button", "buttonThree");
        //MainSceneController.gameObjectThree.SetActive(true);
        AudioSource audioSource = GetComponent<AudioSource>();
        audioSource.Play();
    }
    public void OnFourVectorButtonClicked(string buttonFour)
    {
        Vector3 spawnPosFour = new Vector3(100, 17.2f, -100);
        PlayerPrefs.SetFloat("SeaweedXFour", spawnPosFour.x);
        PlayerPrefs.SetFloat("SeaweedYFour", spawnPosFour.y);
        PlayerPrefs.SetFloat("SeaweedZFour", spawnPosFour.z);
        //gameObjects[3].SetActive(true);
        PlayerPrefs.SetString("Button", buttonFour);
        //MainSceneController.gameObjectFour.SetActive(true);
        AudioSource audioSource = GetComponent<AudioSource>();
        audioSource.Play();
    }
    public void OnFiveVectorButtonClicked(string buttonFive)
    {
        Vector3 spawnPosFive = new Vector3(100, 17.2f, -200);
        PlayerPrefs.SetFloat("SeaweedXFive", spawnPosFive.x);
        PlayerPrefs.SetFloat("SeaweedYFive", spawnPosFive.y);
        PlayerPrefs.SetFloat("SeaweedZFive", spawnPosFive.z);
        //gameObjects[4].SetActive(true);
        PlayerPrefs.SetString("Button", buttonFive);
        //MainSceneController.gameObjectFive.SetActive(true);
        AudioSource audioSource = GetComponent<AudioSource>();
        audioSource.Play();
    }
    public void OnSixVectorButtonClicked(string buttonSix)
    {
        Vector3 spawnPosSix = new Vector3(0, 17.2f, -200);
        PlayerPrefs.SetFloat("SeaweedXSix", spawnPosSix.x);
        PlayerPrefs.SetFloat("SeaweedYSix", spawnPosSix.y);
        PlayerPrefs.SetFloat("SeaweedZSix", spawnPosSix.z);
        //gameObjects[5].SetActive(true);
        PlayerPrefs.SetString("Button", buttonSix);
        //MainSceneController.gameObjectSix.SetActive(true);
        AudioSource audioSource = GetComponent<AudioSource>();
        audioSource.Play();
    }
    public void OnSevenVectorButtonClicked(string buttonSeven)
    {
        Vector3 spawnPosSeven = new Vector3(-100, 17.2f, -200);
        PlayerPrefs.SetFloat("SeaweedXSeven", spawnPosSeven.x);
        PlayerPrefs.SetFloat("SeaweedYSeven", spawnPosSeven.y);
        PlayerPrefs.SetFloat("SeaweedZSeven", spawnPosSeven.z);
        //gameObjects[6].SetActive(true);
        PlayerPrefs.SetString("Button", buttonSeven);
        //MainSceneController.gameObjectSeven.SetActive(true);
        AudioSource audioSource = GetComponent<AudioSource>();
        audioSource.Play();
    }
    public void OnEightVectorButtonClicked(string buttonEight)
    {
        Vector3 spawnPosEight = new Vector3(-100, 17.2f, -100);
        PlayerPrefs.SetFloat("SeaweedXEight", spawnPosEight.x);
        PlayerPrefs.SetFloat("SeaweedYEight", spawnPosEight.y);
        PlayerPrefs.SetFloat("SeaweedZEight", spawnPosEight.z);
        //gameObjects[7].SetActive(true);
        PlayerPrefs.SetString("Button", buttonEight);
        //MainSceneController.gameObjectEight.SetActive(true);
        AudioSource audioSource = GetComponent<AudioSource>();
        audioSource.Play();
    }

    public void OnResurviveButtonClicked()
    {
        string currentSceneName = SceneManager.GetActiveScene().name;
        switch(currentSceneName)
            {
                case "Shop":
                    SceneManager.LoadScene("Main");
                    break;
                case "Shop300":
                    SceneManager.LoadScene("Main300");
                    break;
                case "Shop500":
                    SceneManager.LoadScene("Main500");
                    break;
                default:
                    return;
            }
        AudioSource audioSource = GetComponent<AudioSource>();
        audioSource.Play();
    }
}
