using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    private AudioSource music;
    void Start()
    {
        music = GetComponent<AudioSource>();
        music.Play();
    }

}
