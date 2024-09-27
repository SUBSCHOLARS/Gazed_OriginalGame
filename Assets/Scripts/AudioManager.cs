using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    public Slider volumeSlider; // UIのSlider
    private List<AudioSource> audioSources; // 全てのAudioSourceを格納するリスト

    void Start()
    {
        // シーン内の全てのAudioSourceコンポーネントを探してリストに格納
        audioSources = new List<AudioSource>(FindObjectsOfType<AudioSource>());

        // Sliderの値が変わったときに音量を調整するイベントリスナーを登録
        volumeSlider.onValueChanged.AddListener(SetVolume);

        // スライダーの初期値を設定（例えば最大音量を1とする）
        volumeSlider.value = 1.0f;
        DontDestroyOnLoad(this);
    }

    // スライダーの値に基づいて全てのAudioSourceの音量を変更
    public void SetVolume(float volume)
    {
        foreach (AudioSource audioSource in audioSources)
        {
            audioSource.volume = volume;
        }
    }
}
