using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ImportantExplanationController : MonoBehaviour
{
    public Button DiffSelectButton;
    // Start is called before the first frame update
    void Start()
    {
        DiffSelectButton.onClick.AddListener(OnDiffSelectButtonClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnDiffSelectButtonClick()
    {
        SceneManager.LoadScene("DiffSelect");
    }
}
