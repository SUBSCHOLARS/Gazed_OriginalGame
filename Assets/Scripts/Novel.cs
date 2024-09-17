using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Novel : MonoBehaviour
{
    private int currentTextIndex = 0;
    public Text textStory;
    public GameObject DiffPanel;
    private string[] storyTexts = {
        "令和X年、",
        "苛烈を極めていた魚と猫との戦争は\n猫陣営側が量子虚数空間に干渉し、\n量子テレポーテーションを可能にしたことで、",
        "魚陣営側の不利を余儀なくされていた。",
        "そのような状況の中、プレイヤーであるあなたは\n猫の研究施設に侵入し、猫の科学技術をUSB(4GB)\nを奪取することに成功した。",
        "しかし、",
        "逃げる途中で、水槽の中に閉じ込められてしまった！！！",
        "テレポート技術を駆使する\n猫の攻撃を掻い潜れ！！！",
        "たまに海藻陣営が助けてくれるかも？？？"
    };
    private void Start()
    {
        Debug.Log("ノベルゲームを開始します");
    }
    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if(currentTextIndex < storyTexts.Length)
            {
                textStory.text = storyTexts[currentTextIndex];
                currentTextIndex++;
            }
            else
            {
                EndNovelGame();
            }
        }
    }
    private void EndNovelGame()
    {
        Debug.Log("ノベルゲームを終了しました");
        DiffPanel.SetActive(true);
    }
}
