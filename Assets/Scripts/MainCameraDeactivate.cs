using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCameraDeactivate : MonoBehaviour
{
    public Camera MainMainCamera;
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void MainMainCameraDeactivate()
    {
        MainMainCamera.gameObject.SetActive(false);
        Player.gameObject.SetActive(false);
    }
}
