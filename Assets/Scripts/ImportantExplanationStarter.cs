using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ImportantExplanationStarter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ImportantExplanationStart()
    {
        AudioSource audioSource = GetComponent<AudioSource>();
        audioSource.Play();
        SceneManager.LoadScene("ImportantExplanation");
    }
}
