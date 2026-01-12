using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour
{
    void Awake()
    {
        /*AudioManager.instance.musicVol = 1;
        AudioManager.instance.sfxVol = 1;*/
    }

    void Start()
    {
        AudioManager.instance.Play("Background Music");
    }

    // Update is called once per frame
    void Update()
    {
        /*AudioManager.instance.ChangeAudioSourceVolume("Button Click", AudioManager.instance.sfxVol);

        AudioManager.instance.ChangeAudioSourceVolume("Hit", AudioManager.instance.sfxVol);

        AudioManager.instance.ChangeAudioSourceVolume("Background Music", AudioManager.instance.musicVol);*/
    }
}
