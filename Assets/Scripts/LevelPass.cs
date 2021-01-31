using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelPass : MonoBehaviour
{
    GameObject obj;
    private AudioSource audioplay;
    public AudioClip walk;


    [SerializeField]
    public int roomchange;

    private void Awake()
    {
        obj = GameObject.FindGameObjectWithTag("LevelLoad");
        audioplay = GetComponent<AudioSource>();
    }

    void OnMouseDown()
    {
        audioplay.PlayOneShot(walk, 0.7f);
        obj.GetComponent<LevelLoader>().LoadNextLevel(roomchange);
    }

}
