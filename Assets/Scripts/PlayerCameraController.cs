using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCameraController : MonoBehaviour
{
    public Transform player; // プレイヤーのTransformをアサインする
    public Vector3 offset = new Vector3(0, 5, -10); // カメラとプレイヤーの距離（背後に配置するためのオフセット）
    public float sensitivity = 5.0f; // マウス感度
    public float smoothSpeed = 0.125f;
    //public float distanceFromPlayer = 10f; // プレイヤーとの距離
    public float verticalRotationLimit = 80f; // 上下視点の回転制限

    private float pitch = 0f; // 上下回転（ピッチ）
    private float yaw = 0f;   // 左右回転（ヨー）

    void Start()
    {
        // カーソルを非表示にし、ゲームウィンドウ内にロック
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        // マウス入力に基づいてyaw（左右）とpitch（上下）を計算
        yaw += Input.GetAxis("Mouse X") * sensitivity;
        pitch -= Input.GetAxis("Mouse Y") * sensitivity;

        // ピッチの値を上下の制限内にクランプ（これにより、カメラが上下回転しすぎないようにする）
        pitch = Mathf.Clamp(pitch, -verticalRotationLimit, verticalRotationLimit);

        Quaternion rotation = Quaternion.Euler(pitch, yaw, 0);
        Vector3 desiredPosition =player.position + rotation * offset;

        transform.position = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        transform.LookAt(player.position);
        
        /*player.localRotation = Quaternion.Euler(0, yaw, 0);

        // カメラの位置をプレイヤーの背後に設定
        //Vector3 targetPosition = player.position + offset;

        // カメラの回転を設定
        //transform.position = targetPosition;
        transform.localRotation = Quaternion.Euler(pitch, 0, 0);

        // プレイヤーの背後に一定の距離を保つ
        /*Vector3 direction = transform.rotation * Vector3.forward;
        transform.position = player.position - direction * distanceFromPlayer + offset;*/
    }
}
