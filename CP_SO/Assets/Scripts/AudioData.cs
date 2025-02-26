using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "NewAudioData", menuName = "Audio Data", order = 51)]
public class AudioData : ScriptableObject
{
    public string uniqueID; // Уникальный идентификатор
    [TextArea(5, 10)]
    public string longText; // Длинный текст
    public List<AudioClipData> audioClips = new List<AudioClipData>(); // Список аудиоклипов

    public void ShowList()
    {
        foreach (var audioClip in audioClips)
        {
            if (audioClip.clip != null) // Проверяем, что клип не null
            {
                Debug.Log($"Clip: {audioClip.clip.name}, Volume: {audioClip.volume}");
            }
            else
            {
                Debug.LogWarning("AudioClip is missing!");
            }
        }
    }

    public void ShowText()
    {
        Debug.Log(longText);
    }

    public void HideAll()
    {
        Debug.Log("All elements are hidden.");
    }
}