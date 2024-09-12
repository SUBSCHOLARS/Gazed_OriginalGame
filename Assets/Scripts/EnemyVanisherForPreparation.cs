using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class EnemyVanisherForPreparation : MonoBehaviour
{
    private float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= 2.0f)
        {
            Destroy(gameObject);
            Debug.Log("Destroy static object");
        }
    }
}
