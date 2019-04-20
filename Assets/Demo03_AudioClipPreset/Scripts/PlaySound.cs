using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{

    [SerializeField]
    AudioSource audioSource;


    [SerializeField]
    AudioClipPreset sound01;

    [SerializeField]
    AudioClipPreset sound02;


    // Update is called once per frame
    public void Play01()
    {
        sound01.Play(audioSource);
    }
    public void Play02()
    {
        sound02.Play(audioSource);
    }
}
