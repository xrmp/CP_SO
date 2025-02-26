using UnityEngine;
using UnityEngine.UI;

public class AudioDataUI : MonoBehaviour
{
    public AudioData audioData; // ������ �� SO
    public Slider volumeSlider; // ������� ��� ���������
    public Text uniqueIDText;   // ��������� ���� ��� ID
    public Text longTextDisplay; // ��������� ���� ��� �������� ������

    void Start()
    {
        // ������������� ���������� ID
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
            longTextDisplay.text = ""; // ������� ��������� ����
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