using UnityEngine;

public class CheckBehindCamera : MonoBehaviour
{
    public float detectionDistance = 10f; // 検知する最大距離

    void Update()
    {
        // カメラの後ろの方向を計算
        Vector3 directionBehind = -Camera.main.transform.forward;

        // カメラの位置を取得
        Vector3 cameraPosition = Camera.main.transform.position;

        // レイキャストを使って後ろのオブジェクトを検知
        RaycastHit hit;
        if (Physics.Raycast(cameraPosition, directionBehind, out hit, detectionDistance))
        {
            // ヒットしたオブジェクトが "Cat" タグを持っているか確認
            if (hit.collider.CompareTag("Cat"))
            {
                Debug.Log("Cat detected behind the camera!");
            }
        }

        // デバッグ用にレイを表示する
        Debug.DrawRay(cameraPosition, directionBehind * detectionDistance, Color.red);
    }
}
