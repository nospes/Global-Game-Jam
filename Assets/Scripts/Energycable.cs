using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Energycable : MonoBehaviour
{
    GameObject obj;
    [SerializeField] public Sprite turnedon;

    void Awake()
    {
        obj = GameObject.FindGameObjectWithTag("Medium");
        if(obj.GetComponent<mediumstate>().christlight)
        {
        this.GetComponent<SpriteRenderer>().sprite = turnedon;
        }
    }

    private void OnMouseDown()
    {
        obj.GetComponent<mediumstate>().christlight = true;
        this.GetComponent<SpriteRenderer>().sprite = turnedon;
    }
}
