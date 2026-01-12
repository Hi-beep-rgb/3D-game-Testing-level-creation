using UnityEngine.Audio;
using UnityEngine;
using Unity.VisualScripting.InputSystem;

[System.Serializable]
public class Sound
{
    public string name;

    public AudioClip clip;

    public AudioMixerGroup mixerGroup; //Allows the mixer to be set as the audios output, other part can be seen in AudioManager.cs

    [Range(0f, 1f)]
    public float volume;
    [Range(0.1f, 3f)]
    public float pitch;


    public bool loop;

    [HideInInspector]
    public AudioSource source;
}
