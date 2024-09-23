using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class CatJammer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerStay(Collider other)
    {
        //Debug.Log("Something collided!");
        if(other.gameObject.CompareTag("Cat"))
        {
            Debug.Log("Cat collided!");
            Animator catAnimator = other.gameObject.GetComponent<Animator>();
            catAnimator.speed = 0.125f;
            Debug.Log("Animation slowed down");
        }
    }
    /*void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Cat"))
        {
            Animator catAnimator = other.gameObject.GetComponent<Animator>();

            if (catAnimator != null)
            {
                catAnimator.speed = 1.0f;
            }
        }
    }*/
}
