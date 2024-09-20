using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class RemainingTimeGeometrizer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.DOLocalMove(new Vector3(150, 175, 0), 2000f);
    }
}
