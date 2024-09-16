using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleMainCameraController : MonoBehaviour
{
    public GameObject SeaWeed;
    private SaveManager saveManager;
    // Start is called before the first frame update
    void Start()
    {
        saveManager = FindObjectOfType<SaveManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
            {
                transform.position += new Vector3(0, 0, 10) * Time.deltaTime;
                Debug.Log("Camera moved");
            }
            if(Input.GetKey(KeyCode.S))
            {
                transform.position += new Vector3(0, 0, -10) * Time.deltaTime;
                Debug.Log("Camera moved");
            }
            if(Input.GetKey(KeyCode.A))
            {
                transform.position += new Vector3(-10, 0, 0) * Time.deltaTime;
                Debug.Log("Camera moved");
            }
            if(Input.GetKey(KeyCode.D))
            {
                transform.position += new Vector3(10, 0, 0) * Time.deltaTime;
                Debug.Log("Camera moved");
            }
            if(Input.GetMouseButtonDown(0))
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;

                if (Physics.Raycast(ray, out hit, Mathf.Infinity))
                {
                    Vector3 spawnPosition = hit.point;
                    //Instantiate(SeaWeed, spawnPosition, Quaternion.identity);
                    saveManager.SavePosition(spawnPosition);
                    Debug.Log("done");
                }
            }
    }
}
