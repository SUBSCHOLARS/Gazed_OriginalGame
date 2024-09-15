using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyVanisher : MonoBehaviour
{
    private Animator catAnimator;
    // Start is called before the first frame update
    void Start()
    {
        catAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(catAnimator.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1.0f)
        {
            Destroy(transform.parent.gameObject);
        }
    }
}
