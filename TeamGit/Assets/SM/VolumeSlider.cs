using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeSlider : MonoBehaviour
{
    // Start is called before the first frame update
    public Slider volumeSlider;
    void Start()
    {
        volumeSlider.onValueChanged.AddListener(OnVolumeChanged);

        // 시작 시 현재 볼륨 값 반영
        volumeSlider.value = AudioListener.volume;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnVolumeChanged(float value)
    {
        GameInstance.Instance.GameVolume = value;
        Debug.Log("Volume changed: " + value);
    }

    private void OnDestroy()
    {
        
    }

}
