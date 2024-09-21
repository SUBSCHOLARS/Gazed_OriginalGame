using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeaweedRotator : MonoBehaviour
{
    float RotatingSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(0, RotatingSpeed * Time.deltaTime, 0, Space.Self);
    }
}
