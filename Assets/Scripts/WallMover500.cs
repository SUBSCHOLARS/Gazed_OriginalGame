using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallMover500 : MonoBehaviour
{
    float Speed = 1.0f;
    public GameObject WallOne;
    public GameObject WallTwo;
    public GameObject WallThree;
    public GameObject WallFour;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(SurvivalTimeController500.FishLineChangeDetector >= 250)
        {

            WallOne.SetActive(true);
            WallTwo.SetActive(true);
            WallThree.SetActive(true);
            WallFour.SetActive(true);

            WallOne.transform.position -= new Vector3(1, 0, 0) * Speed * Time.deltaTime;
            WallTwo.transform.position += new Vector3(1, 0, 0) * Speed * Time.deltaTime;
            WallThree.transform.position += new Vector3(0, 0, 1) * Speed * Time.deltaTime;
            WallFour.transform.position -= new Vector3(0, 0, 1) * Speed * Time.deltaTime;
        }
    }
}
