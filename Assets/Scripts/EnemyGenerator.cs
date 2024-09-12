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
                VectorArray[i] = new Vector3(Random.Range(-60, 60), Random.Range(-10, 10), 75); 
            }
            else if(i == 1)
            {
                VectorArray[i] = new Vector3(Random.Range(-60, 60), Random.Range(-10, 10), -75);
            }
            else if(i == 2)
            {
                VectorArray[i] = new Vector3(-75, Random.Range(-10, 10), Random.Range(-60, 60));
            }
            else if(i == 3)
            {
                VectorArray[i] = new Vector3(75, Random.Range(-10, 10), Random.Range(-60, 60));
            }
            else if(i == 4)
            {
                VectorArray[i] = new Vector3(Random.Range(-50, 50), 30, Random.Range(-50,50));
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

        timer += Time.deltaTime;
        if(timer > 2.0f)
        {
            timer = 0;
            Instantiate(catPrefabs[Random.Range(0, catPrefabs.Length - 1)], VectorArray[Random.Range(0, VectorArray.Length -1)], transform.rotation);
            if(VectorArray[Random.Range(0, VectorArray.Length - 1)] == VectorArray[0])
            {
                return;
            }
            else if(VectorArray[Random.Range(0, VectorArray.Length - 1)] == VectorArray[1])
            {
                catPrefabs[Random.Range(0, catPrefabs.Length - 1)].transform.Rotate(0, 180, 0);
            }
            else if(VectorArray[Random.Range(0, VectorArray.Length - 1)] == VectorArray[2])
            {
                catPrefabs[Random.Range(0, catPrefabs.Length - 1)].transform.Rotate(0, -90, 0);
            }
            else if(VectorArray[Random.Range(0, VectorArray.Length - 1)] == VectorArray[3])
            {
                catPrefabs[Random.Range(0, catPrefabs.Length - 1)].transform.Rotate(0, 90, 0);
            }
            else if(VectorArray[Random.Range(0, VectorArray.Length - 1)] == VectorArray[4])
            {
                catPrefabs[Random.Range(0, catPrefabs.Length - 1)].transform.Rotate(90, 0, 0);
            }
        }
    }
}
