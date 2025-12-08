using UnityEngine;

public class MusicVolumeScript : MonoBehaviour
{
    public void ChangeMusicVolume( float vol )
    {
        AudioManager.instance.musicVol = vol;
    }
}
