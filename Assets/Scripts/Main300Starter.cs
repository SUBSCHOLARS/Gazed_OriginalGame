using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main300Starter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Main300Start()
    {
        AudioSource audioSource = GetComponent<AudioSource>();
        audioSource.Play();
        SceneManager.LoadScene("Main300");
    }
}
