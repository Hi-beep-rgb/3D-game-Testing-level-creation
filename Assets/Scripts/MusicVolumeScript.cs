using UnityEngine;
using UnityEngine.UI;

public class MusicVolumeScript : MonoBehaviour
{
    public void ChangeMusicVolume( float vol )
    {
        AudioManager.instance.musicVol = vol;
    }

    public void ChangeSFXVolume(float volume)
    {
        AudioManager.instance.sfxVol = volume;
    }
}
