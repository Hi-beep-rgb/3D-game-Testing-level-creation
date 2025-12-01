using UnityEngine.Audio;
using UnityEngine;
using System;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    public Sound[] sounds;

    void Awake()
    {
        // if instance is null, store a reference to this instance
        if (instance == null)
        {
            // a reference does not exist, so store it
            instance = this;
        }
        else
        {
            // Another instance of this gameobject has been made so destroy it
            // as we already have one
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);


        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
        }
    }

    public void Play( string name )
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
    }
    /*
    public void PlayClip(int clipNumber)
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.PlayOneShot(clips[clipNumber], 0.7f); // start clip
    }

    public void StopClip()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.Stop(); //stop currently playing clip
    }
    */


}