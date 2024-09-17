using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnOne : MonoBehaviour
{
    public GameObject Seaweed;
    // Start is called before the first frame update
    void Start()
    {
        float spawnX = PlayerPrefs.GetFloat("SeaweedXOne", 0);
        float spawnY = PlayerPrefs.GetFloat("SeaweedYOne", 0);
        float spawnZ = PlayerPrefs.GetFloat("SeaweedZOne", 0);
        Vector3 spawnPosition = new Vector3(spawnX, spawnY, spawnZ);

        Instantiate(Seaweed, spawnPosition, Quaternion.identity);

        DontDestroyOnLoad(Seaweed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
