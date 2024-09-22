using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFour : MonoBehaviour
{
    public GameObject Seaweed;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(Seaweed);
        float spawnX = PlayerPrefs.GetFloat("SeaweedXFour", 0);
        float spawnY = PlayerPrefs.GetFloat("SeaweedYFour", 0);
        float spawnZ = PlayerPrefs.GetFloat("SeaweedZFour", 0);
        Vector3 spawnPosition = new Vector3(spawnX, spawnY, spawnZ);

        Instantiate(Seaweed, spawnPosition, Quaternion.identity);
        Debug.Log("Spawned!!!!!!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
