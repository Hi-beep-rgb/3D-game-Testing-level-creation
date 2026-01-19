using UnityEngine;
using UnityEngine.Audio;

public class MuteAudioScript : MonoBehaviour
{
    private bool isMuted;

    private void Start()
    {
        isMuted = PlayerPrefs.GetInt("MUTED") == 1;
        AudioListener.pause = isMuted;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void MuteToggle()
    {
        isMuted = !isMuted;
        AudioListener.pause = isMuted;
        PlayerPrefs.SetInt("MUTED", isMuted ? 1 : 0);
    }
}
