using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(AudioClipPreset))]
public class AudioClipPresetPresetEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        if (GUILayout.Button("Preview"))
        {
            var audioSource = FindObjectOfType<AudioSource>();
            ((AudioClipPreset)target).Play(audioSource);
        }
    }
}