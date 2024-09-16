using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainSceneController : MonoBehaviour
{
    public GameObject Seaweed;
    private SaveManager saveManager;
    // Start is called before the first frame update
    void Start()
    {
        saveManager = FindAnyObjectByType<SaveManager>();
        List<Vector3> savedPositions = saveManager.GetSavedPositions();
        foreach(Vector3 pos in savedPositions)
        {
            Instantiate(Seaweed, pos, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
