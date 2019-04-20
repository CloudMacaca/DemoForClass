using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class AudioClipPreset : ScriptableObject
{
    [SerializeField]
    AudioClip[] audioClip;

    [MinMaxSlider(0, 2)]
    public Vector2 volume; // x is min, y is max

    [MinMaxSlider(0, 2)]
    public Vector2 pitch; // x is min, y is max

    public void Play(AudioSource source)
    {
        if (audioClip.Length == 0) return;
        source.clip = audioClip[Random.Range(0, audioClip.Length)];
        source.volume = Random.Range(volume.x, volume.y);
        source.pitch = Random.Range(pitch.x, pitch.y);
        source.Play();
    }

}
