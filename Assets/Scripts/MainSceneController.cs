using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainSceneController : MonoBehaviour
{
    public static GameObject gameObjectOne;
    public static GameObject gameObjectTwo;
    public static GameObject gameObjectThree;
    public static GameObject gameObjectFour;
    public static GameObject gameObjectFive;
    public static GameObject gameObjectSix;
    public static GameObject gameObjectSeven;
    public static GameObject gameObjectEight;
    public static GameObject Seaweed;
    // Start is called before the first frame update
    void Start()
    {
        gameObjectOne = GameObject.FindGameObjectWithTag("One");
        gameObjectTwo = GameObject.FindGameObjectWithTag("Two");
        gameObjectThree = GameObject.FindGameObjectWithTag("Three");
        gameObjectFour = GameObject.FindGameObjectWithTag("Four");
        gameObjectFive = GameObject.FindGameObjectWithTag("Five");
        gameObjectSix = GameObject.FindGameObjectWithTag("Six");
        gameObjectSeven = GameObject.FindGameObjectWithTag("Seven");
        gameObjectEight = GameObject.FindGameObjectWithTag("Eight");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
