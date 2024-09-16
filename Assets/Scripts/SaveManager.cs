using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
public class SaveManager : MonoBehaviour
{
    private string savePath;
    private PositionData positionData = new PositionData();
    // Start is called before the first frame update
    void Start()
    {
        savePath = Path.Combine(Application.persistentDataPath, "positions.json");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SavePosition(Vector3 newPosition)
    {
        LoadData();
        positionData.positions.Add(newPosition);
        string json = JsonUtility.ToJson(positionData);
        File.WriteAllText(savePath, json);
    }
    private void LoadData()
    {
        if(File.Exists(savePath))
        {
            string json = File.ReadAllText(savePath);
            positionData = JsonUtility.FromJson<PositionData>(json);
        }
    }
    public List<Vector3>GetSavedPositions()
    {
        LoadData();
        return positionData.positions;
    }
}
