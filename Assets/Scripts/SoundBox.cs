using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SoundBox : MonoBehaviour
{
    public AudioClip audioClip;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = audioClip;
        audioSource.Play();
    }

    void Update()
    {
        
    }
}
