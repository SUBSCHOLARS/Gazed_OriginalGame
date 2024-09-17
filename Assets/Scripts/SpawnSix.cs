using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSix : MonoBehaviour
{
    public GameObject Seaweed;
    // Start is called before the first frame update
    void Start()
    {
        float spawnX = PlayerPrefs.GetFloat("SeaweedXSix", 0);
        float spawnY = PlayerPrefs.GetFloat("SeaweedYSix", 0);
        float spawnZ = PlayerPrefs.GetFloat("SeaweedZSix", 0);
        Vector3 spawnPosition = new Vector3(spawnX, spawnY, spawnZ);

        Instantiate(Seaweed, spawnPosition, Quaternion.identity);

        DontDestroyOnLoad(Seaweed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
