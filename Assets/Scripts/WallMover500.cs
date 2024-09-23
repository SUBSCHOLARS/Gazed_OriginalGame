using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallMover500 : MonoBehaviour
{
    float Speed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(SurvivalTimeController500.ScorePotentialTimer >= 250)
        {
            GameObject WallOne = GameObject.FindGameObjectWithTag("MoveOne");
            GameObject WallTwo = GameObject.FindGameObjectWithTag("MoveTwo");
            GameObject WallThree = GameObject.FindGameObjectWithTag("MoveThree");
            GameObject WallFour = GameObject.FindGameObjectWithTag("MoveFour");

            WallOne.transform.position -= new Vector3(1, 0, 0) * Speed * Time.deltaTime;
            WallTwo.transform.position += new Vector3(1, 0, 0) * Speed * Time.deltaTime;
            WallThree.transform.position += new Vector3(0, 0, 1) * Speed * Time.deltaTime;
            WallFour.transform.position -= new Vector3(0, 0, 1) * Speed * Time.deltaTime;

            Debug.Log("Walls are moving");
        }
    }
}
