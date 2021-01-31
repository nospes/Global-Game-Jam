using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Christlightquest : MonoBehaviour
{
    GameObject obj;
    GameObject ghost;
    public Sprite ghostimg;

    public Sprite Image
    {
        get { return ghostimg; }
    }

    // Start is called before the first frame update
    void Awake()
    {
        obj = GameObject.FindGameObjectWithTag("Medium");
        ghost = GameObject.FindGameObjectWithTag("Ghost");
    }

    private void Start()
    {
        bool checkexist = obj.GetComponent<mediumstate>().Christmas();

        if (checkexist)
        {
            ghost.transform.GetComponent<mediumobject>().trueimage = ghostimg;
            Destroy(gameObject);
        }

    }
}
