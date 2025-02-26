using UnityEngine;
using UnityEngine.UI;

public class AudioDataUI : MonoBehaviour
{
    public AudioData audioData; // Ссылка на SO
    public Slider volumeSlider; // Слайдер для громкости
    public Text uniqueIDText;   // Текстовое поле для ID
    public Text longTextDisplay; // Текстовое поле для длинного текста

    void Start()
    {
        // Устанавливаем уникальный ID
        if (audioData != null)
        {
            uniqueIDText.text = audioData.uniqueID;
        }
        else
        {
            Debug.LogError("AudioData is not assigned!");
        }
    }

    public void OnShowListButtonClick()
    {
        if (audioData != null)
        {
            audioData.ShowList();
        }
        else
        {
            Debug.LogError("AudioData is not assigned!");
        }
    }

    public void OnShowTextButtonClick()
    {
        if (audioData != null)
        {
            longTextDisplay.text = audioData.longText;
        }
        else
        {
            Debug.LogError("AudioData is not assigned!");
        }
    }

    public void OnHideAllButtonClick()
    {
        if (audioData != null)
        {
            audioData.HideAll();
            longTextDisplay.text = ""; // Очищаем текстовое поле
        }
        else
        {
            Debug.LogError("AudioData is not assigned!");
        }
    }

    public void OnVolumeSliderChanged(float value)
    {
        Debug.Log($"Volume changed to: {value}");
    }
}