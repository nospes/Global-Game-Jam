using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mediumobject : MonoBehaviour
{
    public Image image;
    bool mediumtrue = false;

    private void Awake()
    {
        image = GetComponent<Image>();
        var tempColor = image.color;
        tempColor.a = 0f;
        image.color = tempColor;
    }

    public float timer = 0;
    public float waitTime = 10;

    private void Update()
    {
        mediumtrue = GameObject.FindGameObjectWithTag("Medium").GetComponent<mediumstate>().medium;


            if (mediumtrue)
        {
            image = GetComponent<Image>();
            var tempColor = image.color;
            tempColor.a = 1f;
            image.color = tempColor;

        }
        else
        {
            image = GetComponent<Image>();
            var tempColor = image.color;
            tempColor.a = 0f;
            image.color = tempColor;
        }
    }
}
