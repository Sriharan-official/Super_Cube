using UnityEngine;
using System;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;

    //public static AudioManager instance; = useful in bgm

    private void Awake()
    {
        //if(instance == null)
        //{
        //  instance = this;

        //}
        //else
        //{
        //  Destroy(gameObject);
        //return;
        //}
        //DontDestroyOnLoad(gameObject);

        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;

        }
    }

    public void Play(string name)
    {

        Sound s = Array.Find(sounds, Sound => Sound.name == name);
        if (s == null)
        {
            Debug.LogWarning("sound:" + name + "can't be found");
            return;
        }
        s.source.Play();

    }
    
}
