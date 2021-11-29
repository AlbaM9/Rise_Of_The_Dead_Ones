using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;


public class AudioManager : MonoBehaviour
{
    public AudioMixer music, effects;

    public AudioSource attack, enemydeath, jump, hurt, musicground, pick;

    public static AudioManager instance;

    private void Awake()
    {
        
        if (instance == null)
        {
            instance = this;
        }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayAudio(AudioSource audio) 
    {

        audio.Play();
    }
}
