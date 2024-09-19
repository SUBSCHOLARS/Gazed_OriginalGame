using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Novel : MonoBehaviour
{
    private int currentTextIndex = 0;
    public GameObject NextButton;
    public Text textStory;
    public GameObject DiffPanel;
    private string[] storyTexts = {
        "令和X年、",
        "苛烈を極めていた魚と猫との戦争は\n猫の元来の液化能力と猫陣営側が量子虚数空間を解析し、生体構成分子の座標配置の正確な\n観測機器を実用化したことに伴う量子テレポーテーションを利用した\n任意有限回の情報転送を可能にしたことで魚陣営側の不利を余儀なくされていた。",
        "そのような状況の中、プレイヤーであるあなたは\n猫の研究施設に侵入し、猫の科学技術をUSB(4GB)\nに入れ、奪取することに成功した。",
        "しかし！！！",
        "逃げる途中で水槽の中に\n閉じ込められてしまった！！！",
        "救援部隊が至急駆けつけるとのことだが\nすぐ来られるわけではない...",
        "テレポート技術を駆使する\n猫の攻撃を掻い潜れ！！！",
        "たまに海藻が\n助けてくれるかも？？？"
    };
    private void Start()
    {
        //Debug.Log("ノベルゲームを開始します");
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
        if(currentTextIndex == 0)
        {
            textStory.fontSize = 26;
        }
        if(currentTextIndex == 1)
        {
            textStory.fontSize = 95;
        }
        if(currentTextIndex == 2)
        {
            textStory.fontSize = 20;
        }
        if(currentTextIndex == 3)
        {
            textStory.fontSize = 20;
        }
        if(currentTextIndex == 4)
        {
            textStory.fontSize = 95;
        }
        if(currentTextIndex == 5)
        {
            textStory.fontSize = 40;
        }
        if(currentTextIndex == 6)
        {
            textStory.fontSize = 35;
        }
        if(currentTextIndex == 7)
        {
            textStory.fontSize = 40;
        }
    }
    private void EndNovelGame()
    {
        //Debug.Log("ノベルゲームを終了しました");
        NextButton.SetActive(true);
    }
}
