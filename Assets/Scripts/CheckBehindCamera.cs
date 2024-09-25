using UnityEngine;
using UnityEngine.UI;

public class CheckBehindCamera : MonoBehaviour
{
    public float detectionDistance = 10f; // 検知する最大距離
    public Text Warning;
    public int rayCount = 10;
    public float angleRange = 60f;
    void Update()
    {
        // カメラの後ろの方向を計算
        Vector3 directionBehind = -Camera.main.transform.forward;

        // カメラの位置を取得
        Vector3 cameraPosition = Camera.main.transform.position;

        for(int i = 0; i < rayCount; i++)
        {
            float angle = Mathf.Lerp(-angleRange / 2, angleRange / 2, i / (float)(rayCount - 1));
            Quaternion rotation = Quaternion.Euler(-angle, 0, angle);
            Vector3 rayDirection = rotation * directionBehind; 
            // レイキャストを使って後ろのオブジェクトを検知
            RaycastHit hit;
            if (Physics.Raycast(cameraPosition, rayDirection, out hit, detectionDistance))
            {
                // ヒットしたオブジェクトが "Cat" タグを持っているか確認
                if (hit.collider.CompareTag("Cat"))
                {
                    Warning.gameObject.SetActive(true);
                }
                else
                {
                    Warning.gameObject.SetActive(false);
                }
            }
        }
        // デバッグ用にレイを表示する
        Debug.DrawRay(cameraPosition, directionBehind * detectionDistance, Color.red);
    }
}
