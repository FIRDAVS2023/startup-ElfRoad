using UnityEngine;
using System;


public class MusicControl : MonoBehaviour 
{
    private static AudioSource _audioSource;
    private DateTime _time;
    private static MusicControl _instance;
    public bool IsPlayMusic { get; set; } = false;

    public static MusicControl Instance()
    {
        if (_instance == null)
        {
            _instance = new MusicControl();
        }
        return _instance;
    }
    private MusicControl() 
    {
        
        print("Init MusicControl");
    }

    public void Start()
    {
        print("Start MusicControl");
        DontDestroyOnLoad(Instance());
        
    }

    public AudioSource GetMusic()
    {
        print("Get Music");
        return _audioSource;
    }

    public void SetMusic(AudioSource audio)
    {
        print("Set Music");
        Destroy(_audioSource);
        _audioSource = audio;
        DontDestroyOnLoad(_audioSource);
    }

    public void PlayBackgroundSound()
    {
        print("Play Music");
        if (_audioSource != null && !_audioSource.isPlaying)
        {
            _audioSource?.Play();
        }
    }

    public void StopBackgroundSound()
    {
        IsPlayMusic = false;
        _audioSource?.Stop();
    }

}
