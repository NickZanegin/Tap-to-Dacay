using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    AudioSource ButtonSound;

    private void Start()
    {
        ButtonSound = GetComponent<AudioSource>();
    }
    public void Play()
    {
        ButtonSound.pitch = Random.Range(0.75f, 1.25f);
        ButtonSound.Play();
    }
}
