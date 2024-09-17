using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainSceneController : MonoBehaviour
{
    public GameObject gameObjectOne;
    public GameObject gameObjectTwo;
    public GameObject gameObjectThree;
    public GameObject gameObjectFour;
    public GameObject gameObjectFive;
    public GameObject gameObjectSix;
    public GameObject gameObjectSeven;
    public GameObject gameObjectEight;
    // Start is called before the first frame update
    void Start()
    {
        /*gameObjectOne = GameObject.FindGameObjectWithTag("One");
        gameObjectTwo = GameObject.FindGameObjectWithTag("Two");
        gameObjectThree = GameObject.FindGameObjectWithTag("Three");
        gameObjectFour = GameObject.FindGameObjectWithTag("Four");
        gameObjectFive = GameObject.FindGameObjectWithTag("Five");
        gameObjectSix = GameObject.FindGameObjectWithTag("Six");
        gameObjectSeven = GameObject.FindGameObjectWithTag("Seven");
        gameObjectEight = GameObject.FindGameObjectWithTag("Eight");*/

        string SelectedButton = PlayerPrefs.GetString("Button");
        switch(SelectedButton)
        {
            case "buttonOne":
                gameObjectOne.SetActive(true);
                Debug.Log("ActiveOne");
            break;
            case "buttonTwo":
                gameObjectTwo.SetActive(true);
            break;
            case "buttonThree":
                gameObjectThree.SetActive(true);
            break;
            case "buttonFour":
                gameObjectFour.SetActive(true);
            break;
            case "buttonFive":
                gameObjectFive.SetActive(true);
            break;
            case "buttonSix":
                gameObjectSix.SetActive(true);
            break;
            case "buttonSeven":
                gameObjectSeven.SetActive(true);
            break;
            case "buttonEight":
                gameObjectEight.SetActive(true);
            break;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
