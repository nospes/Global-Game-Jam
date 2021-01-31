using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mediumstate : MonoBehaviour
{
    public Image image;
    public bool medium = false;

    private void Awake()
    {
        christlight = false;
    }

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

    public float timeElapsed;
    public float mediumTime;

    private void Update()
    {
        //medium state

        
        if(timeElapsed>=mediumTime)
        {
            medium = false;
        }


        if (medium)
        {
            timeElapsed += Time.deltaTime;
            image = GetComponent<Image>();
            var tempColor = image.color;
            tempColor.a = 0.5f;
            image.color = tempColor;
        }
        else
        {
            timeElapsed -= Time.deltaTime;
            image = GetComponent<Image>();
            var tempColor = image.color;
            tempColor.a = 0f;
            image.color = tempColor;
        }

        if (timeElapsed < 0)
            timeElapsed = 0;
        if (timeElapsed > mediumTime)
            timeElapsed = mediumTime;

        Debug.Log(timeElapsed);
    }

    //medium light quest

    public bool christlight;

    public bool Christmas()
    {
        bool christtrue = christlight;
        return christtrue;
    }

    //NailQuest

    public bool nail;

    public void Nailquestcomplete()
    {
        nail = true;
    }
    public bool Nailquest()
    {
        bool nailtrue = nail;
        return nailtrue;
    }

}
