using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorPass : MonoBehaviour
{
    GameObject obj;
    GameObject levelobj;
    [SerializeField]
    public int interactionid;
    [SerializeField]
    public int roomchange;

    private AudioSource audioplay;
    public AudioClip door;
    public AudioClip dooropen;

    private void Awake()
    {
        obj = GameObject.FindGameObjectWithTag("Inventory");
        levelobj = GameObject.FindGameObjectWithTag("LevelLoad");
        audioplay = GetComponent<AudioSource>();
    }

    void OnMouseDown()
    {
        if (obj.GetComponent<Inventory>().actionid == interactionid)
        {
            levelobj.GetComponent<LevelLoader>().LoadNextLevel(roomchange);
            audioplay.PlayOneShot(dooropen, 0.7F);
        }
        else
        {
            obj.GetComponent<Inventory>().actionid = 0;
            audioplay.PlayOneShot(door, 0.7F);
        }
    }
}
