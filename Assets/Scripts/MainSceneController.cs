using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainSceneController : MonoBehaviour
{
    public GameObject Seaweed;
    public static int CountSeaweed = 0;
    // Start is called before the first frame update
    void Start()
    {
        float seaweedX = PlayerPrefs.GetFloat("SeaweedX", 0);
        float seaweedY = PlayerPrefs.GetFloat("SeaweedY", 0);
        float seaweedZ = PlayerPrefs.GetFloat("SeaweedZ", 0);

        Vector3 seaweedPosition = new Vector3(seaweedX, seaweedY, seaweedZ);
        if(CountSeaweed <= 3 && CountSeaweed > 0)
        {
            Instantiate(Seaweed, seaweedPosition, Quaternion.identity);
            DontDestroyOnLoad(Seaweed);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
