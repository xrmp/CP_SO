using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "NewAudioData", menuName = "Audio Data", order = 51)]
public class AudioData : ScriptableObject
{
    public string uniqueID; // ���������� �������������
    [TextArea(5, 10)]
    public string longText; // ������� �����
    public List<AudioClipData> audioClips = new List<AudioClipData>(); // ������ �����������

    public void ShowList()
    {
        foreach (var audioClip in audioClips)
        {
            if (audioClip.clip != null) // ���������, ��� ���� �� null
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