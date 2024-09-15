using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Vector3 minBounds = new Vector3(-50, 0, 50);
    public Vector3 maxBounds = new Vector3(50, 45, 50);
    public static GameManager gameManager;
    public GameObject Seaweed;
    // Start is called before the first frame update

    void Awake()
    {
        if(gameManager == null)
        {
            gameManager = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
