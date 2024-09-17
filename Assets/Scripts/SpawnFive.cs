using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFive : MonoBehaviour
{
    public GameObject Seaweed;
    // Start is called before the first frame update
    void Start()
    {
        float spawnX = PlayerPrefs.GetFloat("SeaweedXFive", 0);
        float spawnY = PlayerPrefs.GetFloat("SeaweedYFive", 0);
        float spawnZ = PlayerPrefs.GetFloat("SeaweedZFive", 0);
        Vector3 spawnPosition = new Vector3(spawnX, spawnY, spawnZ);

        Instantiate(Seaweed, spawnPosition, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
