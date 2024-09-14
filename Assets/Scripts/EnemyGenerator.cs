using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject[] catPrefabs = new GameObject[6];
    private Vector3[] VectorArray = new Vector3[5];
    float timer =0;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < VectorArray.Length - 1; i++)
        {
            if(i == 0)
            {
                VectorArray[i] = new Vector3(Random.Range(-40, 40), Random.Range(-15, 15), 80); 
            }
            else if(i == 1)
            {
                VectorArray[i] = new Vector3(Random.Range(-40, 40), Random.Range(-15, 15), -80);
            }
            else if(i == 2)
            {
                VectorArray[i] = new Vector3(-70, Random.Range(-15, 15), Random.Range(-40, 40));
            }
            else if(i == 3)
            {
                VectorArray[i] = new Vector3(70, Random.Range(-15, 15), Random.Range(-40, 40));
            }
            else if(i == 4)
            {
                VectorArray[i] = new Vector3(Random.Range(-40, 40), 30, Random.Range(-40,40));
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        int randomIndex = Random.Range(0, VectorArray.Length - 1);
        GameObject randomCat = catPrefabs[Random.Range(0, catPrefabs.Length - 1)];
        timer += Time.deltaTime;
        if(timer > 2.0f)
        {
            timer = 0;
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
                spawnCat.transform.Rotate(90, 0, 0);
            }
        }
    }
}
