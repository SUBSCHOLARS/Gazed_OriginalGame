using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject[] catPrefabs = new GameObject[7];
    private Vector3[] VectorArray = new Vector3[8];
    public static float timer = 0;
    int LimitedCatPopulation = 20;
    // Start is called before the first frame update
    void Start()
    {

        for (int i = 0; i < VectorArray.Length; i++)
        {
            if(i == 0)
            {
                VectorArray[i] = new Vector3(Random.Range(-130, 130), Random.Range(-1, 20), 60.5f); 
            }
            else if(i == 1)
            {
                VectorArray[i] = new Vector3(Random.Range(-130, 130), Random.Range(-7, 20), -260.5f);
            }
            else if(i == 2)
            {
                VectorArray[i] = new Vector3(-160.5f, Random.Range(-1, 20), Random.Range(-230, 30));
            }
            else if(i == 3)
            {
                VectorArray[i] = new Vector3(160.5f, Random.Range(-1, 20), Random.Range(-230, 30));
            }
            else if(i == 4)
            {
                VectorArray[i] = new Vector3(160.5f, Random.Range(-1, 20), Random.Range(-230,30));
            }
            else if(i == 5)
            {
                VectorArray[i] = new Vector3(Random.Range(-30, 30), Random.Range(-1, 20), -60);
            }
            else if(i == 6)
            {
                VectorArray[i] = new Vector3(Random.Range(-30, 30), Random.Range(-1, 20), -130);
            }
            else if(i == 7)
            {
                VectorArray[i] = new Vector3(-30, Random.Range(-1, 20), Random.Range(-120, -60));
            }
            else if(i == 8)
            {
                VectorArray[i] = new Vector3(30, Random.Range(-1, 20), Random.Range(-120, -60));
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        GameObject[] catObjects = GameObject.FindGameObjectsWithTag("Cat");
        int catNumber = catObjects.Length;

        int randomIndex = Random.Range(0, VectorArray.Length - 1);
        GameObject randomCat = catPrefabs[Random.Range(0, catPrefabs.Length)];

        if(catNumber == 0 || catNumber < LimitedCatPopulation)
        {
            GameObject spawnCat = Instantiate(randomCat, VectorArray[randomIndex], transform.rotation);
            if(randomIndex == 0)
            {
                return;
            }
            else if(randomIndex == 1)
            {
                spawnCat.transform.Rotate(0, 180, 0);
            }
            else if(randomIndex == 2)
            {
                spawnCat.transform.Rotate(0, -90, 0);
            }
            else if(randomIndex == 3)
            {
                spawnCat.transform.Rotate(0, 90, 0);
            }
            else if(randomIndex == 4)
            {
                spawnCat.transform.Rotate(0, 90, 0);
            }
            else if(randomIndex == 5)
            {
                spawnCat.transform.Rotate(0, 180, 0);
            }
            else if(randomIndex == 6)
            {
                return;
            }
            else if(randomIndex == 7)
            {
                spawnCat.transform.Rotate(0, -90, 0);
            }
            else if(randomIndex == 8)
            {
                spawnCat.transform.Rotate(0, 90, 0);
            }
        }
        else if(SurivivalTimeController300.ScorePotentialTimer >= 100)
        {
            LimitedCatPopulation = 40;
        }
        else if(SurvivalTimeController500.ScorePotentialTimer >= 100)
        {
            LimitedCatPopulation = 60;
        }
        else
        {
            //Debug.Log("Some errors happened");
        }
    }
}
