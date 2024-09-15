using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopSceneBoundsDisplay : MonoBehaviour
{
    public GameObject boundsCubePRefab;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 minBounds = GameManager.gameManager.minBounds;
        Vector3 maxBounds = GameManager.gameManager.maxBounds;

        CreateBoundsCube(minBounds, maxBounds);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void CreateBoundsCube(Vector3 minBounds, Vector3 maxBounds)
    {
        Vector3 center = (minBounds + maxBounds) / 2;
        Vector3 size = maxBounds - minBounds;
        GameObject boundsCube = Instantiate(boundsCubePRefab);
        boundsCube.transform.position = center;
        boundsCube.transform.localScale = size;
    }
}
