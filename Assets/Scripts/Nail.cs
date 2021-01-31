using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nail : MonoBehaviour
{
    GameObject obj;
    [SerializeField]
    public Sprite newSprite;


    public Sprite Image
    {
        get { return newSprite; }
    }


    void Awake()
    {
        obj = GameObject.FindGameObjectWithTag("Medium");
        if (newSprite == this.GetComponent<SpriteRenderer>().sprite)
        {
            obj.GetComponent<mediumstate>().nail = true;
        }
    }

    public void Update()
    {
        if (newSprite == this.GetComponent<SpriteRenderer>().sprite)
        {
            obj.GetComponent<mediumstate>().nail = true;
        }
    }

}