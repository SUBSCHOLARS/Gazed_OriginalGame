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
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Something collided!");
        if(other.gameObject.CompareTag("Cat"))
        {
            Debug.Log("Cat collided!");
            /*Animator catAnimator = other.gameObject.GetComponent<Animator>();

            if(catAnimator != null)
            {
                catAnimator.speed = 0.125f;
            }*/
            Destroy(other.transform.parent.gameObject);
            Debug.Log("Destroy cat!");
            StartCoroutine(TimerStopper());
            Debug.Log("Corutine started!");
        }
    }
    IEnumerator TimerStopper()
    {
        EnemyGenerator.timer = 0;
        yield return new WaitForSeconds(3);
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
