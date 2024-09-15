using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatDelayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Cat"))
        {
            Animator catAnimator = other.gameObject.GetComponent<Animator>();

            if(catAnimator != null)
            {
                catAnimator.speed = 0.5f;
            }
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Cat"))
        {
            Animator catAnimator = other.gameObject.GetComponent<Animator>();

            if (catAnimator != null)
            {
                catAnimator.speed = 1.0f;
            }
        }
    }
}
