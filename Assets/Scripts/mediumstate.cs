using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mediumstate : MonoBehaviour
{
    public Image image;
    public bool medium = false;
    void Start()
    {
        image = GetComponent<Image>();
        var tempColor = image.color;
        tempColor.a = 0f;
        image.color = tempColor;
    }

    public void ToggleAnalog()
    {
        medium = !medium;
    }

    private void Update()
    {
        if(medium)
        {
            image = GetComponent<Image>();
            var tempColor = image.color;
            tempColor.a = 0.5f;
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
