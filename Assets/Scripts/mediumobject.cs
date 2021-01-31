using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mediumobject : MonoBehaviour
{
    [SerializeField] public Sprite trans;
    [SerializeField] public Sprite trueimage;
    public bool mediumtrue;

    private void Awake()
    {
        mediumtrue = false;
    }

    private void Update()
    {
        mediumtrue = GameObject.FindGameObjectWithTag("Medium").GetComponent<mediumstate>().medium;

        if (mediumtrue)
        {
            this.GetComponent<SpriteRenderer>().sprite = trueimage;

        }
            else
        {
            this.GetComponent<SpriteRenderer>().sprite = trans;
        }
    }
}
